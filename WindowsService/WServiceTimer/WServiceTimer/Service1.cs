using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace WServiceTimer
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();   
        public Service1()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 10000;
            timer.Enabled = true;
        }
        protected override void OnStop()
        {
            WriteToFile();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile();
        }
        public void WriteToFile()
        {
            string actualtime = DateTime.Now.ToString("hh:mm tt");
            string expectedtime = "08:12 AM";
            if (actualtime == expectedtime)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog" + ".txt";
                if (!File.Exists(filepath))
                {
                     
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        sw.WriteLine(String.Format("Custom Activity started at {0}",DateTime.Now.ToString()));
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(String.Format("Custom Activity started at {0}", DateTime.Now.ToString()));
                    }
                }
            }
        }
    }
}