using System;
using System.Windows.Forms;

namespace WGS84_ETRS89
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// TODO: Uncomment and catch for prod mode
			//try
			//{
			//	Application.EnableVisualStyles();
			//	Application.SetCompatibleTextRenderingDefault(false);
			//	Application.Run(new Form1());
			//}
			//catch (Exception e)
			//{
			//	MessageBox.Show(e.Message, "Error!");
			//}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
