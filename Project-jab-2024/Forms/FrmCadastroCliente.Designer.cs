namespace Project_jab_2024.Forms
{
	partial class FrmCadastroCliente
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
			lblBoasVindas = new Label();
			lblNome = new Label();
			lblCPF = new Label();
			lblEmail = new Label();
			lblTelefone = new Label();
			lblEndereco = new Label();
			lblSexo = new Label();
			lblNasc = new Label();
			txtBoxEndereco = new TextBox();
			txtBoxEmail = new TextBox();
			txtBoxNome = new TextBox();
			btnLimparCampos = new Button();
			btnCadastrarUsuario = new Button();
			radioMasc = new RadioButton();
			radioFem = new RadioButton();
			txtBoxNasc = new MaskedTextBox();
			txtBoxCPF = new MaskedTextBox();
			txtBoxTelefone = new MaskedTextBox();
			SuspendLayout();
			// 
			// lblBoasVindas
			// 
			lblBoasVindas.AutoSize = true;
			lblBoasVindas.Location = new Point(459, 42);
			lblBoasVindas.Margin = new Padding(4, 0, 4, 0);
			lblBoasVindas.Name = "lblBoasVindas";
			lblBoasVindas.Size = new Size(145, 25);
			lblBoasVindas.TabIndex = 0;
			lblBoasVindas.Text = "Cadastrar Cliente";
			// 
			// lblNome
			// 
			lblNome.AutoSize = true;
			lblNome.Location = new Point(219, 124);
			lblNome.Margin = new Padding(4, 0, 4, 0);
			lblNome.Name = "lblNome";
			lblNome.Size = new Size(65, 25);
			lblNome.TabIndex = 1;
			lblNome.Text = "Nome:";
			// 
			// lblCPF
			// 
			lblCPF.AutoSize = true;
			lblCPF.Location = new Point(240, 174);
			lblCPF.Margin = new Padding(4, 0, 4, 0);
			lblCPF.Name = "lblCPF";
			lblCPF.Size = new Size(46, 25);
			lblCPF.TabIndex = 2;
			lblCPF.Text = "CPF:";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(216, 274);
			lblEmail.Margin = new Padding(4, 0, 4, 0);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(65, 25);
			lblEmail.TabIndex = 4;
			lblEmail.Text = "E-mail:";
			// 
			// lblTelefone
			// 
			lblTelefone.AutoSize = true;
			lblTelefone.Location = new Point(199, 219);
			lblTelefone.Margin = new Padding(4, 0, 4, 0);
			lblTelefone.Name = "lblTelefone";
			lblTelefone.Size = new Size(81, 25);
			lblTelefone.TabIndex = 3;
			lblTelefone.Text = "Telefone:";
			// 
			// lblEndereco
			// 
			lblEndereco.AutoSize = true;
			lblEndereco.Location = new Point(192, 374);
			lblEndereco.Margin = new Padding(4, 0, 4, 0);
			lblEndereco.Name = "lblEndereco";
			lblEndereco.Size = new Size(89, 25);
			lblEndereco.TabIndex = 6;
			lblEndereco.Text = "Endereço:";
			// 
			// lblSexo
			// 
			lblSexo.AutoSize = true;
			lblSexo.Location = new Point(230, 319);
			lblSexo.Margin = new Padding(4, 0, 4, 0);
			lblSexo.Name = "lblSexo";
			lblSexo.Size = new Size(54, 25);
			lblSexo.TabIndex = 5;
			lblSexo.Text = "Sexo:";
			// 
			// lblNasc
			// 
			lblNasc.AutoSize = true;
			lblNasc.Location = new Point(159, 424);
			lblNasc.Margin = new Padding(4, 0, 4, 0);
			lblNasc.Name = "lblNasc";
			lblNasc.Size = new Size(121, 25);
			lblNasc.TabIndex = 7;
			lblNasc.Text = "Data de Nasc:";
			// 
			// txtBoxEndereco
			// 
			txtBoxEndereco.Location = new Point(292, 365);
			txtBoxEndereco.Margin = new Padding(4, 4, 4, 4);
			txtBoxEndereco.Name = "txtBoxEndereco";
			txtBoxEndereco.Size = new Size(478, 31);
			txtBoxEndereco.TabIndex = 1;
			txtBoxEndereco.TabIndex = 7;
			// 
			// txtBoxEmail
			// 
			txtBoxEmail.Location = new Point(292, 265);
			txtBoxEmail.Margin = new Padding(4, 4, 4, 4);
			txtBoxEmail.Name = "txtBoxEmail";
			txtBoxEmail.Size = new Size(478, 31);
			txtBoxEmail.TabIndex = 2;
			txtBoxEmail.TabIndex = 4;
			// 
			// txtBoxNome
			// 
			txtBoxNome.Location = new Point(292, 115);
			txtBoxNome.Margin = new Padding(4, 4, 4, 4);
			txtBoxNome.Name = "txtBoxNome";
			txtBoxNome.Size = new Size(478, 31);
			txtBoxNome.TabIndex = 3;
			txtBoxNome.TabIndex = 0;
			// 
			// btnLimparCampos
			// 
			btnLimparCampos.AutoSize = true;
			btnLimparCampos.Location = new Point(292, 472);
			btnLimparCampos.Margin = new Padding(4, 4, 4, 4);
			btnLimparCampos.Name = "btnLimparCampos";
			btnLimparCampos.Size = new Size(146, 38);
			btnLimparCampos.TabIndex = 9;
			btnLimparCampos.Text = "Limpar Campo";
			btnLimparCampos.UseVisualStyleBackColor = true;
			btnLimparCampos.Click += btnLimparCampos_Click;
			// 
			// btnCadastrarUsuario
			// 
			btnCadastrarUsuario.AutoSize = true;
			btnCadastrarUsuario.Location = new Point(606, 472);
			btnCadastrarUsuario.Margin = new Padding(4, 4, 4, 4);
			btnCadastrarUsuario.Name = "btnCadastrarUsuario";
			btnCadastrarUsuario.Size = new Size(165, 38);
			btnCadastrarUsuario.TabIndex = 10;
			btnCadastrarUsuario.Text = "Cadastrar Cliente";
			btnCadastrarUsuario.UseVisualStyleBackColor = true;
			btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
			// 
			// radioMasc
			// 
			radioMasc.AutoSize = true;
			radioMasc.Location = new Point(292, 316);
			radioMasc.Margin = new Padding(4, 4, 4, 4);
			radioMasc.Name = "radioMasc";
			radioMasc.Size = new Size(117, 29);
			radioMasc.TabIndex = 4;
			radioMasc.TabIndex = 5;
			radioMasc.TabStop = true;
			radioMasc.Text = "Masculino";
			radioMasc.UseVisualStyleBackColor = true;
			// 
			// radioFem
			// 
			radioFem.AutoSize = true;
			radioFem.Location = new Point(429, 316);
			radioFem.Margin = new Padding(4, 4, 4, 4);
			radioFem.Name = "radioFem";
			radioFem.Size = new Size(110, 29);
			radioFem.TabIndex = 5;
			radioFem.TabIndex = 6;
			radioFem.TabStop = true;
			radioFem.Text = "Feminino";
			radioFem.UseVisualStyleBackColor = true;
			// 
			// txtBoxNasc
			// 
			txtBoxNasc.Location = new Point(292, 415);
			txtBoxNasc.Margin = new Padding(4, 4, 4, 4);
			txtBoxNasc.Mask = "00/00/0000";
			txtBoxNasc.Name = "txtBoxNasc";
			txtBoxNasc.Size = new Size(478, 31);
			txtBoxNasc.TabIndex = 6;
			txtBoxNasc.TabIndex = 8;
			txtBoxNasc.ValidatingType = typeof(DateTime);
			// 
			// txtBoxCPF
			// 
			txtBoxCPF.Location = new Point(292, 165);
			txtBoxCPF.Margin = new Padding(4, 4, 4, 4);
			txtBoxCPF.Mask = "000\\.000\\.000-00";
			txtBoxCPF.Name = "txtBoxCPF";
			txtBoxCPF.Size = new Size(478, 31);
			txtBoxCPF.TabIndex = 7;
			txtBoxCPF.TabIndex = 1;
			// 
			// txtBoxTelefone
			// 
			txtBoxTelefone.Location = new Point(292, 215);
			txtBoxTelefone.Margin = new Padding(4, 4, 4, 4);
			txtBoxTelefone.Mask = "(99) 00000-0000";
			txtBoxTelefone.Name = "txtBoxTelefone";
			txtBoxTelefone.Size = new Size(478, 31);
			txtBoxTelefone.TabIndex = 8;
			txtBoxTelefone.TabIndex = 3;
			// 
			// FrmCadastroCliente
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 562);
			Controls.Add(txtBoxTelefone);
			Controls.Add(txtBoxCPF);
			Controls.Add(txtBoxNasc);
			Controls.Add(radioFem);
			Controls.Add(radioMasc);
			Controls.Add(btnCadastrarUsuario);
			Controls.Add(btnLimparCampos);
			Controls.Add(txtBoxNome);
			Controls.Add(txtBoxEmail);
			Controls.Add(txtBoxEndereco);
			Controls.Add(lblNasc);
			Controls.Add(lblEndereco);
			Controls.Add(lblSexo);
			Controls.Add(lblEmail);
			Controls.Add(lblTelefone);
			Controls.Add(lblCPF);
			Controls.Add(lblNome);
			Controls.Add(lblBoasVindas);
			Margin = new Padding(4, 4, 4, 4);
			MaximizeBox = false;
			Name = "FrmCadastroCliente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CadastroCliente";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblBoasVindas;
		private Label lblNome;
		private Label lblCPF;
		private Label lblEmail;
		private Label lblTelefone;
		private Label lblEndereco;
		private Label lblSexo;
		private Label lblNasc;
		private TextBox txtBoxEndereco;
		private TextBox txtBoxEmail;
		private TextBox txtBoxNome;
		private Button btnLimparCampos;
		private Button btnCadastrarUsuario;
		private RadioButton radioMasc;
		private RadioButton radioFem;
		private MaskedTextBox txtBoxNasc;
		private MaskedTextBox txtBoxCPF;
		private MaskedTextBox txtBoxTelefone;
	}
}
