using Oracle.ManagedDataAccess.Client;
namespace GestiuneCarti
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void connect_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;
            string connectionString = $"User Id=PORCESCO_ADELINA;Password=PAROLA;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=FREEPDB1)));Connection Timeout=30;";

            using (OracleConnection conn = new OracleConnection(connectionString)){
                try
                {
                    await conn.OpenAsync();
                    Console.WriteLine("Conexiune reusita!");
                    Console.Read();
                    this.Hide();
                    MenuForm menu = new MenuForm(conn);
                    menu.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la connectare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
