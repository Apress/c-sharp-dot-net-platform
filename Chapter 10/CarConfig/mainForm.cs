namespace CarConfig
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	public class CarConfigForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components;
		private System.Windows.Forms.ToolTip calendarTip;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		protected System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		protected System.Windows.Forms.ComboBox comboSalesPerson;
		protected System.Windows.Forms.ListBox carMakeList;
		private System.Windows.Forms.Label infoLabel;
		protected System.Windows.Forms.CheckedListBox checkedBoxRadioOptions;
		protected System.Windows.Forms.Button btnOrder;
		protected System.Windows.Forms.CheckBox checkFloorMats;
		protected System.Windows.Forms.RadioButton radioPink;
		protected System.Windows.Forms.RadioButton radioYellow;
		protected System.Windows.Forms.RadioButton radioRed;
		protected System.Windows.Forms.RadioButton radioGreen;
		protected System.Windows.Forms.GroupBox groupBox1;

		public CarConfigForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CenterToScreen();
		}

		/// <summary>
		///		Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Windows Form Designer generated code
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.components = new System.ComponentModel.Container ();
			this.comboSalesPerson = new System.Windows.Forms.ComboBox ();
			this.radioRed = new System.Windows.Forms.RadioButton ();
			this.groupBox1 = new System.Windows.Forms.GroupBox ();
			this.radioPink = new System.Windows.Forms.RadioButton ();
			this.infoLabel = new System.Windows.Forms.Label ();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar ();
			this.checkedBoxRadioOptions = new System.Windows.Forms.CheckedListBox ();
			this.calendarTip = new System.Windows.Forms.ToolTip (this.components);
			this.radioYellow = new System.Windows.Forms.RadioButton ();
			this.label5 = new System.Windows.Forms.Label ();
			this.carMakeList = new System.Windows.Forms.ListBox ();
			this.radioGreen = new System.Windows.Forms.RadioButton ();
			this.label4 = new System.Windows.Forms.Label ();
			this.checkFloorMats = new System.Windows.Forms.CheckBox ();
			this.label3 = new System.Windows.Forms.Label ();
			this.btnOrder = new System.Windows.Forms.Button ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			comboSalesPerson.Location = new System.Drawing.Point (16, 80);
			comboSalesPerson.Size = new System.Drawing.Size (128, 21);
			comboSalesPerson.TabIndex = 1;
			comboSalesPerson.Items.AddRange(new object[4] {"Baby Ry-Ry", "SPARK!", "Danny Boy", "Karin 'Baby' Johnson"});
			radioRed.Location = new System.Drawing.Point (264, 24);
			radioRed.Text = "Red";
			radioRed.Size = new System.Drawing.Size (64, 23);
			radioRed.TabIndex = 2;
			radioRed.TabStop = true;
			radioRed.BackColor = System.Drawing.SystemColors.ControlLight;
			groupBox1.Location = new System.Drawing.Point (8, 120);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Exterior Color";
			groupBox1.Size = new System.Drawing.Size (432, 56);
			groupBox1.Leave += new System.EventHandler (this.groupBox1_Leave);
			groupBox1.Enter += new System.EventHandler (this.groupBox1_Enter);
			radioPink.Location = new System.Drawing.Point (176, 24);
			radioPink.Text = "Pink";
			radioPink.Size = new System.Drawing.Size (56, 23);
			radioPink.TabIndex = 3;
			radioPink.TabStop = true;
			radioPink.BackColor = System.Drawing.SystemColors.ControlLight;
			infoLabel.Location = new System.Drawing.Point (8, 224);
			infoLabel.Size = new System.Drawing.Size (224, 200);
			infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			infoLabel.Font = new System.Drawing.Font ("Arial", 8);
			infoLabel.TabIndex = 5;
			infoLabel.BackColor = System.Drawing.Color.OldLace;
			monthCalendar.Location = new System.Drawing.Point (248, 224);
			calendarTip.SetToolTip (monthCalendar, "Please select the date (or dates)\n when we can deliver your new car!");
			monthCalendar.TabIndex = 10;
			monthCalendar.TabStop = true;
			checkedBoxRadioOptions.Location = new System.Drawing.Point (168, 32);
			checkedBoxRadioOptions.Cursor = Cursors.Hand;
			checkedBoxRadioOptions.Size = new System.Drawing.Size (152, 64);
			checkedBoxRadioOptions.CheckOnClick = true;
			checkedBoxRadioOptions.TabIndex = 2;
			checkedBoxRadioOptions.Items.AddRange(new object[6] {"Front Speakers", "8-Track Tape Player", "CD Player", "Cassette Player", "Rear Speakers", "Ultra Base Thumper"});
			//@toolTip1.SetLocation (new System.Drawing.Point (7, 7));
			calendarTip.Active = true;
			radioYellow.Location = new System.Drawing.Point (96, 24);
			radioYellow.Text = "Yellow";
			radioYellow.Size = new System.Drawing.Size (56, 23);
			radioYellow.TabIndex = 1;
			radioYellow.TabStop = true;
			radioYellow.BackColor = System.Drawing.SystemColors.ControlLight;
			label5.Location = new System.Drawing.Point (248, 200);
			label5.Text = "Delivery Date:";
			label5.Size = new System.Drawing.Size (184, 16);
			label5.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
			label5.TabIndex = 12;
			carMakeList.Location = new System.Drawing.Point (328, 32);
			carMakeList.Size = new System.Drawing.Size (112, 56);
			carMakeList.ScrollAlwaysVisible = true;
			carMakeList.TabIndex = 3;
			carMakeList.Sorted = true;
			carMakeList.Items.AddRange(new object[9] {"BMW", "Caravan", "Ford", "Grand Am", "Jeep", "Jetta", "Saab", "Viper", "Yugo"});
			radioGreen.Location = new System.Drawing.Point (16, 24);
			radioGreen.Text = "Green";
			radioGreen.Size = new System.Drawing.Size (64, 23);
			radioGreen.TabIndex = 0;
			radioGreen.TabStop = true;
			radioGreen.BackColor = System.Drawing.SystemColors.ControlLight;
			label4.Location = new System.Drawing.Point (16, 200);
			label4.Text = "Order Stats:";
			label4.Size = new System.Drawing.Size (208, 24);
			label4.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
			label4.TabIndex = 11;
			checkFloorMats.Location = new System.Drawing.Point (16, 16);
			checkFloorMats.Text = "Extra Floor Mats";
			checkFloorMats.Size = new System.Drawing.Size (112, 24);
			checkFloorMats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			checkFloorMats.TabIndex = 0;
			label3.Location = new System.Drawing.Point (328, 8);
			label3.Text = "Make:";
			label3.Size = new System.Drawing.Size (112, 16);
			label3.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
			label3.TabIndex = 9;
			btnOrder.Location = new System.Drawing.Point (8, 440);
			btnOrder.Size = new System.Drawing.Size (120, 32);
			btnOrder.TabIndex = 6;
			btnOrder.Text = "Confirm Order";
			btnOrder.Click += new System.EventHandler (this.btnOrder_Click);
			label1.Location = new System.Drawing.Point (16, 56);
			label1.Text = "Sales Person";
			label1.Size = new System.Drawing.Size (144, 24);
			label1.TabIndex = 7;
			label2.Location = new System.Drawing.Point (176, 8);
			label2.Text = "Radio Options:";
			label2.Size = new System.Drawing.Size (144, 16);
			label2.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
			label2.TabIndex = 8;
			this.Text = "Car Configurator";
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.ClientSize = new System.Drawing.Size (456, 485);
			groupBox1.Controls.Add (this.radioPink);
			groupBox1.Controls.Add (this.radioYellow);
			groupBox1.Controls.Add (this.radioRed);
			groupBox1.Controls.Add (this.radioGreen);
			this.Controls.Add (this.label5);
			this.Controls.Add (this.label4);
			this.Controls.Add (this.monthCalendar);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.comboSalesPerson);
			this.Controls.Add (this.carMakeList);
			this.Controls.Add (this.infoLabel);
			this.Controls.Add (this.checkedBoxRadioOptions);
			this.Controls.Add (this.btnOrder);
			this.Controls.Add (this.checkFloorMats);
			this.Controls.Add (this.groupBox1);
		}
		#endregion


		[STAThread]
		static void Main() 
		{
			Application.Run(new CarConfigForm());
		}

		protected void btnOrder_Click (object sender, System.EventArgs e)
		{
			// Build a string to display information.
			string orderInfo = "";

			if(comboSalesPerson.Text != "")
				orderInfo += "Sales Person: " + comboSalesPerson.Text + "\n";
			else
				orderInfo += "You did not select a sales person!" + "\n";

			if(carMakeList.SelectedItem != null)
				orderInfo += "Make: " + carMakeList.SelectedItem + "\n";

			if(checkFloorMats.Checked)
				orderInfo += "You want floor mats.\n";	

			if(radioRed.Checked)
				orderInfo += "You want a red exterior.\n";
			
			if(radioYellow.Checked)
				orderInfo += "You want a yellow exterior.\n";
			
			if(radioGreen.Checked)
				orderInfo += "You want a green exterior.\n";

			if(radioPink.Checked)
				orderInfo += "Why do you want a PINK exterior?\n";
			
			orderInfo += "--------------------------------\n";
			
			// For each item in the CheckedListBox...
			for(int i = 0; i < checkedBoxRadioOptions.Items.Count; i++)
			{
				// Is the current item checked?
				if(checkedBoxRadioOptions.GetItemChecked(i))
				{
					// Get text of current item.
					orderInfo += "Radio Item: ";
					orderInfo += checkedBoxRadioOptions.Items[i];
					orderInfo += "\n";
				}								
			}
			orderInfo += "\n--------------------------------\n";

			// Get ship date.
			DateTime startD = monthCalendar.SelectionStart;
			DateTime endD = monthCalendar.SelectionEnd;

			/* Don't need this anymore!
			string dateStartStr = startD.Month + " / " +
								  startD.Day + " / " +
								  startD.Year;

			string dateEndStr = endD.Month + " / " +
								endD.Day + " / " +
								endD.Year;
			*/
			
			// Get correct string representation.
			//
			string dateStartStr = startD.Date.ToShortDateString();
			string dateEndStr = endD.Date.ToShortDateString();
			
			if(dateStartStr != dateEndStr)
			{
				orderInfo += "Car will be sent between\n" 
					+ dateStartStr + " and\n" + dateEndStr;			
			}
			else // they picked a single date.
				orderInfo += "Car will be sent on\n" 
					+ dateStartStr;

			// Set order info.
			infoLabel.Text = orderInfo;
		}

		protected void groupBox1_Leave (object sender, System.EventArgs e)
		{
			groupBox1.Text = "Exterior Color: Thanks for visiting the group...";
		}

		protected void groupBox1_Enter (object sender, System.EventArgs e)
		{
			groupBox1.Text = "Exterior Color: You are in the group...";
		}
	}
}
