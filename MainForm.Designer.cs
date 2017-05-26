/*
 * Created by SharpDevelop.
 * User: The Administrator
 * Date: 5/24/2017
 * Time: 8:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Clicker2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button upgradeBtn;
		private System.Windows.Forms.TextBox upgradebox;
		private System.Windows.Forms.TextBox totalbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label profit1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.upgradeBtn = new System.Windows.Forms.Button();
			this.upgradebox = new System.Windows.Forms.TextBox();
			this.totalbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.profit1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "STOP";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 62);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(218, 25);
			this.progressBar1.TabIndex = 2;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// upgradeBtn
			// 
			this.upgradeBtn.Location = new System.Drawing.Point(307, 62);
			this.upgradeBtn.Name = "upgradeBtn";
			this.upgradeBtn.Size = new System.Drawing.Size(75, 23);
			this.upgradeBtn.TabIndex = 3;
			this.upgradeBtn.Text = "Upgrade";
			this.upgradeBtn.UseVisualStyleBackColor = true;
			this.upgradeBtn.Click += new System.EventHandler(this.UpgradeBtnClick);
			// 
			// upgradebox
			// 
			this.upgradebox.Location = new System.Drawing.Point(388, 64);
			this.upgradebox.Name = "upgradebox";
			this.upgradebox.Size = new System.Drawing.Size(61, 20);
			this.upgradebox.TabIndex = 4;
			// 
			// totalbox
			// 
			this.totalbox.Location = new System.Drawing.Point(249, 236);
			this.totalbox.Name = "totalbox";
			this.totalbox.Size = new System.Drawing.Size(218, 20);
			this.totalbox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(143, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Total Cash";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// profit1
			// 
			this.profit1.ForeColor = System.Drawing.Color.ForestGreen;
			this.profit1.Location = new System.Drawing.Point(249, 62);
			this.profit1.Name = "profit1";
			this.profit1.Size = new System.Drawing.Size(52, 23);
			this.profit1.TabIndex = 7;
			this.profit1.Text = "profits";
			this.profit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 268);
			this.Controls.Add(this.profit1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.totalbox);
			this.Controls.Add(this.upgradebox);
			this.Controls.Add(this.upgradeBtn);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Clicker2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
