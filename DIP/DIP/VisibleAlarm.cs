using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DIP
{
	public class VisibleAlarm: Form, ControllerServer
	{
		private bool status;

		public VisibleAlarm()
		{
			status = false;
			this.BackColor = Color.Blue;
			this.Text = "Visible Alarm";
			this.Height = 150;
			this.Width = 150;
			this.Show();
		}
		public void turnON()
		{
			red();
		}
		public void turnOFF()
		{
			blue();
		}

		private void red()
		{
			status = true;
			this.BackColor = Color.Red;
		}

		private void blue()
		{
			status = false;
			this.BackColor = Color.Blue;
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// VisibleAlarm
			// 
			this.ClientSize = new System.Drawing.Size(120, 11);
			this.Name = "VisibleAlarm";
			this.ResumeLayout(false);

		}
	}
}
