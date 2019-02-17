CREATE TABLE autor 
(
    id NUMBER NOT NULL,
    nome VARCHAR2(80) NOT NULL,
    CONSTRAINT autor_pk PRIMARY KEY(ID)
);

CREATE TABLE livro
(
    id NUMBER NOT NULL,
    nome VARCHAR2(80) NOT NULL,
    preco NUMBER(10,2) NOT NULL,
    data_publicacao DATE NOT NULL,
    img_capa VARCHAR2(80) NOT NULL,
    autor_id NUMBER NOT NULL,
    CONSTRAINT livro_pk PRIMARY KEY(ID),
    CONSTRAINT autor_fk 
    FOREIGN KEY (autor_id)
    REFERENCES autor(id)
);

CREATE TABLE isbn
(
	isbn NUMBER NOT NULL,
	livro_id NUMBER NOT NULL,
    CONSTRAINT isbn PRIMARY KEY(isbn),
    CONSTRAINT livro_fk 
    FOREIGN KEY (livro_id)
    REFERENCES livro(id)
);
