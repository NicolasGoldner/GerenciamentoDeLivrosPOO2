# Trabalho: Gerenciamento de Livros

**Aluno:** Nicolas Oliveira Goldner  
**Disciplina:** POO 2

---

## Modelo de Dados

O projeto utiliza um banco de dados relacional para armazenar informações de livros. A estrutura inclui três tabelas principais:

### Autores:

- Contém os autores de livros com o campo `nome`.

### Categorias:

- Armazena os gêneros dos livros.

### Livros:

- Cada livro possui os seguintes atributos:
  - `titulo`: Título do livro.
  - `ano_publicacao`: Ano de publicação do livro.
  - `autor_id`: Relacionamento com a tabela `Autores`.
  - `categoria_id`: Relacionamento com a tabela `Categorias`.

### Relações entre as Tabelas:

- **`Livros` -> `Autores`** (um para muitos).
- **`Livros` -> `Categorias`** (um para muitos).

---

## Escolhas de Design

### Padrão Singleton:

- Gerencia a conexão com o banco de dados para evitar múltiplas instâncias e melhorar a performance.

### Interface Simples:

- O formulário utiliza:
  - `DataGridView` para exibir os dados.
  - `TextBox` e `ComboBox` para entrada e seleção de dados.

### Flexibilidade:

- Usuários podem adicionar novos autores e categorias diretamente pela interface gráfica, garantindo maior flexibilidade na gestão de dados.

---

## Funcionalidades Implementadas

1. **CRUD para Livros**:

   - Adicionar, editar, excluir e visualizar os livros.

2. **Adicionar Autores e Categorias**:
   - Entrada direta de novos autores e categorias por meio da interface gráfica.

---

## Instruções para Testar

1. Execute o script SQL (`script_banco.sql`) para criar e popular o banco de dados.
2. Configure o projeto no Visual Studio:
   - Instale as dependências (pacote `MySQL.Data`).
3. Compile e execute o projeto no Visual Studio.
4. Use os botões na interface gráfica para realizar as operações desejadas:
   - CRUD para livros.
   - Inserir novos autores e categorias.

---
