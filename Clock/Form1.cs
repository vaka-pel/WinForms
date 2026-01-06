using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class Form1 : Form
	{
		private int Signal = 0;
		private string NameFile = "";
		private string Hour = "";
		private string Minutes = "";
		private string Seconds = "";

		private string HourNow = "";
		private string MinutesNow = "";
		private string SecondsNow = "";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Hour = DateTime.Now.Hour.ToString();
			Minutes = DateTime.Now.Minute.ToString();
			Seconds = DateTime.Now.Second.ToString();

			if (Hour.Length == 1)
			{
				Hour = "0" + Hour;
			}
			if (Minutes.Length == 1)
			{
				Minutes = "0" + Minutes;
			}
			if (Seconds.Length == 1)
			{
				Seconds = "0" + Seconds;
			}
			textBox1.Text = Hour;
			textBox2.Text = Minutes;
			textBox3.Text = Seconds;
		}
	}
}
