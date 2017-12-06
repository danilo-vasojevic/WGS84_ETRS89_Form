using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WGS84_ETRS89
{
	public partial class Form1 : Form
	{
		bool paramsLoaded = false;
		bool dataLoaded = false;
		public TranslationObject TranslationObject { get; set; }

		public Form1()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;

		}

		private void browseDataFileButton_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "DATA files(*.dat)|*.dat";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
				dataFilePathTextBox.Text = openFileDialog.FileName;
		}
		private void browseParamsFileButton_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "PAR files(*.PAR)|*.PAR";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
				paramsFilePathTextBox.Text = openFileDialog.FileName;
		}
		private void loadDataButton_Click_1(object sender, EventArgs e)
		{
			var f = Convert.ToDouble(fValueTextBox.Text);
			var a = Convert.ToDouble(aValueTextBox.Text);
			BindingSource bs = new BindingSource();
			Enabled = false;
			var currTitle = this.Text;
			this.Text = this.Text + " - Working...";
			if (TranslationObject == null) TranslationObject = new TranslationObject(f, a, dataFilePathTextBox.Text, true, bs);
			else
			{
				TranslationObject.Data_a = a;
				TranslationObject.Data_f = f;
				TranslationObject.LoadDataFileAndCalculate(dataFilePathTextBox.Text, bs);
			}
			fileDataGrid.DataSource = bs;
			this.Text = currTitle;
			dataLoaded = true;
			exportToFileDirectoryTextBox.Enabled = true;
			browseExportFolder.Enabled = true;
			this.Enabled = true; // Whole form
		}
		private void loadParamsButton_Click_1(object sender, EventArgs e)
		{
			var f = Convert.ToDouble(fValueTextBox.Text);
			var a = Convert.ToDouble(aValueTextBox.Text);
			if (TranslationObject == null) TranslationObject = new TranslationObject(f, a, paramsFilePathTextBox.Text, false, null);
			else TranslationObject.LoadSevenParameters(paramsFilePathTextBox.Text);
			sevenParamsTextBox.Text = TranslationObject.SevenParameters.ToString();
			paramsLoaded = true;
			if (File.Exists(dataFilePathTextBox.Text)) loadDataButton.Enabled = true;
		}
		private void fValueTextBox_TextChanged(object sender, EventArgs e)
		{
			dataFilePathTextBox_TextChanged(sender, e);
			paramsFilePathTextBox_TextChanged(sender, e);
			if (fValueTextBox.Text != String.Empty && aValueTextBox.Text != String.Empty) EnableLoadButtons();
			else if (fValueTextBox.Text == String.Empty || aValueTextBox.Text == String.Empty)
			{
				DisableLoadAndExportButtons();
				DataAndParamsUnloaded();
			}
		}
		private void aValueTextBox_TextChanged(object sender, EventArgs e)
		{
			dataFilePathTextBox_TextChanged(sender, e);
			paramsFilePathTextBox_TextChanged(sender, e);
			if (fValueTextBox.Text != String.Empty && aValueTextBox.Text != String.Empty) EnableLoadButtons();
			else if (fValueTextBox.Text == String.Empty || aValueTextBox.Text == String.Empty)
			{
				DisableLoadAndExportButtons();
				DataAndParamsUnloaded();
			}
		}
		private void dataFilePathTextBox_TextChanged(object sender, EventArgs e)
		{
			if (File.Exists(dataFilePathTextBox.Text) && paramsLoaded) loadDataButton.Enabled = true;
			else loadDataButton.Enabled = false;
		}
		private void paramsFilePathTextBox_TextChanged(object sender, EventArgs e)
		{
			if (File.Exists(paramsFilePathTextBox.Text)) loadParamsButton.Enabled = true;
			else loadParamsButton.Enabled = false;
		}
		private void exportToFileDirectoryTextBox_TextChanged(object sender, EventArgs e)
		{
			if (Directory.Exists(exportToFileDirectoryTextBox.Text) && dataLoaded)
				exportToFileButton.Enabled = true;
			else exportToFileButton.Enabled = false;
		}
		private void browseExportFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				exportToFileDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;

		}
		private void EnableLoadButtons()
		{
			dataFilePathTextBox.Enabled = true;
			paramsFilePathTextBox.Enabled = true;
			browseDataFileButton.Enabled = true;
			browseParamsFileButton.Enabled = true;
		}
		private void DisableLoadAndExportButtons()
		{
			dataFilePathTextBox.Enabled = false;
			paramsFilePathTextBox.Enabled = false;
			browseDataFileButton.Enabled = false;
			browseParamsFileButton.Enabled = false;
			loadDataButton.Enabled = false;
			loadParamsButton.Enabled = false;
		}
		private void DataAndParamsUnloaded()
		{
			dataLoaded = false;
			paramsLoaded = false;
			exportToFileDirectoryTextBox_TextChanged(null, null);
		}
		private void exportToFileButton_Click(object sender, EventArgs e)
		{
			TranslationObject.ExportDataToFile(exportToFileDirectoryTextBox.Text);
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			aValueTextBox.Text = ConfigManager.Default_a;
			fValueTextBox.Text = ConfigManager.Default_f;
		}
	}
}
