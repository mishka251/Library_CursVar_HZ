using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_CursVar_HZ
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = tbLogin.Text;

            string Password = tbPassword.Text;
            // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "Library";
            builder.IntegratedSecurity = true;
            string connectionString = builder.ConnectionString;

            string checkcmd = $"Select IsSuperUser from [dbo].[User] where Login = '{User}' and Password = '{Password}'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand check = new SqlCommand(checkcmd, connection);

            connection.Open();

            check.Prepare();

            check.ExecuteNonQuery();

            if (check.ExecuteScalar() == null)
            {
                MessageBox.Show("Учетная запись не найдена! Проверьте правильность введенных данных");
            }
            else
            {
                if ((bool) check.ExecuteScalar())
                {
                    MessageBox.Show("Вы вошли под учетной записью администратора");
                    MenuForm mf = new MenuForm(true);
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Вы вошли под учетной записью гость. Вам разрешен режим просмотра.");
                    MenuForm mf = new MenuForm(false);
                    mf.Show();
                }
            }
        }
    }
}