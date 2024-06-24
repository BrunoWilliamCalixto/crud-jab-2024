using Project_jab_2024.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_jab_2024.Forms
{
	public partial class FrmAtualizacaoCliente : Form
	{
		private int idCliente;
		private string cpfCliente;

		public FrmAtualizacaoCliente(int idCliente, string cpfCliente)
		{
			InitializeComponent();
			this.idCliente = idCliente;
			this.cpfCliente = cpfCliente;

			InicializarControleFormulario();
			PreencherDadosCliente();
		}

		private void InicializarControleFormulario()
		{
			// Definir as propriedades do formulário
			this.Text = "Atualizar Cliente";
			this.StartPosition = FormStartPosition.CenterParent;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size(500, 300);

			Label lblNome = new Label { Text = "Nome", Location = new System.Drawing.Point(10, 10) };
			TextBox txtNome = new TextBox { Location = new System.Drawing.Point(110, 10), Width = 350, Name = "txtNome" };

			Label lblEndereco = new Label { Text = "Endereço", Location = new System.Drawing.Point(10, 40) };
			TextBox txtEndereco = new TextBox { Location = new System.Drawing.Point(110, 40), Width = 350, Name = "txtEndereco" };

			Label lblSexo = new Label { Text = "Gênero", Location = new System.Drawing.Point(10, 70) };
			TextBox txtSexo = new TextBox { Location = new System.Drawing.Point(110, 70), Width = 350, Name = "txtSexo" };

			Label lblTelefone = new Label { Text = "Telefone", Location = new System.Drawing.Point(10, 100) };
			TextBox txtTelefone = new TextBox { Location = new System.Drawing.Point(110, 100), Width = 350, Name = "txtTelefone" };

			Label lblEmail = new Label { Text = "Email", Location = new System.Drawing.Point(10, 130) };
			TextBox txtEmail = new TextBox { Location = new System.Drawing.Point(110, 130), Width = 350, Name = "txtEmail" };

			Label lblDataNascimento = new Label { Text = "Data Nasc.", Location = new System.Drawing.Point(10, 160) };
			TextBox txtDataNascimento = new TextBox { Location = new System.Drawing.Point(110, 160), Width = 350, Name = "txtDataNascimento" }; // Ajuste o tamanho conforme necessário

			Label lblCPF = new Label { Text = "CPF", Location = new System.Drawing.Point(10, 190), Visible= false };
			TextBox txtCPF = new TextBox { Location = new System.Drawing.Point(100, 190), Width = 350, Name = "txtCPF", ReadOnly = true, Visible= false };

			Button btnSalvar = new Button { Text = "Salvar", Location = new System.Drawing.Point(110, 220), AutoSize=true };
			btnSalvar.Click += BtnSalvar_Click;

			this.Controls.Add(lblNome);
			this.Controls.Add(txtNome);
			this.Controls.Add(lblEndereco);
			this.Controls.Add(txtEndereco);
			this.Controls.Add(lblSexo);
			this.Controls.Add(txtSexo);
			this.Controls.Add(lblTelefone);
			this.Controls.Add(txtTelefone);
			this.Controls.Add(lblEmail);
			this.Controls.Add(txtEmail);
			this.Controls.Add(lblDataNascimento);
			this.Controls.Add(txtDataNascimento);
			this.Controls.Add(lblCPF);
			this.Controls.Add(txtCPF);
			this.Controls.Add(btnSalvar);
		}

		private void PreencherDadosCliente()
		{
			// Preencher os controles com os dados do cliente
			ClienteDAO clienteDAO = new ClienteDAO();
			Cliente cliente = clienteDAO.SelecionarClienteCPF(cpfCliente);
			

			if (cliente != null)
			{
				this.Controls["txtNome"].Text = cliente.Nome;
				this.Controls["txtCPF"].Text = cliente.CPF;
				this.Controls["txtEndereco"].Text = cliente.Endereco;
				this.Controls["txtSexo"].Text = cliente.Sexo;
				this.Controls["txtTelefone"].Text = cliente.Telefone;
				this.Controls["txtEmail"].Text = cliente.Email;
				this.Controls["txtDataNascimento"].Text = cliente.DataNascimento;
			}
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			// Atualiza o cliente com os novos dados
			Cliente cliente = new Cliente
			{
				Id = idCliente,
				Nome = ((TextBox)this.Controls["txtNome"]).Text,
				CPF = ((TextBox)this.Controls["txtCPF"]).Text,
				Endereco = ((TextBox)this.Controls["txtEndereco"]).Text,
				Sexo = ((TextBox)this.Controls["txtSexo"]).Text,
				Telefone = ((TextBox)this.Controls["txtTelefone"]).Text,
				Email = ((TextBox)this.Controls["txtEmail"]).Text,
				DataNascimento = ((TextBox)this.Controls["txtDataNascimento"]).Text,
				
			};

			ClienteDAO clienteDAO = new ClienteDAO();
			clienteDAO.AtualizarCliente(cliente);

			MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}