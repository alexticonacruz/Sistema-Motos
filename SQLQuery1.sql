create database palmiraSur

use palmiraSur

create table asociaciones 
(
	asociacionId integer primary key identity(1,1) not null,
	nombre varchar(89),
	personeriaJuridica varchar(200),
	estado char(1)
)

create table cajas
(
	cajaId integer primary key identity(1,1),
	asociacionId integer not null,
	dineroActual decimal (10,1)

	foreign key (asociacionId)references asociaciones (asociacionId)
)

create table personas (
personaId integer primary key identity(1,1) not null ,
nombre varchar (89),
nombre2 varchar(89),
apellidoPaterno varchar(99),
apellidoMaterno varchar(99),
cedulaI integer,
domicilio varchar(399),
celular integer,

asociacionId integer not null --PK
foreign key (asociacionId) references  asociaciones(asociacionId)
)

create table socios
(
	socioId integer primary key identity (1,1) not null, --PK
	estado char(1) not null,
	personaId integer not null --Fk

	-- Llaves foraneas
	foreign key (personaId) references personas (personaId)
)
/*--------------------------------------------------*/
/* -------   Tabla Categoria Deudas		-----------*/
create table categoriaDeuda
(
	categoriaId integer identity (1,1) not null primary key,
	nombre varchar (99)
)
/*--------------------------------------------------*/
create table tipoDeudas
(
	tipoDeudaId integer primary key identity(1,1) not null,
	nombre varchar (500),
	monto decimal (10,2),
	categoriaId integer

	FOREIGN KEY (categoriaId) REFERENCES categoriaDeuda(categoriaId)
)

create table deudas
(
	deudaId integer primary key identity(1,1) not null,
	fecha date,
	estado char(1),
	tipoDeudaId integer, --FK
	socioId integer not null, --FK
	descripcion varchar(940)
	--llaves foraneas
	foreign key (socioId) references socios(socioId),
	foreign key (tipoDeudaId) references tipoDeudas(tipoDeudaId)
)
--alter table deudas add descripcion varchar(940)

--ALTER TABLE deudas
--ADD FOREIGN KEY (usuarioId) REFERENCES Usuario(usuarioId





-- uSUARIOS Y rOLES
CREATE TABLE Usuario (
  usuarioId INTeger PRIMARY KEY IDENTITY(1,1),
  nombreUsuario VARCHAR(50) NOT NULL,
  contrasena VARCHAR(50) NOT NULL
);

CREATE TABLE Rol (
  rolId INT PRIMARY KEY IDENTITY(1,1),
  nombreRol VARCHAR(50) NOT NULL
);

CREATE TABLE Permiso (
  permisoId INT PRIMARY KEY IDENTITY(1,1),
  nombrePermiso VARCHAR(50) NOT NULL
);

CREATE TABLE UsuarioRol (
  usuarioId INT NOT NULL,
  rolId INT NOT NULL,
  PRIMARY KEY (usuarioId, rolId),
  FOREIGN KEY (usuarioId) REFERENCES Usuario(usuarioId),
  FOREIGN KEY (rolId) REFERENCES Rol(rolId)
);

CREATE TABLE RolPermiso (
  rolId INT NOT NULL,
  permisoId INT NOT NULL,
  PRIMARY KEY (rolId, permisoId),
  FOREIGN KEY (rolId) REFERENCES Rol(rolId),
  FOREIGN KEY (permisoId) REFERENCES Permiso(permisoId)
);
----------------------------------------------
create table ingresos
(
	ingresoId integer primary key not null identity (1,1),--PK
	monto decimal (10,2),
	descripcion varchar (500),
	cajaId integer, --FK
	usuarioId integer,
	fecha date 

	foreign key (cajaId) references cajas (cajaId),
	foreign key (usuarioId) references Usuario(usuarioId)
)
--ALTER TABLE ingresos
--ADD FOREIGN KEY (usuarioId) REFERENCES Usuario(usuarioId)

/*--------------------------------------------------*/
/* -------   Tabla detalle ingresos		-----------*/
create table detalleIngresos
(
	ingresoId integer NOT NULL,
    deudaId integer NOT NULL,
    CONSTRAINT PK_detalleIngreso PRIMARY KEY (ingresoId, deudaId),
    CONSTRAINT FK_detalleIngreso_ingresoId FOREIGN KEY (ingresoId) REFERENCES ingresos(ingresoId),
    CONSTRAINT FK_detalleIngreso_deudaId FOREIGN KEY (deudaId) REFERENCES deudas(deudaId)
)
/*--------------------------------------------------*/
/* -------   Tabla motos		-----------*/
CREATE TABLE motos
(
	motoId INTEGER PRIMARY KEY NOT NULL identity(1,1),
	Marca VARCHAR(50),
	Modelo VARCHAR(50),
	SocioID INTEGER NOT NULL,
	Placa VARCHAR(50)
	FOREIGN KEY (SocioID) REFERENCES socios(socioId)
);
create table egresos(
egresoId integer identity(1,1) not null primary key,
monto decimal(10,2) not null,
detalle varchar(800),
fecha date not null,

cajaId integer,
usuarioId integer,

foreign key (cajaId) references cajas(cajaId),
foreign key (usuarioId) references Usuario(usuarioId)

)
/*-----------	 Usuarios ---------------------*/

create table Users(
UserID int identity(1,1) primary key,
LoginName nvarchar (100) unique not null,
Password nvarchar (100) not null,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Position nvarchar (100) not null,
Email nvarchar(150)not null
) 
insert into Users values ('admin','admin','Jackson','Collins','Administrator','Support@SystemAll.biz')
insert into Users values ('Ben','abc123456','Benjamin','Thompson','Receptionist','BenThompson@MyCompany.com')                                                         
insert into Users values ('Kathy','abc123456','Kathrine','Smith','Accounting','KathySmith@MyCompany.com')

/*--------------------------------------------*/



insert into categoriaDeuda values ('Mensualidad')
insert into categoriaDeuda values ('Transferencia')
insert into categoriaDeuda values ('Multas')
insert into categoriaDeuda values ('Tikes')
insert into categoriaDeuda values ('Retrasos')
/*---------------------------------------------*/


-- creacion de cuenta de login y bd
--CREATE LOGIN alex WITH PASSWORD = '123456';

--CREATE USER [alex] FOR LOGIN [alex];

--GRANT SELECT ON [palmiraSur].[socios] TO [alex];


--SELECT name, type_desc, create_date, modify_date
--FROM sys.database_principals
--WHERE type IN ('U', 'S')
--ORDER BY create_date DESC;

--------------- inserciones importantes que deben hacerce hasta nueva actualizacion -----------------------
--********************* se requiere  ejecutar ---------------------------
insert into asociaciones values('Palmira sur','2012/5','a')

insert into cajas values (1,0)

--insert into tipoDeudas values ('Mensualidad',35)
--insert into tipoDeudas values ('Reunion',50)
--insert into tipoDeudas values ('viñeta',20)

insert into Usuario values ('alex','alex2909')

--*******************************************************************************
select * from cajas
select * from asociaciones
select * from tipoDeudas
select * from personas
select * from socios
select * from Usuario

  select tipoDeudaId from tipoDeudas where nombre = 'mensualidad'

  select * from deudas where socioId = 3
  select * from deudas
  /*  ------------	Consultas de aqui para abajo ------------------------------------------*/
 --	--------- -----------------------------	-	-	-	-	-	-	-	--		-------
  ----------------- Consulta super filtro de deudas +---------------------------------
  select d.deudaId, p.nombre, p.apellidoPaterno, t.nombre,d.descripcion,d.fecha ,t.monto  from deudas d 
  inner join tipoDeudas t ON d.tipoDeudaId = t.tipoDeudaId
  inner join socios s ON s.socioId = d.socioId
  inner join personas p ON s.personaId = p.personaId
  where s.socioId = 2 and d.estado = 'A' -- cuando busque por textbox
  -----------------------------------------------------------------------------------------

  /* -------------   seleccionar que todos los socios deban un mes */
  insert into deudas values ('$fecha','A',1,$socioId,'$descripcion')
  insert into deudas values ('8/5/2023 00:00:00','A',1,1,'febrero')
  select * from tipoDeudas
  select * from socios
  ----------------- Verifica si existe un socio ----------------------------
  select * from socios where socioId = 1

  select s.socioId, p.nombre, p.apellidoPaterno, p.apellidoMaterno,p.celular,p.domicilio from socios s inner join personas p on s.personaId = p.personaId
  select * from cajas

  --update cajas set dineroActual = dineroActual + 5 where cajaId = 1
  --update deudas set estado = 'I' where deudaId = 1


  /* Consultas Verificadas*/

select d.deudaId,s.socioId, p.nombre, p.apellidoPaterno,cD.nombre AS CATEGORIA, t.nombre,d.descripcion,d.fecha ,t.monto  from deudas d
inner join tipoDeudas t ON d.tipoDeudaId = t.tipoDeudaId
inner join categoriaDeuda cD on t.categoriaId = cD.categoriaId
inner join socios s ON s.socioId = d.socioId
inner join personas p ON s.personaId = p.personaId 
where d.estado = 'A' and s.socioId = 5 and cD.nombre = 'Mensualidad'

select * from deudas
select * from tipoDeudas
select * from categoriaDeuda
