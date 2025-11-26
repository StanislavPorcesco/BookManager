using System.Data;
using System.Data.SQLite;
using GestiuneCarti.Forms;

namespace GestiuneCarti
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            try
            {
                string resourcesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
                if (!Directory.Exists(resourcesFolder))
                {
                    Directory.CreateDirectory(resourcesFolder);
                }
                //string connectionString = "Data Source=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Resources\carti.db"));
                string connectionString = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\carti.db");
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                if (connection.State != ConnectionState.Open) connection.Open();
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                Data.createTabelCarti(connection);
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.Run(new MenuForm(connection));

            } catch(Exception ex)
            {
                File.WriteAllText("error.log", ex.ToString());
                throw;
            }
        }
    }
}