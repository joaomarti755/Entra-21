CREATE TABLE unidades_federativas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	sigla VARCHAR(2));

CREATE TABLE cidades(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	quantidade_habitantes INTEGER,
	data_hora_fundacao DATETIME2,
	pib DECIMAL(15,2),

	id_unidades_federativas INTEGER,

	FOREIGN KEY(id_unidades_federativas) REFERENCES unidades_federativas(id));