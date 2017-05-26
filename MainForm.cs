/*
 * Created by SharpDevelop.
 * User: The Administrator
 * Date: 5/24/2017
 * Time: 8:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clicker2
{
	//SUMMARY - Intended as a simple clicker function for purposes of review and feedback on how to better structure the code following OOP principals.
	
	public partial class MainForm : Form
	{
		//VARIABLES
		int total;
		int upgradeValue;
		int upgradeLevel;
		int profit;
		
		//Constructor
		public MainForm()
		{
			InitializeComponent();
			
			profit = 10;
			total = 0;
			upgradeValue = 3;
			upgradeLevel = 1;
			totalbox.Text = total.ToString();
			upgradebox.Text = upgradeValue.ToString();
			
			profit1.Text = profit.ToString();
		}
		
		
		//START Button
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Start();
			timer1.Interval = 1000;
		}
		
		//STOP Button
		void Button2Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		
		//Timer Ticker functions
		void Timer1Tick(object sender, EventArgs e)
		{
			progressBar1.Minimum = 0;
			progressBar1.Maximum = 100;
			
			if (progressBar1.Value < progressBar1.Maximum)
			{
				progressBar1.Value = progressBar1.Value +20;
				
			}
			
			if (progressBar1.Value == 100)
			{
				total += profit;
				totalbox.Text = total.ToString();
				progressBar1.Value = 0;
			}
		}
		
		
		void UpgradeBtnClick(object sender, EventArgs e)
		{
			
			if (total >= upgradeValue)
			{
				total -= upgradeValue;
				totalbox.Text = total.ToString();
				
				profit += upgradeValue;
				profit1.Text = profit.ToString();
				
				//upgrade values must follow profit values otherwise profits will gain the additional "upgradeLevel" value and throw off profits.
				upgradeValue += upgradeLevel;
				upgradebox.Text = upgradeValue.ToString();
				
				
			}
			
	
			
		}
		
		
		
	}
}
