namespace PracticalN5
{
	internal static class Program
	{
		public const string TEXT_FILE_FILTER = "Text files (*.txt)|*.txt";

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
	}
}