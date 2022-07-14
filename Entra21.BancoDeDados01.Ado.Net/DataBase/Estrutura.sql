CREATE TABLE tipos_personagens(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	tipo VARCHAR(20));

CREATE TABLE editoras(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	apelido VARCHAR(20),
	nome VARCHAR(50),
	faturamento DECIMAL(13,2),
	data_criacao DATETIME2);

CREATE TABLE personagens(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_editoras INTEGER,
	id_tipo_personagens INTEGER,

	nome VARCHAR(50),

	FOREIGN KEY(id_editoras) REFERENCES editoras(id),
	FOREIGN KEY(id_tipo_personagens) REFERENCES tipos_personagens(id));