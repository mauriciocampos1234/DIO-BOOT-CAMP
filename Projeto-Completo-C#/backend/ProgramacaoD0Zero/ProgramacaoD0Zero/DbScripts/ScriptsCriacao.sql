--1 - CRIAR O BANCO
CREATE DATABASE programacao_do_zero;

-- 2 - USAR O BANCO
USE programacao_do_zero;

-- 3 - CRIAR A TABELA USUÁRIO
CREATE TABLE usuario (
   --id INT NOT NULL AUTO_INCREMENT, --Só comentei esta linha porque o visual studio não aceita, mas o comando roda normal lá no mysql workbench
    nome VARCHAR(50) NOT NULL,
    sobrenome VARCHAR(150) NOT NULL,
    telefone VARCHAR(15) NOT NULL,
    email VARCHAR(50) NOT NULL,
    genero VARCHAR(20) NOT NULL,
    senha VARCHAR(30) NOT NULL,
    PRIMARY KEY (id)
);

-- 4 - CRIAR A TABELA ENDEREÇO
CREATE TABLE endereco (
    --id INT NOT NULL AUTO_INCREMENT, --Só comentei esta linha porque o visual studio não aceita, mas o comando roda normal lá no mysql workbench
    logradouro VARCHAR(250) NOT NULL,
    numero VARCHAR(30) NOT NULL,
    complemento VARCHAR(150) NULL,
    bairro VARCHAR(150) NOT NULL,
    cidade VARCHAR(250) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(10) NOT NULL,
    PRIMARY KEY (id)
);

-- 5 - RELACIONAR AS TABELAS USUÁRIOS E ENDEREÇO
ALTER TABLE endereco ADD usuario_id INT NOT NULL; --Comando para alterar uma tabela, no caso endereço
-- Adicionando a coluna usuarios_id na tabela endereco

ALTER TABLE endereco ADD CONSTRAINT fk_usuario FOREIGN KEY (usuario_id) REFERENCES usuario(id); --Cria a relação entre as tabelas
-- Adicionando a chave estrangeira usuarios_id na tabela endereco

-- 6 - INSERIR USUÁRIOS
INSERT INTO usuario (nome, sobrenome, telefone, email, genero, senha) VALUES ('Mauricio', 'Campos', '12-9-9102-3320', 'rjeejr@gmail.com', 'Masculino', '123456');
INSERT INTO usuario (nome, sobrenome, telefone, email, genero, senha) VALUES ('Fatima', 'Dantas', '12 9-8182-7278', 'fatimadantaspodologia@gmail.com', 'Feminino', '654321');

-- 7 - Exibir os dados inseridos na tabela usuarios (Selecionar todos os usuários)
SELECT * FROM usuario;

-- 8 - SELECIONAR UM USÁRIO ESPECIFÍCO
SELECT * FROM usuario WHERE id = 1; --Pode ser por id ou por email ou cpf/cnpj

-- 9 - ALTERAR UM USUÁRIO 

UPDATE usuario SET nome = 'Lucas' WHERE id = 1; --Atualiza o nome do usuário com id 1, mas pode ser qualquer outro campo

-- 10 - EXCLUIR UM USUÁRIO
DELETE FROM usuario WHERE id = 3; --Deleta o usuário com id 3, mas pode ser qualquer outro campo

DELETE FROM usuario WHERE id IN (1, 2); --Deleta os usuários com id 1 e 2, 3, 4 etc., mas pode ser qualquer outro campo

-- 11 - EXCLUIR TODOS USUÁRIOS
DELETE FROM usuario WHERE id > 0;

-- 12 - ADICIONAR GUID NA TABELA USUÁRIOS
ALTER TABLE usuario ADD usuarioGuid VARCHAR(36) NOT NULL; --GUID significa Global Unique Identifier, ou seja, um identificador único global.