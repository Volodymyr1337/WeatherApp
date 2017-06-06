using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Weather_app
{
    public partial class Form1 : Form
    {
        string url = "";
        string city = "Kiev";
        string countryCode = "ua";
        string weatherImageName = "";
        ushort interval = 60000; // interval between requests

        public Form1()
        {
            InitializeComponent();

            city = Properties.Settings.Default.city.Length > 0 ? Properties.Settings.Default.city : "Kiev";
            countryCode = Properties.Settings.Default.countryCode.Length > 0 ? Properties.Settings.Default.countryCode : "ua";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webrequest.Interval = interval;
            this.BackColor = Color.FromArgb(33, 150, 243);
            temp.BackColor = Color.FromArgb(0, 0, 0, 0);
            WeatherCondition.BackColor = temp.BackColor;
            Settings.BackColor = Color.FromArgb(0, 0, 0, 0);
            web_request();
        }

        private void webrequest_Tick(object sender, EventArgs e)    // timer
        {
            web_request();
        }

        private void web_request()
        {
            /* 
             * for this works
             * you must register at
             * http://openweathermap.org/api
             * and paste into this link your id
             */
            url = @"http://api.openweathermap.org/data/2.5/weather?q=" +
                city + "," + countryCode + "&appid=YourAPIid";

            Console.WriteLine(url);
            string json = new WebClient().DownloadString(url);
 
            RootObject result = JsonConvert.DeserializeObject<RootObject>(json);
            //
            // converting UNIX timestamp to normal date
            //
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(result.dt).ToLocalTime();

            DateTime dtSunrise = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtSunrise = dtSunrise.AddSeconds(result.sys.sunrise).ToLocalTime();

            DateTime dtSunset = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtSunset = dtSunset.AddSeconds(result.sys.sunset).ToLocalTime();
            //
            // title
            //
            header.Text = $"{result.name}, {result.sys.country}, {dtDateTime.DayOfWeek}, {dtDateTime.ToShortDateString()}";
            //
            // weather
            //
            if (result.weather[0].description.Length > 20)
                main.Font = new Font("Microsoft Sans Serif", 14);
            else if (result.weather[0].description.Length > 30)
                main.Font = new Font("Microsoft Sans Serif", 10);

            // loading weather status image from website using result.weather[0].icon
            WebClient client = new WebClient();
            weatherImageName = $"{result.weather[0].icon}.png";
            client.DownloadFileAsync(new Uri($"http://openweathermap.org/img/w/{result.weather[0].icon}.png"), weatherImageName);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(WeatherStatusImage);

            main.Text = result.weather[0].description;
            
            char sign = (result.main.temp - 273.16f) > 0 ? '+' : '-';
            char c = Convert.ToChar(176);
            temp.Text = $"{sign}{round(result.main.temp - 273.16f)}{c}";
            //
            // main
            //
            pressure.Text = (round(result.main.pressure * 0.00750062f * 100f)).ToString() + " mmHg";
            humidity.Text = result.main.humidity.ToString() + "% humidity";
            wind.Text = result.wind.speed.ToString() + " m/s wind";

            // display window direction character
            string windDirection = "\u219b";
            if (result.wind.deg >= 0 && result.wind.deg < 80)
                windDirection = (result.wind.deg <= 10) ? "\u21d2" : "\u21d7";
            if (result.wind.deg >= 80 && result.wind.deg < 170)
                windDirection = (result.wind.deg <= 100) ? "\u21d1" : "\u21d6";
            if (result.wind.deg >= 170 && result.wind.deg < 260)
                windDirection = (result.wind.deg <= 190) ? "\u21d0" : "\u21d9";
            if (result.wind.deg >= 260)
                windDirection = (result.wind.deg <= 280) ? "\u21d3" : (result.wind.deg >= 350) ? "\u21d2" : "\u21d8";

            windArrow.Text = windDirection;

            visibility.Text = result.visibility.ToString() + " m visibility";
            
            sunrise.Text = dtSunrise.ToShortTimeString() + " sunrise";
            sunset.Text = dtSunset.ToShortTimeString() + " sunset";
        }

        private int round(float f)
        {
            if (f < 0)  f *= -1;

            return (1 - (f - (int)f)) <= 0.5 ? (int)++f : (int)f;
        }
        private void WeatherStatusImage(object sender, AsyncCompletedEventArgs e)
        {
            WeatherCondition.Image = Image.FromFile(weatherImageName);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Hide();
            SettingsPanel.Show();
        }

        private void SettingsOK_Click(object sender, EventArgs e)
        {
            if (SettingsTextBox1.Text.Length > 0 && SettingsTextBox2.Text.Length > 0)
            {
                city = SettingsTextBox1.Text;
                countryCode = SettingsTextBox2.Text;

                Properties.Settings.Default.city = city;
                Properties.Settings.Default.countryCode = countryCode;
                Properties.Settings.Default.Save();
                web_request();
            }
            SettingsPanel.Hide();
            tableLayoutPanel2.Show();
            
        }

        private void SettingsCancel_Click(object sender, EventArgs e)
        {
            SettingsPanel.Hide();
            tableLayoutPanel2.Show();
        }
        private void button_mousehover(object sender, EventArgs e)
        {
            Settings.BackColor = Color.FromArgb(33, 150, 243);
        }
    }
    
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
    }

    public class Wind
    {
        public int speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public float message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class RootObject
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

}
