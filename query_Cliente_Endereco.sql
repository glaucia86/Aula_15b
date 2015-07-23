go 
create table Cliente (
	
	IdCliente		integer			identity,
	Nome			nvarchar(50)	not null,
	Email			nvarchar(50)	not null,
	Sexo			char(1)			not null,
	DataNascimento	date			not null,

	primary key(IdCliente))

go
alter table Cliente add constraint CkClienteSexo
check(Sexo = 'M' or Sexo = 'F')

go 
create table Endereco(
	IdEndereco		integer			identity,
	Logradouro		nvarchar(max)	not null,
	Cidade			nvarchar(50)	not null,
	Estado			nvarchar(50)	not null,
	Tipo			nvarchar(25)	not null,
	IdCliente		integer			not null,

	primary Key (IdEndereco),
	foreign key (IdCliente) references Cliente(IdCliente))

go
alter table Endereco add constraint CkEnderecoTipo
check(Tipo = 'Residencial' or Tipo = 'Comercial')