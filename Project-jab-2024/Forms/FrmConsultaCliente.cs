using Project_jab_2024.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_jab_2024.Forms
{
	public partial class FrmConsultaCliente : Form
	{
		private string getCPF = null;
		private int idCliente = 0;

		public FrmConsultaCliente()
		{
			InitializeComponent();
			btnEditarCliente.Visible = false;
			btnExcluirCliente.Visible = false;
		}

		private void buttonPesquisar_Click(object sender, EventArgs e)
		{
			listBoxMostrarResultado.Items.Clear();
			getCPF = txtBoxConsultaCPF.Text;
			BuscarClientePorCPF(getCPF);
		}

		public void BuscarClientePorCPF(string cpf)
		{
			try
			{
				ClienteDAO clienteDAO = new ClienteDAO();
				Cliente cliente = clienteDAO.SelecionarClienteCPF(cpf);
				idCliente = cliente.Id;
				listBoxMostrarResultado.Items.Clear();

				if (cliente != null)
				{
					listBoxMostrarResultado.Visible = true;
					listBoxMostrarResultado.Items.Add("====================================");
					listBoxMostrarResultado.Items.Add("Nome Cliente: " + cliente.Nome);
					listBoxMostrarResultado.Items.Add("Endereço: " + cliente.Endereco);
					listBoxMostrarResultado.Items.Add("Gênero: " + cliente.Sexo);
					listBoxMostrarResultado.Items.Add("Telefone de contato: " + cliente.Telefone);
					listBoxMostrarResultado.Items.Add("E-mail: " + cliente.Email);
					listBoxMostrarResultado.Items.Add("Data de nascimento: " + cliente.DataNascimento);
					listBoxMostrarResultado.Items.Add("====================================");

					btnExcluirCliente.Enabled = true;
					btnEditarCliente.Enabled = true;
					btnEditarCliente.Visible = true;
					btnExcluirCliente.Visible = true;
				}
			}
			catch (Exception ex)
			{
				btnEditarCliente.Enabled = false;
				btnExcluirCliente.Enabled = false;
				listBoxMostrarResultado.Visible = false;
				MessageBox.Show("CPF do cliente inválido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonExcluir_Click(object sender, EventArgs e)
		{
			if (idCliente > 0)
			{
				DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.Yes)
				{
					try
					{
						ClienteDAO clienteDAO = new ClienteDAO();
						bool isDeleted = clienteDAO.ExcluirClientes(idCliente);

						if (isDeleted)
						{
							MessageBox.Show("Usuário excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							listBoxMostrarResultado.Items.Clear();
							listBoxMostrarResultado.Visible = false;
							idCliente = 0;
							btnEditarCliente.Visible=false;
							btnExcluirCliente.Visible = false;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Ocorreu um erro ao excluir o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				btnEditarCliente.Enabled = false;
				btnExcluirCliente.Enabled = false;
			}
		}

		private void buttonEditar_Click(object sender, EventArgs e)
		{
			if (idCliente > 0)
			{
				// Cria o formulário de atualização
				FrmAtualizacaoCliente updateForm = new FrmAtualizacaoCliente(idCliente, getCPF);

				// Abre o formulário como diálogo modal
				if (updateForm.ShowDialog() == DialogResult.OK)
				{
					// Atualiza a lista após a atualização
					BuscarClientePorCPF(getCPF);
				}
			}
			else
			{
				btnEditarCliente.Enabled = false;
				btnExcluirCliente.Enabled = false;
			}
		}
	}
}
