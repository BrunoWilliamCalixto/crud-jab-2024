namespace Project_jab_2024
{
	partial class FrmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCadastrarCliente = new Button();
			btnConsultaCliente = new Button();
			txtBoasVindasJAB = new Label();
			SuspendLayout();
			// 
			// btnCadastrarCliente
			// 
			btnCadastrarCliente.AutoSize = true;
			btnCadastrarCliente.Location = new Point(104, 95);
			btnCadastrarCliente.Name = "btnCadastrarCliente";
			btnCadastrarCliente.Size = new Size(143, 36);
			btnCadastrarCliente.TabIndex = 0;
			btnCadastrarCliente.Text = "Cadastrar Cliente";
			btnCadastrarCliente.UseVisualStyleBackColor = true;
			btnCadastrarCliente.Click += btnCadastrarCliente_click;
			// 
			// btnConsultaCliente
			// 
			btnConsultaCliente.AutoSize = true;
			btnConsultaCliente.Location = new Point(468, 95);
			btnConsultaCliente.Name = "btnConsultaCliente";
			btnConsultaCliente.Size = new Size(143, 36);
			btnConsultaCliente.TabIndex = 1;
			btnConsultaCliente.Text = "Consultar Cliente";
			btnConsultaCliente.UseVisualStyleBackColor = true;
			btnConsultaCliente.Click += btnConsultarCliente_click;
			// 
			// txtBoasVindasJAB
			// 
			txtBoasVindasJAB.AutoSize = true;
			txtBoasVindasJAB.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			txtBoasVindasJAB.Location = new Point(155, 18);
			txtBoasVindasJAB.Name = "txtBoasVindasJAB";
			txtBoasVindasJAB.Size = new Size(402, 37);
			txtBoasVindasJAB.TabIndex = 2;
			txtBoasVindasJAB.Text = "Boas Vindas ao Teste JAB2024";
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(705, 167);
			Controls.Add(txtBoasVindasJAB);
			Controls.Add(btnConsultaCliente);
			Controls.Add(btnCadastrarCliente);
			Name = "Main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCadastrarCliente;
		private Button btnConsultaCliente;
		private Label txtBoasVindasJAB;
	}
}
