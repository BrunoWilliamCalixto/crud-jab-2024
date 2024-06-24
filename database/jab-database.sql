CREATE TABLE IF NOT EXISTS Clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    cpf VARCHAR(16) NOT NULL,
    telefone VARCHAR(15),
    email VARCHAR(50),
    sexo VARCHAR(10),
    endereco VARCHAR(50) NOT NULL,
    dataNascimento VARCHAR(12) NOT NULL
);