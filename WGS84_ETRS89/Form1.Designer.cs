namespace WGS84_ETRS89
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataFilePathTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.paramsFilePathTextBox = new System.Windows.Forms.TextBox();
			this.browseDataFileButton = new System.Windows.Forms.Button();
			this.browseParamsFileButton = new System.Windows.Forms.Button();
			this.loadParamsButton = new System.Windows.Forms.Button();
			this.loadDataButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.sevenParamsTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.fValueTextBox = new System.Windows.Forms.TextBox();
			this.fileDataGrid = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.aValueTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._BvalueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LvalueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NvalueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gValueCalculatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XvalueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YvalueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZvalueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.X2ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Y2ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Z2ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data File:";
			// 
			// dataFilePathTextBox
			// 
			this.dataFilePathTextBox.Enabled = false;
			this.dataFilePathTextBox.Location = new System.Drawing.Point(82, 104);
			this.dataFilePathTextBox.Name = "dataFilePathTextBox";
			this.dataFilePathTextBox.Size = new System.Drawing.Size(198, 20);
			this.dataFilePathTextBox.TabIndex = 3;
			this.dataFilePathTextBox.TextChanged += new System.EventHandler(this.dataFilePathTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Params. File:";
			// 
			// paramsFilePathTextBox
			// 
			this.paramsFilePathTextBox.Enabled = false;
			this.paramsFilePathTextBox.Location = new System.Drawing.Point(82, 33);
			this.paramsFilePathTextBox.Name = "paramsFilePathTextBox";
			this.paramsFilePathTextBox.Size = new System.Drawing.Size(198, 20);
			this.paramsFilePathTextBox.TabIndex = 4;
			this.paramsFilePathTextBox.TextChanged += new System.EventHandler(this.paramsFilePathTextBox_TextChanged);
			// 
			// browseDataFileButton
			// 
			this.browseDataFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.browseDataFileButton.Enabled = false;
			this.browseDataFileButton.Location = new System.Drawing.Point(284, 104);
			this.browseDataFileButton.Name = "browseDataFileButton";
			this.browseDataFileButton.Size = new System.Drawing.Size(63, 21);
			this.browseDataFileButton.TabIndex = 2;
			this.browseDataFileButton.Text = "Browse";
			this.browseDataFileButton.UseVisualStyleBackColor = true;
			this.browseDataFileButton.Click += new System.EventHandler(this.browseDataFileButton_Click);
			// 
			// browseParamsFileButton
			// 
			this.browseParamsFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.browseParamsFileButton.Enabled = false;
			this.browseParamsFileButton.Location = new System.Drawing.Point(284, 34);
			this.browseParamsFileButton.Name = "browseParamsFileButton";
			this.browseParamsFileButton.Size = new System.Drawing.Size(63, 20);
			this.browseParamsFileButton.TabIndex = 5;
			this.browseParamsFileButton.Text = "Browse";
			this.browseParamsFileButton.UseVisualStyleBackColor = true;
			this.browseParamsFileButton.Click += new System.EventHandler(this.browseParamsFileButton_Click);
			// 
			// loadParamsButton
			// 
			this.loadParamsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loadParamsButton.Enabled = false;
			this.loadParamsButton.Location = new System.Drawing.Point(348, 34);
			this.loadParamsButton.Name = "loadParamsButton";
			this.loadParamsButton.Size = new System.Drawing.Size(94, 20);
			this.loadParamsButton.TabIndex = 6;
			this.loadParamsButton.Text = "Load Params";
			this.loadParamsButton.UseVisualStyleBackColor = true;
			this.loadParamsButton.Click += new System.EventHandler(this.loadParamsButton_Click_1);
			// 
			// loadDataButton
			// 
			this.loadDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loadDataButton.Enabled = false;
			this.loadDataButton.Location = new System.Drawing.Point(348, 104);
			this.loadDataButton.Name = "loadDataButton";
			this.loadDataButton.Size = new System.Drawing.Size(94, 21);
			this.loadDataButton.TabIndex = 3;
			this.loadDataButton.Text = "Load/Calc Data";
			this.loadDataButton.UseVisualStyleBackColor = true;
			this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click_1);
			// 
			// sevenParamsTextBox
			// 
			this.sevenParamsTextBox.Location = new System.Drawing.Point(15, 72);
			this.sevenParamsTextBox.Name = "sevenParamsTextBox";
			this.sevenParamsTextBox.ReadOnly = true;
			this.sevenParamsTextBox.Size = new System.Drawing.Size(427, 20);
			this.sevenParamsTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "\"f\" value:";
			// 
			// fValueTextBox
			// 
			this.fValueTextBox.Location = new System.Drawing.Point(82, 6);
			this.fValueTextBox.Name = "fValueTextBox";
			this.fValueTextBox.Size = new System.Drawing.Size(61, 20);
			this.fValueTextBox.TabIndex = 1;
			this.fValueTextBox.TextChanged += new System.EventHandler(this.fValueTextBox_TextChanged);
			// 
			// fileDataGrid
			// 
			this.fileDataGrid.AllowUserToAddRows = false;
			this.fileDataGrid.AllowUserToDeleteRows = false;
			this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fileDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberColumn,
            this._BvalueColumn,
            this.LvalueColumn,
            this.hValueColumn,
            this.gValueColumn,
            this.NvalueColumn,
            this.gValueCalculatedColumn,
            this.XvalueColumn,
            this.YvalueColumn,
            this.ZvalueColumn,
            this.X2ValueColumn,
            this.Y2ValueColumn,
            this.Z2ValueColumn});
			this.fileDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
			this.fileDataGrid.Location = new System.Drawing.Point(15, 143);
			this.fileDataGrid.Name = "fileDataGrid";
			this.fileDataGrid.ReadOnly = true;
			this.fileDataGrid.Size = new System.Drawing.Size(427, 235);
			this.fileDataGrid.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Loaded and calculated data:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Loaded parameters:";
			// 
			// aValueTextBox
			// 
			this.aValueTextBox.Location = new System.Drawing.Point(219, 6);
			this.aValueTextBox.Name = "aValueTextBox";
			this.aValueTextBox.Size = new System.Drawing.Size(61, 20);
			this.aValueTextBox.TabIndex = 2;
			this.aValueTextBox.TextChanged += new System.EventHandler(this.aValueTextBox_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(149, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "\"a\" value:";
			// 
			// numberColumn
			// 
			this.numberColumn.DataPropertyName = "Data_Order_Num";
			this.numberColumn.HeaderText = "No.";
			this.numberColumn.MinimumWidth = 30;
			this.numberColumn.Name = "numberColumn";
			this.numberColumn.ReadOnly = true;
			this.numberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.numberColumn.Width = 40;
			// 
			// _BvalueColumn
			// 
			this._BvalueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this._BvalueColumn.DataPropertyName = "Data_B";
			this._BvalueColumn.HeaderText = "B";
			this._BvalueColumn.Name = "_BvalueColumn";
			this._BvalueColumn.ReadOnly = true;
			this._BvalueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this._BvalueColumn.Width = 85;
			// 
			// LvalueColumn
			// 
			this.LvalueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.LvalueColumn.DataPropertyName = "Data_L";
			this.LvalueColumn.HeaderText = "L";
			this.LvalueColumn.Name = "LvalueColumn";
			this.LvalueColumn.ReadOnly = true;
			this.LvalueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LvalueColumn.Width = 85;
			// 
			// hValueColumn
			// 
			this.hValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.hValueColumn.DataPropertyName = "Data_h";
			this.hValueColumn.HeaderText = "h";
			this.hValueColumn.Name = "hValueColumn";
			this.hValueColumn.ReadOnly = true;
			this.hValueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.hValueColumn.Width = 65;
			// 
			// gValueColumn
			// 
			this.gValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.gValueColumn.DataPropertyName = "Data_g";
			this.gValueColumn.HeaderText = "g";
			this.gValueColumn.Name = "gValueColumn";
			this.gValueColumn.ReadOnly = true;
			this.gValueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.gValueColumn.Width = 75;
			// 
			// NvalueColumn
			// 
			this.NvalueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.NvalueColumn.DataPropertyName = "Data_N_Calculated";
			this.NvalueColumn.HeaderText = "N (calculated)";
			this.NvalueColumn.Name = "NvalueColumn";
			this.NvalueColumn.ReadOnly = true;
			this.NvalueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.NvalueColumn.Width = 120;
			// 
			// gValueCalculatedColumn
			// 
			this.gValueCalculatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.gValueCalculatedColumn.DataPropertyName = "Data_g_Calculated";
			this.gValueCalculatedColumn.HeaderText = "g (Calculated)";
			this.gValueCalculatedColumn.Name = "gValueCalculatedColumn";
			this.gValueCalculatedColumn.ReadOnly = true;
			// 
			// XvalueColumn
			// 
			this.XvalueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.XvalueColumn.DataPropertyName = "Data_X_Calculated";
			this.XvalueColumn.HeaderText = "X (calculated)";
			this.XvalueColumn.Name = "XvalueColumn";
			this.XvalueColumn.ReadOnly = true;
			this.XvalueColumn.Width = 120;
			// 
			// YvalueColumn
			// 
			this.YvalueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.YvalueColumn.DataPropertyName = "Data_Y_Calculated";
			this.YvalueColumn.HeaderText = "Y (calcuated)";
			this.YvalueColumn.Name = "YvalueColumn";
			this.YvalueColumn.ReadOnly = true;
			this.YvalueColumn.Width = 120;
			// 
			// ZvalueColumn
			// 
			this.ZvalueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ZvalueColumn.DataPropertyName = "Data_Z_Calculated";
			this.ZvalueColumn.HeaderText = "Z (calculated)";
			this.ZvalueColumn.Name = "ZvalueColumn";
			this.ZvalueColumn.ReadOnly = true;
			this.ZvalueColumn.Width = 120;
			// 
			// X2ValueColumn
			// 
			this.X2ValueColumn.DataPropertyName = "Data_X2_Calculated";
			this.X2ValueColumn.HeaderText = "X2 (Calculated)";
			this.X2ValueColumn.Name = "X2ValueColumn";
			this.X2ValueColumn.ReadOnly = true;
			this.X2ValueColumn.Width = 120;
			// 
			// Y2ValueColumn
			// 
			this.Y2ValueColumn.DataPropertyName = "Data_Y2_Calculated";
			this.Y2ValueColumn.HeaderText = "Y2 (Calculated)";
			this.Y2ValueColumn.Name = "Y2ValueColumn";
			this.Y2ValueColumn.ReadOnly = true;
			this.Y2ValueColumn.Width = 120;
			// 
			// Z2ValueColumn
			// 
			this.Z2ValueColumn.DataPropertyName = "Data_Z2_Calculated";
			this.Z2ValueColumn.HeaderText = "Z2 (Calculated)";
			this.Z2ValueColumn.Name = "Z2ValueColumn";
			this.Z2ValueColumn.ReadOnly = true;
			this.Z2ValueColumn.Width = 120;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 405);
			this.Controls.Add(this.aValueTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.fileDataGrid);
			this.Controls.Add(this.fValueTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sevenParamsTextBox);
			this.Controls.Add(this.loadParamsButton);
			this.Controls.Add(this.loadDataButton);
			this.Controls.Add(this.browseParamsFileButton);
			this.Controls.Add(this.browseDataFileButton);
			this.Controls.Add(this.paramsFilePathTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataFilePathTextBox);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "WG84_ETRS89";
			((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox dataFilePathTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button browseDataFileButton;
		private System.Windows.Forms.Button browseParamsFileButton;
		private System.Windows.Forms.Button loadParamsButton;
		private System.Windows.Forms.Button loadDataButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox sevenParamsTextBox;
		private System.Windows.Forms.TextBox paramsFilePathTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fValueTextBox;
		private System.Windows.Forms.DataGridView fileDataGrid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox aValueTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _BvalueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LvalueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NvalueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gValueCalculatedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn XvalueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YvalueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZvalueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn X2ValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Y2ValueColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Z2ValueColumn;
	}
}

