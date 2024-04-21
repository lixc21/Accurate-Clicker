using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace Accurate_mouse_clicker
{
    public partial class Form1 : Form
    {
        public int data_hour;
        public int data_minute;
        public double data_second;
        public double data_time_offset;

        public Form1()
        {
            InitializeComponent();
            is_running = false;
            try
            {
                var ini_file_path = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "//accurate_mouse_clicker.ini";
                if (File.Exists(ini_file_path))
                {
                    using (StreamReader sr = new StreamReader(ini_file_path))
                    {
                        data_hour = int.Parse(sr.ReadLine());
                        data_minute = int.Parse(sr.ReadLine());
                        data_second = double.Parse(sr.ReadLine());
                        data_time_offset = double.Parse(sr.ReadLine());
                        sr.Close();
                    }
                    textBox1.Text = data_hour.ToString();
                    textBox2.Text = data_minute.ToString();
                    textBox3.Text = data_second.ToString();
                    textBox4.Text = data_time_offset.ToString();
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                data_hour = int.Parse(textBox1.Text);
                data_minute = int.Parse(textBox2.Text);
                data_second = double.Parse(textBox3.Text);
                data_time_offset = double.Parse(textBox4.Text);
                save_ini_file();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public bool is_running;
        public Thread childThread;
        private void button1_Click(object sender, EventArgs e)
        {
            if (is_running)
            {
                is_running = false;
                label5.Text = "state: non-active";
                button1.Text = "run";
            }
            else
            {
                label5.Text = String.Format("state: waiting to click at {0}:{1}:{2}", data_hour, data_minute, data_second);
                is_running = true;
                ThreadStart childref = new ThreadStart(CallToChildThread);
                childThread = new Thread(childref);
                childThread.Start();
                button1.Text = "stop";
            }
        }

        public void CallToChildThread()
        {
            DateTime now = DateTime.Now;
            var data_second_int = Convert.ToInt32(Math.Floor(data_second));
            var data_millisecond = Convert.ToInt32(Math.Floor((data_second - data_second_int) * 1000));
            DateTime target = new DateTime(now.Year, now.Month, now.Day, data_hour, data_minute, data_second_int, data_millisecond);
            target = target.AddSeconds(data_time_offset);
            if (DateTime.Compare(now, target) > 0)
            {
                Console.WriteLine("now is over target");
                target = target.AddDays(1);
            }

            while (true)
            {
                if (!is_running)
                    break;
                now = DateTime.Now;
                if (DateTime.Compare(now, target) > 0)
                {
                    //Call the imported function with the cursor's current position
                    uint X = (uint)Cursor.Position.X;
                    uint Y = (uint)Cursor.Position.Y;
                    mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                    Thread.Sleep(30);
                    mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    this.Invoke(() => { button1_Click(new object(), new EventArgs()); }, new object[] { });
                    break;
                }
            }
        }



        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data_hour = int.Parse(textBox1.Text);
                if (data_hour < 0)
                    data_hour = 0;
                if (data_hour > 23)
                    data_hour = 23;
                textBox1.Text = data_hour.ToString();
                save_ini_file();
            }
            catch { textBox1.Text = data_hour.ToString(); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data_minute = int.Parse(textBox2.Text);
                if (data_minute < 0)
                    data_minute = 0;
                if (data_minute > 59)
                    data_minute = 59;
                textBox2.Text = data_minute.ToString();
                save_ini_file();
            }
            catch { textBox2.Text = data_minute.ToString(); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data_second = double.Parse(textBox3.Text);
                if (data_second < 0)
                    data_second = 0;
                if (data_second > 59.999)
                    data_second = 59.999;
                textBox3.Text = data_second.ToString();
                save_ini_file();
            }
            catch { textBox3.Text = data_second.ToString(); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data_time_offset = double.Parse(textBox4.Text);
                save_ini_file();
            }
            catch { textBox4.Text = data_time_offset.ToString(); }
        }

        public void save_ini_file()
        {
            var ini_file_path = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "//accurate_mouse_clicker.ini";
            using (StreamWriter sw = new StreamWriter(ini_file_path))
            {
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            is_running = false;
            Thread.Sleep(100);
        }


        //...other code needed for the application


    }
}