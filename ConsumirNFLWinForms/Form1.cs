using ConsumirNFLWinForms.Service;
using System.Threading.Tasks;

namespace ConsumirNFLWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            var api = new ApiService();
            var succes = await api.LoginAsync("admin", "123");

            if (succes)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                var teams = await api.GetTeamsAsync();
                dataGridView1.DataSource = teams;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
