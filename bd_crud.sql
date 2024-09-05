CREATE DATABASE bd_crud;
USE bd_crud;

CREATE TABLE cliente(
id_cli INT PRIMARY KEY AUTO_INCREMENT,
nome_cli VARCHAR(100),
cpf_cli VARCHAR(15),
email_cli VARCHAR(100),
telefone_cli VARCHAR(15),
dataNasc_cli DATE
);

SELECT * FROM cliente;