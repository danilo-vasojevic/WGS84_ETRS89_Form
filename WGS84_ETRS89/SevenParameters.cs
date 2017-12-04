using System;
using System.IO;

namespace WGS84_ETRS89
{
	public class SevenParameters
	{
		public double Epsilon_X { get; set; }
		public double Epsilon_Y { get; set; }
		public double Epsilon_Z { get; set; }

		public double T_X { get; set; }
		public double T_Y { get; set; }
		public double T_Z { get; set; }

		public double Mi { get; set; }

		public SevenParameters(string filePath)
		{
			if (!File.Exists(filePath)) throw new DirectoryNotFoundException();
			string[] lines = File.ReadAllLines(filePath);
			
			Epsilon_X = Convert.ToDouble(lines[0]);
			Epsilon_Y = Convert.ToDouble(lines[1]);
			Epsilon_Z = Convert.ToDouble(lines[2]);

			T_X = Convert.ToDouble(lines[3]);
			T_Y = Convert.ToDouble(lines[4]);
			T_Z = Convert.ToDouble(lines[5]);

			Mi = Convert.ToDouble(lines[6]);
		}

		public override string ToString()
		{
			return $"Ex = {Epsilon_X.ToString()}, "
			+ $"Ey = {Epsilon_Y.ToString()}, "
			+ $"Ez = {Epsilon_Z.ToString()}, "

			+ $"Tx = {T_X.ToString()}, "
			+ $"Ty = {T_Y.ToString()}, "
			+ $"Tz = {T_Z.ToString()}, "

			+ $"Mi = {Mi.ToString()}";
		}
	}
}