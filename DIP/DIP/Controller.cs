using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP
{
	public partial class Controller : Form
	{
		private VisibleAlarm alarm;

		public Controller(VisibleAlarm lamp)
		{
			InitializeComponent();
			Slider.Minimum = 0;
			Slider.Maximum = 100;

			this.setAlarm(lamp);
		}

		public void setAlarm(VisibleAlarm alarm )
		{
			this.alarm = alarm;
		}

		private void Slider_Scroll(object sender, EventArgs e)
		{
			if (Slider.Value >= 50)
			{
				alarm.turnON();
			}
			else
			{
				alarm.turnOFF();
			}
		}
	}
}
