using System;

namespace Project_jab_2024.UserControls
{
	public class Cliente
	{
		public int Id { get; set; } // Propriedade para o ID do cliente

		public string Nome { get; set; }

		public string CPF { get; set; }

		public string Telefone { get; set; }

		public string Email { get; set; }

		public string Sexo { get; set; }

		public string Endereco { get; set; }

		public string DataNascimento { get; set; }

		// Construtor padrão
		public Cliente(){}

	}
}
