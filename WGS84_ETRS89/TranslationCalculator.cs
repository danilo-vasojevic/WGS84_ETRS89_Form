using static System.Math;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace WGS84_ETRS89
{
	public static class TranslationCalculator
	{
		// Calculates e value, based on f
		public static double Calc_e(double f) => Sqrt(2 * f - Square(f));

		// Calculates (a*a)/(b*b) ratio based on e value
		public static double Calc_ab_ratio(double e) => (1 - Square(e));

		// Calculates N value based on a, B, e values
		public static double Calc_N_aBe(double a, double B_deg, double e) => a / (Sqrt(1 - (Square(e) * Square(Sin(Radians(B_deg))))));

		// Calculate X value based on N, h, B and l values
		public static double Calc_X_NhBL(double N, double h, double B_deg, double l_deg) => ((N + h) * Cos(Radians(B_deg)) * Cos(Radians(l_deg)));

		// Calculate Y value based on N, h, B and l values
		public static double Calc_Y_NhBL(double N, double h, double B_deg, double l_deg) => ((N + h) * Cos(Radians(B_deg)) * Sin(Radians(l_deg)));

		// Calculate Z value based on N, a2b2 ratio, h, and B values
		public static double Calc_Z_NabhB(double N, double r, double h, double B_deg) => ((N * r + h) * Sin(Radians(B_deg)));

		// Calcualte g based on g value
		public static double Calc_g_g(double g) => 980592.54 + 1.001427 * (g - 980607.66);

		// Calculate X2, Y2 and Z2 values
		public static void Calc_X2_Y2_Z2(FileDataObject fdo, SevenParameters sp)
		{
			Matrix<double> XYZ1 = DenseMatrix.OfArray(new double[,] {
				{ fdo.Data_X_Calculated },
				{ fdo.Data_Y_Calculated },
				{ fdo.Data_Z_Calculated }
			});
			Matrix<double> RxMi = get_RxMi(sp.Epsilon_X, sp.Epsilon_Y, sp.Epsilon_Z, sp.Mi);
			Matrix<double> Tm = DenseMatrix.OfArray(new double[,] {
				{ sp.T_X },
				{ sp.T_Y },
				{ sp.T_Z }
			});

			Matrix<double> SolutionMatrix = RxMi.Multiply(XYZ1).Add(Tm);

			fdo.Data_X2_Calculated = SolutionMatrix[0, 0];
			fdo.Data_Y2_Calculated = SolutionMatrix[1, 0];
			fdo.Data_Z2_Calculated = SolutionMatrix[2, 0];
		}

		#region Helpers
		private static double Square(double a) => Pow(a, 2);
		private static double Radians(double angleInDegrees) => PI * angleInDegrees / 180.0;
		private static Matrix<double> R1(double value)
		{
			var C = Cos(value);
			var S = Sin(value);
			var s = (-1) * S;
			return DenseMatrix.OfArray(new double[,]
			{
				{ 1, 0, 0},
				{ 0, C, S},
				{ 0, s, C}
			});
		}
		private static Matrix<double> R2(double value)
		{
			var C = Cos(value);
			var S = Sin(value);
			var s = (-1) * S;
			return DenseMatrix.OfArray(new double[,]
			{
				{ C, 0, s},
				{ 0, 1, 0},
				{ S, 0, C}
			});
		}
		private static Matrix<double> R3(double value)
		{
			var C = Cos(value);
			var S = Sin(value);
			var s = (-1) * S;
			return DenseMatrix.OfArray(new double[,]
			{
				{ C, S, 0},
				{ s, C, 0},
				{ 0, 0, 1}
			});
		}
		private static Matrix<double> get_RxMi(double Ex, double Ey, double Ez, double Mi) => 
			R1(Ex)
				.Multiply(R2(Ey))
				.Multiply(R3(Ez))
				.Multiply(1+Mi);
		#endregion
	}
}