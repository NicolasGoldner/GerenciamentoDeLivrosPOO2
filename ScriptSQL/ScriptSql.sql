CREATE DATABASE IF NOT EXISTS biblioteca;

USE biblioteca;

-- Tabela de Autores
CREATE TABLE Autores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

-- Tabela de Categorias
CREATE TABLE Categorias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL
);

-- Tabela de Livros
CREATE TABLE Livros (
    id INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(255) NOT NULL,
    ano_publicacao DATE NOT NULL,
    autor_id INT NOT NULL,
    categoria_id INT NOT NULL,
    FOREIGN KEY (autor_id) REFERENCES Autores(id) ON DELETE CASCADE,
    FOREIGN KEY (categoria_id) REFERENCES Categorias(id) ON DELETE CASCADE
);

-- Inserção de Dados Iniciais
INSERT INTO Autores (nome) VALUES 
('J.R.R. Tolkien'),
('George Orwell'),
('Jane Austen');

INSERT INTO Categorias (nome) VALUES 
('Fantasia'),
('Ficção Científica'),
('Romance');

INSERT INTO Livros (titulo, ano_publicacao, autor_id, categoria_id) VALUES 
('O Senhor dos Anéis', '1954-07-29', 1, 1),
('1984', '1949-06-08', 2, 2),
('Orgulho e Preconceito', '1813-01-28', 3, 3);


