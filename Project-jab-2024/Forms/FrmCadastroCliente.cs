using Project_jab_2024.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_jab_2024.Forms
{
	public partial class FrmCadastroCliente : Form
	{
		public FrmCadastroCliente()
		{
			InitializeComponent();
		}

		private void btnCadastrarUsuario_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			cliente.Nome = txtBoxNome.Text; 
			cliente.CPF = txtBoxCPF.Text;
			cliente.Telefone = txtBoxTelefone.Text;
			cliente.Email = txtBoxEmail.Text;
			if (radioMasc.Checked)
			{
				cliente.Sexo = radioMasc.Text;
			}
			else
			{
				cliente.Sexo = radioFem.Text;
			}
			cliente.Endereco = txtBoxEndereco.Text;
			cliente.DataNascimento = txtBoxNasc.Text;

			ClienteDAO clienteDAO = new ClienteDAO();
			clienteDAO.InserirCliente(cliente);

			MessageBox.Show("Cliente cadastrado com sucesso!");

			LimparCampos();

			this.Close();
		}

		private void LimparCampos()
		{
			txtBoxNome.Text = "";
			txtBoxCPF.Text = "";
			txtBoxTelefone.Text = "";
			txtBoxEmail.Text = "";
			if (radioMasc.Checked)
			{
				radioMasc.Checked = false;
			}
			else
			{
				radioFem.Checked = false;
			}
			txtBoxEndereco.Text = "";
			txtBoxNasc.Text = "";
		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}
	}
}
