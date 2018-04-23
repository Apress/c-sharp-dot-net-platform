namespace DataColumns
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    public class DCForm : System.Windows.Forms.Form
    {

        private System.ComponentModel.Container components;
		private System.Windows.Forms.Button btnAutoCol;
		private System.Windows.Forms.Button btnColumn;

        public DCForm()
        {
            InitializeComponent();
			CenterToScreen();
        }

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


		private void InitializeComponent()
		{
			this.btnColumn = new System.Windows.Forms.Button();
			this.btnAutoCol = new System.Windows.Forms.Button();
			this.btnColumn.Location = new System.Drawing.Point(8, 16);
			this.btnColumn.Size = new System.Drawing.Size(344, 40);
			this.btnColumn.TabIndex = 0;
			this.btnColumn.Text = "Build and manipulate basic DataColumn";
			this.btnColumn.Click += new System.EventHandler(this.btnColumn_Click);
			this.btnAutoCol.Location = new System.Drawing.Point(8, 80);
			this.btnAutoCol.Size = new System.Drawing.Size(344, 40);
			this.btnAutoCol.TabIndex = 1;
			this.btnAutoCol.Text = "Auto Increment Column";
			this.btnAutoCol.Click += new System.EventHandler(this.btnAutoCol_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.ClientSize = new System.Drawing.Size(366, 147);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnAutoCol,
																		  this.btnColumn});
			this.Text = "DataColumn Form";

		}

		protected void btnAutoCol_Click (object sender, System.EventArgs e)
		{
			// Make a data column which maps to an int.
			DataColumn myColumn = new DataColumn();
			myColumn.ColumnName = "Foo";
			myColumn.DataType = System.Type.GetType("System.Int32");

			// Set the auto increment behavior.
			myColumn.AutoIncrement = true;
			myColumn.AutoIncrementSeed = 500;
			myColumn.AutoIncrementStep = 12;
			
			// Add this column to a new DataTable.
			DataTable myTable = new DataTable("MyTable");
			myTable.Columns.Add(myColumn);
			
			// Add 20 rows.
			DataRow r;
			for(int i =0; i < 20; i++)
			{
				r = myTable.NewRow();
				myTable.Rows.Add(r);
			}

			// Now list the value in each row.
			string temp = "";
			DataRowCollection rows = myTable.Rows;
			for(int i = 0;i < myTable.Rows.Count; i++)
			{
				DataRow currRow = rows[i];
				temp += currRow["Foo"] + " ";
			}
			MessageBox.Show(temp, "These values brought ala auto-increment");
		}

		protected void btnColumn_Click (object sender, System.EventArgs e)
		{
			// Build the FirstName column.
			// DataColumn colFName = new DataColumn();

			// Set a bunch of values.
			// colFName.DataType = Type.GetType("System.String");
			DataColumn colFName = new DataColumn("FirstName", 
												 Type.GetType("System.String"));
			colFName.ReadOnly = true;
			colFName.Caption = "First Name";
			colFName.ColumnName = "FirstName";

			// Get a bunch of values.
			string temp = "Column type: " + colFName.DataType + "\n" +
						  "Read only? " + colFName.ReadOnly + "\n" +
						  "Caption: " + colFName.Caption + "\n" +
						  "Column Name: " + colFName.ColumnName + "\n" + 
						  "Nulls allowed? " + colFName.AllowDBNull;

			MessageBox.Show(temp, "Column properties");
		}

        public static void Main(string[] args) 
        {
            Application.Run(new DCForm());
        }
    }
}
