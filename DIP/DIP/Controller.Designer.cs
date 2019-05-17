namespace DIP
{
	partial class Controller
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Slider = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
			this.SuspendLayout();
			// 
			// Slider
			// 
			this.Slider.Location = new System.Drawing.Point(25, 12);
			this.Slider.Name = "Slider";
			this.Slider.Size = new System.Drawing.Size(271, 45);
			this.Slider.TabIndex = 0;
			this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
			// 
			// Controller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 64);
			this.Controls.Add(this.Slider);
			this.Name = "Controller";
			this.Text = "Controller";
			((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar Slider;
	}
}

