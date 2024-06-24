
# Projeto de Cadastro e Consulta de Clientes
Projeto para Avaliação Técnica JAB 2024

## Finalidade do Projeto
Este projeto tem como objetivo manipular dados de clientes registrados em um banco de dados, permitindo operações de cadastro, consulta, edição e exclusão de clientes.

### Pré-requisitos
Última versão do .NET Framework instalada.
Visual Studio instalado (pode ser baixado em Visual Studio).
Banco de dados configurado com a tabela de clientes.
Caso necessário, realizar a instalação do pacote MySQLno NuGet

Observação: O banco de dados se encontra na plataforma da AWS, não sendo necessário realizar uma configuração na tabela, mas caso deseje rodar em um host local, edite nos devidos campos da Classe ClienteDAO.

### Passos
1. Clone o repositório em sua máquina local.
2. Abra o projeto no Visual Studio.
3. Navegue até a classe FrmMain.
4. Configure a string de conexão ao banco de dados conforme necessário no método "private MySqlConnection GetConnection()" > Classe ClienteDAO.
## Funcionalidades do Projeto
### Cadastro de Clientes
O formulário FrmCadastroCliente permite o cadastro de novos clientes.
Informações como Nome, CPF, Telefone, Email, Gênero, Endereço e Data de Nascimento são inseridas.
Ao clicar em "Cadastrar", os dados são salvos no banco de dados.
### Consulta de Clientes
O formulário FrmConsultaCliente permite a busca de clientes pelo CPF.
Exibe os detalhes do cliente encontrado, incluindo Nome, Endereço, Gênero, Telefone, Email e Data de Nascimento.
Oferece opções para editar ou excluir o cliente encontrado.
### Edição de Clientes
O formulário FrmAtualizacaoCliente permite a atualização dos dados do cliente.
Preenche os campos com os dados atuais do cliente e permite modificações.
Ao clicar em "Salvar", as alterações são atualizadas no banco de dados.
### Exclusão de Clientes
No formulário FrmConsultaCliente, a opção de exclusão é disponibilizada.
Confirma a exclusão com o usuário antes de remover o cliente do banco de dados.
## Estrutura do Projeto
### O projeto está organizado da seguinte maneira:

FrmMain.cs: Formulário principal que inicia a aplicação e gerencia a navegação.
FrmCadastroCliente.cs: Formulário para cadastro de novos clientes.
FrmConsultaCliente.cs: Formulário para consulta de clientes pelo CPF.
FrmAtualizacaoCliente.cs: Formulário para atualização dos dados do cliente.

## Instruções de Uso
1. Abra o projeto no Visual Studio.
2. Configure a string de conexão no arquivo function_db.cs.
3. Execute o projeto (F5 no Visual Studio).
4. Utilize a interface do formulário principal para cadastrar, consultar, editar ou excluir clientes.
Configurações do Projeto (IMPORTANTE)

* Recomenda-se configurar a string de conexão ao banco de dados conforme o ambiente em que o projeto será executado.
As tabelas e estrutura do banco de dados devem estar de acordo com as especificações fornecidas no projeto.
### O que o código faz:
Manipulação de Dados: Permite manipular dados de clientes, incluindo cadastro, consulta, edição e exclusão de registros.
Interação com Banco de Dados: Utiliza ADO.NET para interagir com um banco de dados SQL Server.
Consulta por CPF: Permite ao usuário consultar informações sobre um cliente específico usando seu CPF.
Atualização de Dados: O sistema é capaz de atualizar os dados dos clientes no banco de dados a partir do formulário de edição.

## Considerações Finais
Agradeço a oportunidade de aprendizado proporcionada por este projeto. Dediquei-me a implementar e testar as funcionalidades principais, conforme as necessidades do desafio. O projeto ainda possui potencial para melhorias e otimizações, mas está apto a atender os requisitos propostos com eficiência.
