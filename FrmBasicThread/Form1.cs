using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyThreadClass
        {
            public static void threadMethodLetter() 
            {
                Thread thread = Thread.CurrentThread;
                for (int i = 0; i <= 5; i++) 
                {
                    Console.WriteLine(thread.Name + " prints number " + i);
                    Thread.Sleep(1500);
                }
            }

            public static void threadMethodNumber()
            {
                Thread thread = Thread.CurrentThread;
                for (char c = 'A'; c <= 'E'; c++)
                {
                    Console.WriteLine(thread.Name + " prints letter " + c);
                    Thread.Sleep(1500);
                }
            }

        }

        public class FrmBasicThread
        {
            public static void Threads(Label threadlbl)
            {              
                
                Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.threadMethodNumber));
                Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.threadMethodLetter));

                ThreadA.Name = "Thread A";
                ThreadB.Name = "Thread B";

                ThreadA.Start();
                ThreadB.Start();

                ThreadA.Join();
                ThreadB.Join();

                Console.WriteLine("- End of Thread -");
                threadlbl.Text = "- End of Thread -";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBasicThread.Threads(lblthread);
        }
    }
}
