namespace Project_jab_2024.Forms
{
	partial class FrmConsultaCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblBoasVindasConsulta = new Label();
			lblDigiteCPF = new Label();
			listBoxMostrarResultado = new ListBox();
			btnPesquisar = new Button();
			btnEditarCliente = new Button();
			btnExcluirCliente = new Button();
			txtBoxConsultaCPF = new MaskedTextBox();
			SuspendLayout();
			// 
			// lblBoasVindasConsulta
			// 
			lblBoasVindasConsulta.AutoSize = true;
			lblBoasVindasConsulta.Location = new Point(412, 46);
			lblBoasVindasConsulta.Margin = new Padding(4, 0, 4, 0);
			lblBoasVindasConsulta.Name = "lblBoasVindasConsulta";
			lblBoasVindasConsulta.Size = new Size(172, 25);
			lblBoasVindasConsulta.TabIndex = 1;
			lblBoasVindasConsulta.Text = "Consulta de Clientes";
			// 
			// lblDigiteCPF
			// 
			lblDigiteCPF.AutoSize = true;
			lblDigiteCPF.Location = new Point(224, 134);
			lblDigiteCPF.Margin = new Padding(4, 0, 4, 0);
			lblDigiteCPF.Name = "lblDigiteCPF";
			lblDigiteCPF.Size = new Size(192, 25);
			lblDigiteCPF.TabIndex = 2;
			lblDigiteCPF.Text = "Digite o CPF do cliente";
			// 
			// listBoxMostrarResultado
			// 
			listBoxMostrarResultado.BackColor = SystemColors.Menu;
			listBoxMostrarResultado.FormattingEnabled = true;
			listBoxMostrarResultado.ItemHeight = 25;
			listBoxMostrarResultado.Location = new Point(224, 201);
			listBoxMostrarResultado.Margin = new Padding(4);
			listBoxMostrarResultado.Name = "listBoxMostrarResultado";
			listBoxMostrarResultado.Size = new Size(474, 204);
			listBoxMostrarResultado.TabIndex = 4;
			listBoxMostrarResultado.Visible = false;
			// 
			// btnPesquisar
			// 
			btnPesquisar.AutoSize = true;
			btnPesquisar.Location = new Point(591, 160);
			btnPesquisar.Margin = new Padding(4);
			btnPesquisar.Name = "btnPesquisar";
			btnPesquisar.Size = new Size(107, 35);
			btnPesquisar.TabIndex = 7;
			btnPesquisar.Text = "Pesquisar";
			btnPesquisar.UseVisualStyleBackColor = true;
			btnPesquisar.Click += buttonPesquisar_Click;
			// 
			// btnEditarCliente
			// 
			btnEditarCliente.AutoSize = true;
			btnEditarCliente.Location = new Point(706, 215);
			btnEditarCliente.Margin = new Padding(4);
			btnEditarCliente.Name = "btnEditarCliente";
			btnEditarCliente.Size = new Size(140, 38);
			btnEditarCliente.TabIndex = 8;
			btnEditarCliente.Text = "Editar Cliente";
			btnEditarCliente.UseVisualStyleBackColor = true;
			btnEditarCliente.Click += buttonEditar_Click;
			// 
			// btnExcluirCliente
			// 
			btnExcluirCliente.AutoSize = true;
			btnExcluirCliente.Location = new Point(706, 259);
			btnExcluirCliente.Margin = new Padding(4);
			btnExcluirCliente.Name = "btnExcluirCliente";
			btnExcluirCliente.Size = new Size(140, 38);
			btnExcluirCliente.TabIndex = 9;
			btnExcluirCliente.Text = "Excluir Cliente";
			btnExcluirCliente.UseVisualStyleBackColor = true;
			btnExcluirCliente.Click += buttonExcluir_Click;
			// 
			// txtBoxConsultaCPF
			// 
			txtBoxConsultaCPF.Location = new Point(224, 162);
			txtBoxConsultaCPF.Mask = "000\\.000\\.000-00";
			txtBoxConsultaCPF.Name = "txtBoxConsultaCPF";
			txtBoxConsultaCPF.Size = new Size(360, 31);
			txtBoxConsultaCPF.TabIndex = 10;
			// 
			// ConsultaCliente
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 562);
			Controls.Add(txtBoxConsultaCPF);
			Controls.Add(btnExcluirCliente);
			Controls.Add(btnEditarCliente);
			Controls.Add(btnPesquisar);
			Controls.Add(listBoxMostrarResultado);
			Controls.Add(lblDigiteCPF);
			Controls.Add(lblBoasVindasConsulta);
			Margin = new Padding(4);
			MaximizeBox = false;
			Name = "ConsultaCliente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ConsultaCliente";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblBoasVindasConsulta;
		private Label lblDigiteCPF;
		private ListBox listBoxMostrarResultado;
		private Button btnPesquisar;
		private Button btnEditarCliente;
		private Button btnExcluirCliente;
		private MaskedTextBox txtBoxConsultaCPF;
	}
}