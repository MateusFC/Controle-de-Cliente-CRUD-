Use crud
CREATE TABLE Pessoa(
Codigo int not null primary key identity,
Nome nvarchar(50) not null,
Endereco nvarchar(50) not null,
Email nvarchar(50)not null
);
select * from Pessoa

