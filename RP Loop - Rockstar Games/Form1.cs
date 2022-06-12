using System;
using System.Windows.Forms;
using System.Threading;
using MemoryNoAdmin;

namespace RP_Loop
{
    public partial class Form1 : Form
    {
        public Mem MemLib = new Mem();
        public Form1()
        {
            InitializeComponent();
            while (true)
            {
                if (!MemLib.OpenProcess("GTA5")) ;
                {
                    Thread.Sleep(100);
                    return;
                }
                Thread.Sleep(100);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) ;
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MemLib.WriteMemory("base+02DB12E8,10", "float", "500");
                MemLib.WriteMemory("base+026A4120,60,888", "int", "1");
                Thread.Sleep(1000);
                MemLib.WriteMemory("base+026A4120,60,888", "int", "0");
                Thread.Sleep(1000);
            }
            else
            {
                MemLib.WriteMemory("base+02DB12E8,10", "float", "1");
                MemLib.WriteMemory("base+026A4120,60,888", "int", "0");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/users/558009992473739289");
        }
    }
}
