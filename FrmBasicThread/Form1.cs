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
            public static void threadMethod() 
            {
                Thread thread = Thread.CurrentThread;
                for (int i = 0; i <= 5; i++) 
                {
                    Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);

                    Thread.Sleep(1500);
                }
            }

        }

        
    }
}
