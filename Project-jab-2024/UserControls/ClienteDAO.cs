using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_jab_2024.UserControls
{
	class ClienteDAO
	{
		private string connectionString = "Server=database-1.cho4s0m0wgky.us-east-2.rds.amazonaws.com;Database=db_jab2024;Uid=admin;Pwd=12345678;";

		private MySqlConnection GetConnection()
		{
			return new MySqlConnection(connectionString);
		}

		public void InserirCliente(Cliente cliente)
		{
			try
			{
				string query = "INSERT INTO Clientes (nome, cpf, telefone, email, sexo, endereco, dataNascimento) " +
						   "VALUES (@Nome, @CPF, @Telefone, @Email, @Sexo, @Endereco, @DataNascimento)";

				using (MySqlConnection connection = GetConnection())
				{
					MySqlCommand command = new MySqlCommand(query, connection);
					command.Parameters.AddWithValue("@Nome", cliente.Nome);
					command.Parameters.AddWithValue("@CPF", cliente.CPF);
					command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
					command.Parameters.AddWithValue("@Email", cliente.Email);
					command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
					command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
					command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);

					connection.Open();
					command.ExecuteNonQuery();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
			}
		}

		public Cliente SelecionarClienteCPF(string cpf)
		{
			Cliente cliente = null;
			string query = "SELECT id, nome, cpf, telefone, email, sexo, endereco, dataNascimento FROM Clientes WHERE cpf = @CPF";

			using (MySqlConnection connection = GetConnection())
			{
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@CPF", cpf);
				connection.Open();
				MySqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					cliente = new Cliente
					{
						Id = Convert.ToInt32(reader["id"]),
						Nome = Convert.ToString(reader["nome"]),
						CPF = Convert.ToString(reader["cpf"]),
						Telefone = Convert.ToString(reader["telefone"]),
						Email = Convert.ToString(reader["email"]),
						Sexo = Convert.ToString(reader["sexo"]),
						Endereco = Convert.ToString(reader["endereco"]),
						DataNascimento = Convert.ToString(reader["dataNascimento"])
					};
				}

				reader.Close();
			}

			return cliente;
		}

		public bool ExcluirClientes(int idCliente)
		{
			string query = "DELETE FROM Clientes WHERE id = @Id";

			using (MySqlConnection connection = GetConnection())
			{
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@Id", idCliente);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return rowsAffected > 0;
			}
		}

		public void AtualizarCliente(Cliente cliente)
		{
			string query = "UPDATE Clientes SET nome = @Nome, cpf = @CPF, telefone = @Telefone, " +
						   "email = @Email, sexo = @Sexo, endereco = @Endereco, dataNascimento = @DataNascimento " +
						   "WHERE id = @Id";

			using (MySqlConnection connection = GetConnection())
			{
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@Nome", cliente.Nome);
				command.Parameters.AddWithValue("@CPF", cliente.CPF);
				command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
				command.Parameters.AddWithValue("@Email", cliente.Email);
				command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
				command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
				command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
				command.Parameters.AddWithValue("@Id", cliente.Id);

				connection.Open();
				command.ExecuteNonQuery();
			}
		}

	}
}
