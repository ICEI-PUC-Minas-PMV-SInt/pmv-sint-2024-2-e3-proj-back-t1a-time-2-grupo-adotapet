
-- INSERINDO DADOS

-- Inserindo dados na tabela usuario
INSERT INTO Usuario values ('001', 'Narcisa Neves');
INSERT INTO Usuario (Nome,Cod_usuario) values ('Antonio Souza Costa','002');
INSERT INTO Usuario (Cod_usuario,Nome) value ('003','Paulo de Tarso');
INSERT INTO Usuario (Cod_usuario) values ('004');
INSERT INTO Usuario (Cod_usuario,Nome) value ('005','Juliana de Castro');

-- Atualizando/Alterando um dado em uma tabela
UPDATE Usuario SET Nome = 'Matias Pereira' where Cod_usuario = '004';

select * from Usuario;


-- Inserindo dados na tabela Anuncio
INSERT INTO Anuncio (Cod_usuario,Nome) values ('1','Luke');
INSERT INTO Anuncio (Cod_usuario,Nome) values ('2', 'Beethoven');
INSERT INTO Anuncio (Cod_usuario,Nome) values ('3', 'Nina');
INSERT INTO Anuncio (Cod_usuario,Nome) values ('4', 'Bidu');
INSERT INTO Anuncio (Cod_usuario,Nome) values ('5','Bel');

select * from Anuncio;


-- Inserindo dados na tabela Pet
INSERT INTO Pet (Cod_Pet,Nome_Pet,Anuncio,Usuario,Contato) values
    ('P01', 'Luke', '1', '001', '001'),
    ('P02', 'Beethoven', '2', '002', '002'),
    ('P03', 'Nina', '3', '003', '003'),
    ('P04', 'Bidu', '4', '004', '004'),
    ('P05', 'Bel', '5', '005', '005');


    
    select * from Pet;
    
    -- Inserindo dados na tabela Contato
INSERT INTO Contato (Cod_usuario,Telefone,Email) values 
	('001','31985588855', 'narcisa.neves@hotmail.com'),
    ('002','31985555555', 'antonio.souza@outlook.com'),
    ('003','31985501011', 'paulo.tarso@yahoo.com.br'),
    ('004','31985222555', 'matias.pereira@hotmail.com'),
    ('005','31952525252', 'juliana.castro@gmail.com');
    
    select * from Contato;