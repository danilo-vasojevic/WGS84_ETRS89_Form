using FileHelpers;
using System.Windows.Forms;
using static WGS84_ETRS89.TranslationCalculator;

namespace WGS84_ETRS89
{
	public class TranslationObject
	{
		public double Data_f { get; set; }
		public double Data_a { get; set; }
		public double Data_e { get; set; }
		public double Data_abRatio { get; set; }

		public FileDataObject[] FileDataObjectList { get; set; }
		public SevenParameters SevenParameters { get; set; }
		
		public TranslationObject(double f, double a, string filePath, bool isDataPath, BindingSource bs)
		{
			Data_a = a;
			CalculateInitialValues(f);
			if (isDataPath) LoadDataFile(filePath, bs);
			else LoadSevenParameters(filePath);
		}
		
		public void CalculateInitialValues(double f)
		{
			Data_f = f;
			Data_e = Calc_e(f);
			Data_abRatio = Calc_ab_ratio(Data_e);
		}

		public void LoadDataFile(string dataFilePath, BindingSource bs)
		{
			FileDataObjectList = (new FileHelperEngine<FileDataObject>()).ReadFile(dataFilePath);
			CalculateInitialValues(Data_f);
			foreach (var item in FileDataObjectList)
			{
				item.Data_N_Calculated = Calc_N_aBe(Data_a, item.Data_B, Data_e);

				item.Data_X_Calculated = Calc_X_NhBL(item.Data_N_Calculated, item.Data_h, item.Data_B, item.Data_L);
				item.Data_Y_Calculated = Calc_Y_NhBL(item.Data_N_Calculated, item.Data_h, item.Data_B, item.Data_L);
				item.Data_Z_Calculated = Calc_Z_NabhB(item.Data_N_Calculated, Data_abRatio, item.Data_h, item.Data_B);

				item.Data_g_Calculated = Calc_g_g(item.Data_g);
				
				Calc_X2_Y2_Z2(item, SevenParameters);

				bs.Add(item);
			}
		}

		public void LoadSevenParameters(string paramsFilePath)
		{
			SevenParameters = new SevenParameters(paramsFilePath);
		}

		
	}
}
