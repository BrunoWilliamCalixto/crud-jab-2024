using Project_jab_2024.Forms;

namespace Project_jab_2024
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void btnCadastrarCliente_click(object sender, EventArgs e)
		{
			FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
			cadastroCliente.ShowDialog();
		}

		private void btnConsultarCliente_click(object sender, EventArgs e)
		{
			FrmConsultaCliente consultaCliente = new FrmConsultaCliente();
			consultaCliente.ShowDialog();
		}

	}
}
