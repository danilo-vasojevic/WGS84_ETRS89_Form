using System.Configuration;

namespace WGS84_ETRS89
{
	public static class ConfigManager
	{
		public static string ExportFileName => ConfigurationManager.AppSettings["ExportFileName"];
		public static string Default_a => ConfigurationManager.AppSettings["aDefaultValue"];
		public static string Default_f => ConfigurationManager.AppSettings["fDefaultValue"];

	}
}
