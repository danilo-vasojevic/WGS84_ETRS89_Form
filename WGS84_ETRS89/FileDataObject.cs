using FileHelpers;

namespace WGS84_ETRS89
{
	[DelimitedRecord(" ")]
	public class FileDataObject
	{
		public int Data_Order_Num { get; set; }
		public double Data_B{ get; set; }
		public double Data_L { get; set; }
		public double Data_h { get; set; }
		public double Data_g { get; set; }

		[FieldHidden] public double Data_N_Calculated { get; set; }

		[FieldHidden] public double Data_X_Calculated { get; set; }
		[FieldHidden] public double Data_Y_Calculated { get; set; }
		[FieldHidden] public double Data_Z_Calculated { get; set; }
		[FieldHidden] public double Data_g_Calculated { get; set; }

		[FieldHidden] public double Data_X2_Calculated { get; set; }
		[FieldHidden] public double Data_Y2_Calculated { get; set; }
		[FieldHidden] public double Data_Z2_Calculated { get; set; }

	}
}