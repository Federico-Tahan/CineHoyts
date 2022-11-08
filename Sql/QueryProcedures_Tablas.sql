backup database CINE_HOYTS to disk = 'C:\Users\Federico Tahan\Desktop\base\goku.bak'


create database CINE_HOYTS
go
use CINE_HOYTS
go
set dateformat DMY	
go
--------------------------------------------------------------
create table PROVINCIAS (
id_provincia int,
provincia varchar (100),
constraint pk_provincia primary key(id_provincia),
)
go
create table LOCALIDADES (
id_localidad int,
localidad varchar (100),
id_provincia int,
constraint pk_localidad primary key (id_localidad),
constraint fk_provincia foreign key(id_provincia) references PROVINCIAS (id_provincia)
)
go
create table BARRIOS (
id_barrio int,
barrio varchar (100),
id_localidad int,
constraint pk_barrios primary key (id_barrio),
constraint fk_localidad foreign key (id_localidad) references LOCALIDADES (id_localidad)
)
go
create table TIPOS_DE_DOCUMENTOS(
id_tipo_doc int ,
tipo_documento varchar (50),
constraint pk_tipo_doc primary key (id_tipo_doc)
)
go
create table PERSONAS(
id_persona int identity (1,1),
nombre varchar (100),
apellido varchar (100),
direccion varchar (100),
nro_direccion int, 
id_barrio int,
id_tipo_doc int,
nro_doc bigint,
fecha_nacimiento datetime,
Sexo int,
constraint pk_persona primary key (id_persona),
constraint fk_barrio foreign key (id_barrio) references BARRIOS (id_barrio),
constraint fk_tipo_doc foreign key(id_tipo_doc) references TIPOS_DE_DOCUMENTOS (id_tipo_doc),
)
go
create table TIPOS_DE_CONTACTOS(
id_tipo_contacto int,
tipo_contacto varchar (25),
constraint pk_tipo_contacto primary key (id_tipo_contacto)
)
go
create table CONTACTOS(
id_contacto int identity (1,1),
contacto varchar (50),
id_tipo_contacto int,
id_persona int
constraint pk_contacto primary key (id_contacto),
constraint fk_tipo_contactos foreign key (id_tipo_contacto) references TIPOS_DE_CONTACTOS (id_tipo_contacto),
constraint fk_persona foreign key (id_persona) references PERSONAS (id_persona)
)
go
create table VENDEDORES(
id_vendedor int identity(1,1),
id_persona int,
usuario varchar(50),
contraseña varchar(50),
baja_logica bit
constraint pk_vendedor primary key (id_vendedor),
constraint fk_persona_v foreign key (id_persona) references PERSONAS (id_persona)
)
go
create table CLIENTES(
id_cliente int identity (1,1),
id_persona int,
baja_logica bit 
constraint pk_cliente primary key (id_cliente),
constraint fk_persona_c foreign key (id_persona) references PERSONAS (id_persona)
)
go
create table FORMA_PAGO(
id_forma_pago int,
forma_pago varchar (25),
constraint pk_forma_pago primary key (id_forma_pago)
)
go
create table TIPO_COMPRA(
id_tipo_compra int identity (1,1),
tipo_compra varchar (50)
constraint pk_tipo_compra primary key (id_tipo_compra)
)
go
Create table PRODUCTOR (
id_producto int identity(1,1) not null,
nombre varchar(50) not null,
constraint pk_id_producto primary key (id_producto)
)
go
create table TIPO_PUBLICO(
id_tipo_publico int not null,
tipo_publico varchar(60),
constraint pk_id_tipo_de_publico primary key(id_tipo_publico)
)
go
Create table RESTRICION_DE_EDAD(
id_restriccion int not null,
edad int not null,
detalle varchar(100) not null
constraint pk_id_restriccion primary key (id_restriccion)
)
go
create table IDIOMAS(
id_idioma int not null,
idioma varchar(60),
constraint pk_id_idioma primary key (id_idioma)
)
go
Create table PELICULA(
id_pelicula int identity (1,1) not null,
duracion int not null,
id_restriccion int,
id_productor int,
titulo varchar(150),
descripcion varchar(150),
imagen image,
baja_logica bit
constraint pk_id_pelicula primary key(id_pelicula),
constraint fk_id_restriccion foreign key (id_restriccion) references RESTRICION_DE_EDAD (id_restriccion),
constraint fk_id_productor foreign key (id_productor) references PRODUCTOR (id_producto)
)
go
Create table CATEGORIA_PELICULA(
id_categoria_pelicula int not null,
categoria_pelicula varchar(60) not null,
id_pelicula int,
constraint pk_id_categoria_pelicula primary key (id_categoria_pelicula),
constraint fk_id_pelicula foreign key (id_pelicula) references PELICULA (id_pelicula)
)
go
create table DIA(
id_dia int,
dia varchar(10),
constraint pk_id_dia primary key(id_dia))
go 
create table HORARIO(
id_horario int,
id_dia int,
hora varchar(2),
constraint pk_id_horario primary key(id_horario),
constraint fk_id_dia foreign key(id_dia) references DIA(id_dia))
go 
create table TIPO_DE_SALA(
id_tipo_sala int,
tipo_sala varchar(100)
constraint pk_id_tipo_sala primary key(id_tipo_sala))

go 

CREATE TABLE BUTACA(
ID_BUTACA INT,
FILA VARCHAR(2),
NRO INT
CONSTRAINT PK_ID_BUTACA PRIMARY KEY(ID_BUTACA)
)
GO


create table SALA(
id_sala int,
id_tipo_sala int
constraint pk_id_sala primary key(id_sala),
constraint fk_id_tipo_sala foreign key(id_tipo_sala) references tipo_de_sala(id_tipo_sala))
GO
CREATE TABLE BUTACA_SALA(
ID_BUTACA_SALA INT IDENTITY(1,1),
ID_BUTACA INT,
ID_SALA INT
CONSTRAINT PK_ID_BUTACA_SALA PRIMARY KEY (ID_BUTACA_SALA),
CONSTRAINT FK_ID_BUTACA FOREIGN KEY (ID_BUTACA) REFERENCES BUTACA(ID_BUTACA),
CONSTRAINT FK_ID_SALA1 FOREIGN KEY (ID_SALA) REFERENCES SALA(ID_SALA)
)


go
create table TIPO_PROMOCION(
id_tipo_promocion int identity (1,1),
tipo_promocion varchar (50)
constraint pk_tipo_promocion primary key (id_tipo_promocion) 
)
go
create table PROMOCION(
id_promocion int,
promocion int,
id_tipo_promocion int
constraint pk_promocion primary key (id_promocion),
constraint fk_tipo_promocion foreign key (id_tipo_promocion) references TIPO_PROMOCION(id_tipo_promocion)
)
go
create table FACTURA (
id_factura int identity(1,1),
id_vendedor int,
id_cliente int,
fecha_pago datetime,
id_tipo_compra int,
id_forma_pago int,
baja_logica int
constraint pk_factura primary key (id_factura),
constraint fk_vendedor foreign key(id_vendedor) references VENDEDORES (id_vendedor),
constraint fk_cliente foreign key(id_cliente) references CLIENTES (id_cliente),
constraint fk_tipo_compra foreign key(id_tipo_compra) references TIPO_COMPRA (id_tipo_compra),
constraint fk_forma_pago foreign key(id_forma_pago) references FORMA_PAGO (id_forma_pago)
)

CREATE TABLE RESERVA(
id_factura INT IDENTITY(1,1),
FECHA_RESERVA DATETIME,
BAJA_LOGICA bit
CONSTRAINT PK_ID_RESERVA PRIMARY KEY (id_factura),
constraint fk_id_factura1 foreign key (id_factura) references Factura(id_factura)

)
CREATE TABLE FUNCION(
id_funcion int identity(1,1),
fecha datetime,
id_idioma int,
id_pelicula int,
id_sala int,
id_horario int,
monto money,
baja_logica bit
constraint pk_id_funcion primary key (id_funcion, fecha),
constraint fk_id_idioma foreign key (id_idioma) references IDIOMAS(id_idioma),
constraint fk_id_peliculas foreign key (id_pelicula) references PELICULA(id_pelicula),
constraint fk_sala foreign key (id_sala) references SALA (id_sala),
constraint fk_id_horario foreign key (id_horario) references HORARIO (id_horario)
)

go
create table COMPROBANTE(
id_comprobante int identity(1,1),
id_funcion int,
cantidad int,
id_factura int,
monto money,
id_promocion int,
baja_logica bit,
fecha datetime
constraint pk_comprobante primary key(id_comprobante),
constraint fk_id_promocion foreign key(id_promocion) references promocion(id_promocion),
constraint fk_id_factura foreign key (id_factura) references Factura(id_factura),
constraint fk_id_funcion foreign key (id_funcion, fecha) references FUNCION (id_funcion, fecha)
)
go 

create table TICKET(
id_ticket int identity(1,1),
id_comprobante int,
id_butaca_sala int,
id_tipo_publico int,
Baja_logica bit
constraint pk_id_ticket primary key(id_ticket),
constraint fk_id_comprobante foreign key (id_comprobante) references COMPROBANTE (id_comprobante),
constraint fk_id_tipo_publico foreign key (id_tipo_publico) references Tipo_publico(id_tipo_publico),
constraint fk_id_but_sa foreign key (id_butaca_sala) references BUTACA_SALA (id_butaca_sala)
)

create table PELICULA_IDIOMA(
id_idioma int,
id_pelicula int
constraint pk_pelicula_idioma primary key (id_idioma, id_pelicula)
)

insert into RESTRICION_DE_EDAD values(1,13, 'Pueden ingresar únicamente con 13 años cumplidos o en la compañía de Padre, Madre o Tutor.' )
insert into RESTRICION_DE_EDAD values(2,16, 'Pueden ingresar únicamente con 16 años cumplidos o en la compañía de Padre, Madre o Tutor.' )
insert into RESTRICION_DE_EDAD values(3,18, 'Pueden ingresar únicamente con 18 años cumplidos.' )

insert into PRODUCTOR values ('Columbia Pictures.')
insert into PRODUCTOR values ('20th Century-Fox.')
insert into PRODUCTOR values ('Warner Bros.')
insert into PRODUCTOR values ('Paramount Pictures.')
insert into PRODUCTOR values ('Universal Pictures.')
insert into PRODUCTOR values ('Disney.')


/*peliculas*/

insert into Categoria_PELICULA values(1,'Acción',1)
insert into Categoria_PELICULA values(2,'Aventuras',2)
insert into Categoria_PELICULA values(3,'Ciencia Ficción',1)
insert into Categoria_PELICULA values(4,'Comedia',3)
insert into Categoria_PELICULA values(5,'documental',3)
insert into Categoria_PELICULA values(6,'Drama',4)
insert into Categoria_PELICULA values(7,'Musical',2)
insert into Categoria_PELICULA values(8,'Drama',5)
insert into Categoria_PELICULA values(9,'Acción',6)
insert into Categoria_PELICULA values(10,'Acción',7)
insert into Categoria_PELICULA values(11,'Musical',8)
insert into Categoria_PELICULA values(12,'Aventuras',1)
insert into Categoria_PELICULA values(13,'Acción',1)



Insert into IDIOMAS values(1, 'Ingles')
Insert into IDIOMAS values(2, 'Español')
Insert into IDIOMAS values(3, 'Portugues')
Insert into IDIOMAS values(4, 'Italiano')
Insert into IDIOMAS values(5, 'Noruego')
Insert into IDIOMAS values(6, 'Chileno takataka')
Insert into IDIOMAS values(7, 'Ruso')


insert into tipo_de_sala values (1,'3D')
insert into tipo_de_sala values (2,'2D')
insert into tipo_de_sala values (3,'4D')

insert into sala values (1,1)
insert into sala values (2,2)
insert into sala values (3,3)
insert into sala values (4,1)


insert into DIA values (1,'domingo')
insert into DIA values (2,'lunes')
insert into DIA values (3,'martes')
insert into DIA values (4,'miercoles')
insert into DIA values (5,'jueves')
insert into DIA values (6,'viernes')
insert into DIA values (7,'sabado')

insert into tipo_promocion values ('2x1')
insert into tipo_promocion values ('descuento por discapacidad')
insert into tipo_promocion values ('descuento por mayor de edad')
insert into tipo_promocion values ('descuento menor de edad')
insert into tipo_promocion values ('descuento para san valentin')
insert into tipo_promocion values ('descuento para dia del amigo')

insert into promocion values (1,50,1)
insert into promocion values (2,40,4)
insert into promocion values (3,25,3)
insert into promocion values (4,30,5)
insert into promocion values (5,80,2)
insert into promocion values (6,35,6)
--horario 00:00
insert into horario values (1,1,'24')

--horario 1:00
insert into horario values (2,1,'01')

--horario 2:00
insert into horario values (3,1,'02')

--horario  11:00
insert into horario values (4,1,'11')

--horario 12:00
insert into horario values (5,1,'12')

--horario 13:00
insert into horario values (6,1,'13')

--horario 14:00
insert into horario values (7,1,'14')

--horario 15:00
insert into horario values (8,1,'15')

--horario 16:00
insert into horario values (9,1,'16')

--horario 17:00
insert into horario values (10,1,'17')

--horario 18:00
insert into horario values (11,1,'18')

--horario 19:00
insert into horario values (12,1,'19')

--horario 20:00
insert into horario values (13,1,'20')

--horario 21:00
insert into horario values (14,1,'21')

--horario 22:00
insert into horario values (15,1,'22')

--horario 23:00
insert into horario values (16,1,'23')


--PROOVVV

INSERT INTO PROVINCIAS  VALUES(2,'BUENOS AIRES') 
INSERT INTO PROVINCIAS VALUES(3,'CATAMARCA') 
INSERT INTO PROVINCIAS  VALUES(4,'CHACO') 
INSERT INTO PROVINCIAS  VALUES(5,'CHUBUT') 
INSERT INTO PROVINCIAS  VALUES(1,'CORDOBA') 
--LOCALIDAD P1
INSERT INTO LOCALIDADES  VALUES(7,'CORRIENTES',1) 
INSERT INTO LOCALIDADES  VALUES(8,'ENTRE RIOS',1)
INSERT INTO LOCALIDADES  VALUES(9,'FORMOSA',1)
--LOCALIDAD P2
INSERT INTO LOCALIDADES  VALUES(6,'JUJUY',2) 
INSERT INTO LOCALIDADES  VALUES(10,'LA PAMPA',2) 
INSERT INTO LOCALIDADES  VALUES(11,'LA RIOJA',2)
--LOCALIDAD P3
INSERT INTO LOCALIDADES  VALUES(12,'MENDOZA',3) 
INSERT INTO LOCALIDADES  VALUES(13,'MISIONES',3) 
INSERT INTO LOCALIDADES  VALUES(14,'NEUQUEN',3) 
--LOCALIDAD P4
INSERT INTO LOCALIDADES VALUES(15,'RIO NEGRO',4) 
INSERT INTO LOCALIDADES VALUES(16,'SALTA',4) 
INSERT INTO LOCALIDADES VALUES(17,'SAN JUAN',4) 
--LOCALIDAD P5
INSERT INTO LOCALIDADES VALUES(18,'SAN LUIS',5) 
INSERT INTO LOCALIDADES VALUES(19,'SANTA CRUZ',5) 
INSERT INTO LOCALIDADES VALUES(20,'SANTA FE',5) 

--BARRIO L1
INSERT INTO BARRIOS VALUES(1,'CORDOBA',7) 
INSERT INTO BARRIOS VALUES(2,'CARLOS PAZ',7) 
INSERT INTO BARRIOS VALUES(3,'ADELIA MARIA',7) 
INSERT INTO BARRIOS VALUES(4,'ALTA GRACIA',7)
--BARRIO L2
INSERT INTO BARRIOS VALUES(5,'AGUA DE ORO',6) 
INSERT INTO BARRIOS VALUES(6,'AGUA DEL TALA',6) 
INSERT INTO BARRIOS VALUES(7,'AGUA PINTADA',6) 
INSERT INTO BARRIOS VALUES(8,'ALEJANDRO ROCA',6)
--BARRIO L3
INSERT INTO BARRIOS VALUES(9,'ARIAS',12) 
INSERT INTO BARRIOS VALUES(10,'ARROYO CABRAL',12) 
INSERT INTO BARRIOS VALUES(11,'ARROYO LA HIGUERA',12) 
INSERT INTO BARRIOS VALUES(12,'ASCOCHINGA',12)
--BARRIO L4
INSERT INTO BARRIOS VALUES(13,'BAJO DE FERNANDEZ',15) 
INSERT INTO BARRIOS VALUES(14,'BAJO DEL CARMEN',15) 
INSERT INTO BARRIOS VALUES(15,'BAJO GRANDE',15) 
INSERT INTO BARRIOS VALUES(16,'BAJO HONDO',15)
--BARRIO L5
INSERT INTO BARRIOS VALUES (17,'CENTRO',18) 
INSERT INTO BARRIOS VALUES (18,'ALTO ALBERDI',18) 
INSERT INTO BARRIOS VALUES (19,'OBSERVATORIO',18) 
INSERT INTO BARRIOS VALUES (20,'JARDIN',18)
 
-- TIPOS DE CONTACTOS 
insert into  tipos_de_contactos values(1,'Tel_fijo')
insert into  tipos_de_contactos values(2,'Tel_cel') 
insert into  tipos_de_contactos values(3,'e_mail') 

--TIPOS DE DOCUMENTO 
insert into  tipos_de_documentos values(1,'Libreta civica')
insert into  tipos_de_documentos values(2,'Documento Nacional de Identidad')
insert into  tipos_de_documentos values(3,'Cédula de Identidad')
insert into  tipos_de_documentos values(4,'Libreta de Enrolamiento')
--PERSONAS
insert into personas values ('Rodolfo','Perez', 'San Martín', 120,1,1,30511854,'11-06-1994',1 );
insert into personas values ( 'Marta Analía','Castillo','Pedro Lozano',1131,8,2,21410420,'17/05/2005',0)
insert into personas values ( 'Héctor','Abarca','Luis Gongora',472,1,2,26087734,'07/02/1980',1)
insert into personas values ('Santiago','Morales','León y Pizarro',1044,3,4,25021770,'14/08/1973',1)
insert into personas values ( 'Carlos Antonio','Perez','A. Garzón',1989,4,2,26719261,'14/05/1980',1)
insert into personas values ( 'Pilar','Morales','León y Pizarro',1603,1,3,27133184,'24/07/1963',0)
insert into personas values ( 'Roque','Paez','Humberto Primo',170,2,1,38677304,'31/03/1968',1)
insert into personas values ( 'Elvira Josefa','Luque','Mariano Usandivaras',1310,9,3,38055934,'16/12/1997',0)
insert into personas  values ( 'Marcos','Ruiz','Rivera Indarte',386,1,2,33681983,'02/02/1997',1)
insert into personas  values ( 'Roberto','Moriel','Santa Rosa',1558,7,4,20481649,'07/02/1992',1)
insert into personas  values ( 'Ana María','Perez','Av. Colón',1431,6,4,23577422,'09/03/1976',0)
insert into personas  values ( 'Adriana','Gonzalez','San Jerónimo',832,1,4,34532656,'07/12/1972',0)
insert into personas  values ( 'Juana','Moralez','Salamanca',864,5,1,28721223,'08/07/1986',0)
insert into personas  values ( 'Sofía','Ariza','Derqui',1545,3,3,36600877,'25/04/1982',0)
insert into personas  values ( 'Matias','Angellozzi','Ituzaingó',1182,8,2,20407242,'16/01/1973',1)
insert into personas  values ( 'Martín','Carrizo','San Lorenzo',1661,7,2,32649904,'23/10/1994',1)
insert into personas  values ( 'Mariela','Ledesma','Chachapoyas',152,5,2,27533330,'24/03/2001',0)
insert into personas  values ( 'Alejandro','Lopez','Alsina',1619,1,2,31182600,'14/04/1985',1)
insert into personas  values ( 'Marcelo','Miranda','Rivera Indarte',1593,7,2,25808641,'07/08/1988',1)
insert into personas  values ( 'Gabriel','Monti','Altoaguirre',1162,2,4,20145878,'15/05/1980',1)
insert into personas  values ('Susana','Juarez','Antofagasta',803,6,4,29582832,'01/12/1999',2)
INSERT INTO personas  VALUES ('CRISTINA','ALVAREZ','Antofagasta',882,1,2,24352243,'30/01/1968',0)
INSERT INTO personas  VALUES ('CLAUDIO','ALVAREZ', 'Mariano Usandivaras',1347,4,2,25029385,'23/05/1960',1)
INSERT INTO personas  VALUES ('RAUL','CAMPOS', 'Santa Rosa',537,1,1,21037858,'05/12/1973',1)
INSERT INTO personas  VALUES ('CARLA','DURAN','León y Pizarro',803,2,1,23775237,'20/12/1993',0)
INSERT INTO personas  VALUES ('MARIA','PEREZ','Antofagasta',1116,5,3,21152041,'19/07/1987',0)
INSERT INTO personas  VALUES ('CARLOS LUIS','ZAMORA','Rivera Indarte',1467,6,4,35149772,'28/02/1993',1)

Insert into Tipo_Compra values('Presencial')
Insert into Tipo_Compra values('Online')

Insert into FORMA_PAGO values(1,'Efectivo')
Insert into FORMA_PAGO values(2,'Credito 1 cuota')
Insert into FORMA_PAGO values(3,'Credito 3 cuotas')
Insert into FORMA_PAGO values(4,'Credito 6 cuotas')
Insert into FORMA_PAGO values(5,'Credito 12 cuotas')
Insert into FORMA_PAGO values(6,'Debito')

Insert into Clientes values (10,1)
Insert into Clientes values (11,1)
Insert into Clientes values (12,1)
Insert into Clientes values (13,1)
Insert into Clientes values (14,1)
Insert into Clientes values (15,1)
Insert into Clientes values (16,1)
Insert into Clientes values (17,0)
Insert into Clientes values (18,1)
Insert into Clientes values (19,1)
Insert into Clientes values (20,1)
Insert into Clientes values (21,1)
Insert into Clientes values (22,0)
Insert into Clientes values (23,0)
Insert into Clientes values (24,1)
Insert into Clientes values (25,1)
Insert into Clientes values (26,1)

Insert into Vendedores values (1,'roldofito332','Helado',1)
Insert into Vendedores values (2,'Martitta03','Escalope',0)
Insert into Vendedores values (3,'hectorsalamanca','Hector3332',1)
Insert into Vendedores values (4,'SantiJ','Gokulegana',1)
Insert into Vendedores values (5,'Carlo','Carlo',1)
Insert into Vendedores values (6,'Pilar3','Pillarelhighground',1)
Insert into Vendedores values (7,'Roque','Dique',0)
Insert into Vendedores values (8,'Elvi','ra',1)
Insert into Vendedores values (9,'Marco','calabazaconqueso',1)
--Butacas
insert into BUTACA values (1,'A',1)
insert into BUTACA values (2,'A',2)
insert into BUTACA values (3,'A',3)
insert into BUTACA values (4,'A',4)
insert into BUTACA values (5,'A',5)
insert into BUTACA values (6,'B',1)
insert into BUTACA values (7,'B',2)
insert into BUTACA values (8,'B',3)
insert into BUTACA values (9,'B',4)
insert into BUTACA values (10,'B',5)
insert into BUTACA values (11,'C',1)
insert into BUTACA values (12,'C',2)
insert into BUTACA values (13,'C',3)
insert into BUTACA values (14,'C',4)
insert into BUTACA values (15,'C',5)
insert into BUTACA values (16,'D',1)
insert into BUTACA values (17,'D',2)
insert into BUTACA values (18,'D',3)
insert into BUTACA values (19,'D',4)
insert into BUTACA values (20,'D',5)
insert into BUTACA values (21,'E',1)
insert into BUTACA values (22,'E',2)
insert into BUTACA values (23,'E',3)
insert into BUTACA values (24,'E',4)
insert into BUTACA values (25,'E',5)
insert into BUTACA values (26,'F',1)
insert into BUTACA values (27,'F',2)
insert into BUTACA values (28,'F',3)
insert into BUTACA values (29,'F',4)
insert into BUTACA values (30,'F',5)
insert into BUTACA values (31,'G',1)
insert into BUTACA values (32,'G',2)
insert into BUTACA values (33,'G',3)
insert into BUTACA values (34,'G',4)
insert into BUTACA values (35,'G',5)
insert into BUTACA values (36,'H',1)
insert into BUTACA values (37,'H',2)
insert into BUTACA values (38,'H',3)
insert into BUTACA values (39,'H',4)
insert into BUTACA values (40,'H',5)
insert into BUTACA values (41,'I',1)
insert into BUTACA values (42,'I',2)
insert into BUTACA values (43,'I',3)
insert into BUTACA values (44,'I',4)
insert into BUTACA values (45,'I',5)

/*SALA 1*/
insert into BUTACA_SALA values (1,1)
insert into BUTACA_SALA values (2,1)
insert into BUTACA_SALA values (3,1)
insert into BUTACA_SALA values (4,1)
insert into BUTACA_SALA values (5,1)
insert into BUTACA_SALA values (6,1)
insert into BUTACA_SALA values (7,1)
insert into BUTACA_SALA values (8,1)
insert into BUTACA_SALA values (9,1)
insert into BUTACA_SALA values (10,1)
insert into BUTACA_SALA values (11,1)
insert into BUTACA_SALA values (12,1)
insert into BUTACA_SALA values (13,1)
insert into BUTACA_SALA values (14,1)
insert into BUTACA_SALA values (15,1)
insert into BUTACA_SALA values (16,1)
insert into BUTACA_SALA values (17,1)
insert into BUTACA_SALA values (18,1)
insert into BUTACA_SALA values (19,1)
insert into BUTACA_SALA values (20,1)
insert into BUTACA_SALA values (21,1)
insert into BUTACA_SALA values (22,1)
insert into BUTACA_SALA values (23,1)
insert into BUTACA_SALA values (24,1)
insert into BUTACA_SALA values (25,1)
insert into BUTACA_SALA values (26,1)
insert into BUTACA_SALA values (27,1)
insert into BUTACA_SALA values (28,1)
insert into BUTACA_SALA values (29,1)
insert into BUTACA_SALA values (30,1)
insert into BUTACA_SALA values (31,1)
insert into BUTACA_SALA values (32,1)
insert into BUTACA_SALA values (33,1)
insert into BUTACA_SALA values (34,1)
insert into BUTACA_SALA values (35,1)
insert into BUTACA_SALA values (36,1)
insert into BUTACA_SALA values (37,1)
insert into BUTACA_SALA values (38,1)
insert into BUTACA_SALA values (39,1)
insert into BUTACA_SALA values (40,1)
insert into BUTACA_SALA values (41,1)
insert into BUTACA_SALA values (42,1)
insert into BUTACA_SALA values (43,1)
insert into BUTACA_SALA values (44,1)
insert into BUTACA_SALA values (45,1)
/*SALA 2*/
insert into BUTACA_SALA values (1,2)
insert into BUTACA_SALA values (2,2)
insert into BUTACA_SALA values (3,2)
insert into BUTACA_SALA values (4,2)
insert into BUTACA_SALA values (5,2)
insert into BUTACA_SALA values (6,2)
insert into BUTACA_SALA values (7,2)
insert into BUTACA_SALA values (8,2)
insert into BUTACA_SALA values (9,2)
insert into BUTACA_SALA values (10,2)
insert into BUTACA_SALA values (11,2)
insert into BUTACA_SALA values (12,2)
insert into BUTACA_SALA values (13,2)
insert into BUTACA_SALA values (14,2)
insert into BUTACA_SALA values (15,2)
insert into BUTACA_SALA values (16,2)
insert into BUTACA_SALA values (17,2)
insert into BUTACA_SALA values (18,2)
insert into BUTACA_SALA values (19,2)
insert into BUTACA_SALA values (20,2)
insert into BUTACA_SALA values (21,2)
insert into BUTACA_SALA values (22,2)
insert into BUTACA_SALA values (23,2)
insert into BUTACA_SALA values (24,2)
insert into BUTACA_SALA values (25,2)
insert into BUTACA_SALA values (26,2)
insert into BUTACA_SALA values (27,2)
insert into BUTACA_SALA values (28,2)
insert into BUTACA_SALA values (29,2)
insert into BUTACA_SALA values (30,2)
insert into BUTACA_SALA values (31,2)
insert into BUTACA_SALA values (32,2)
insert into BUTACA_SALA values (33,2)
insert into BUTACA_SALA values (34,2)
insert into BUTACA_SALA values (35,2)
insert into BUTACA_SALA values (36,2)
insert into BUTACA_SALA values (37,2)
insert into BUTACA_SALA values (38,2)
insert into BUTACA_SALA values (39,2)
insert into BUTACA_SALA values (40,2)
insert into BUTACA_SALA values (41,2)
insert into BUTACA_SALA values (42,2)
insert into BUTACA_SALA values (43,2)
insert into BUTACA_SALA values (44,2)
insert into BUTACA_SALA values (45,2)

/*sala 3*/
insert into BUTACA_SALA values (1,3)
insert into BUTACA_SALA values (2,3)
insert into BUTACA_SALA values (3,3)
insert into BUTACA_SALA values (4,3)
insert into BUTACA_SALA values (5,3)
insert into BUTACA_SALA values (6,3)
insert into BUTACA_SALA values (7,3)
insert into BUTACA_SALA values (8,3)
insert into BUTACA_SALA values (9,3)
insert into BUTACA_SALA values (10,3)
insert into BUTACA_SALA values (11,3)
insert into BUTACA_SALA values (12,3)
insert into BUTACA_SALA values (13,3)
insert into BUTACA_SALA values (14,3)
insert into BUTACA_SALA values (15,3)
insert into BUTACA_SALA values (16,3)
insert into BUTACA_SALA values (17,3)
insert into BUTACA_SALA values (18,3)
insert into BUTACA_SALA values (19,3)
insert into BUTACA_SALA values (20,3)
insert into BUTACA_SALA values (21,3)
insert into BUTACA_SALA values (22,3)
insert into BUTACA_SALA values (23,3)
insert into BUTACA_SALA values (24,3)
insert into BUTACA_SALA values (25,3)
insert into BUTACA_SALA values (26,3)
insert into BUTACA_SALA values (27,3)
insert into BUTACA_SALA values (28,3)
insert into BUTACA_SALA values (29,3)
insert into BUTACA_SALA values (30,3)
insert into BUTACA_SALA values (31,3)
insert into BUTACA_SALA values (32,3)
insert into BUTACA_SALA values (33,3)
insert into BUTACA_SALA values (34,3)
insert into BUTACA_SALA values (35,3)
insert into BUTACA_SALA values (36,3)
insert into BUTACA_SALA values (37,3)
insert into BUTACA_SALA values (38,3)
insert into BUTACA_SALA values (39,3)
insert into BUTACA_SALA values (40,3)
insert into BUTACA_SALA values (41,3)
insert into BUTACA_SALA values (42,3)
insert into BUTACA_SALA values (43,3)
insert into BUTACA_SALA values (44,3)
insert into BUTACA_SALA values (45,3)

/*sala 4*/
insert into BUTACA_SALA values (1,4)
insert into BUTACA_SALA values (2,4)
insert into BUTACA_SALA values (3,4)
insert into BUTACA_SALA values (4,4)
insert into BUTACA_SALA values (5,4)
insert into BUTACA_SALA values (6,4)
insert into BUTACA_SALA values (7,4)
insert into BUTACA_SALA values (8,4)
insert into BUTACA_SALA values (9,4)
insert into BUTACA_SALA values (10,4)
insert into BUTACA_SALA values (11,4)
insert into BUTACA_SALA values (12,4)
insert into BUTACA_SALA values (13,4)
insert into BUTACA_SALA values (14,4)
insert into BUTACA_SALA values (15,4)
insert into BUTACA_SALA values (16,4)
insert into BUTACA_SALA values (17,4)
insert into BUTACA_SALA values (18,4)
insert into BUTACA_SALA values (19,4)
insert into BUTACA_SALA values (20,4)
insert into BUTACA_SALA values (21,4)
insert into BUTACA_SALA values (22,4)
insert into BUTACA_SALA values (23,4)
insert into BUTACA_SALA values (24,4)
insert into BUTACA_SALA values (25,4)
insert into BUTACA_SALA values (26,4)
insert into BUTACA_SALA values (27,4)
insert into BUTACA_SALA values (28,4)
insert into BUTACA_SALA values (29,4)
insert into BUTACA_SALA values (30,4)
insert into BUTACA_SALA values (31,4)
insert into BUTACA_SALA values (32,4)
insert into BUTACA_SALA values (33,4)
insert into BUTACA_SALA values (34,4)
insert into BUTACA_SALA values (35,4)
insert into BUTACA_SALA values (36,4)
insert into BUTACA_SALA values (37,4)
insert into BUTACA_SALA values (38,4)
insert into BUTACA_SALA values (39,4)
insert into BUTACA_SALA values (40,4)
insert into BUTACA_SALA values (41,4)
insert into BUTACA_SALA values (42,4)
insert into BUTACA_SALA values (43,4)
insert into BUTACA_SALA values (44,4)
insert into BUTACA_SALA values (45,4)



insert into FACTURA values(8,11,'1/1/2022',2,5,1)
insert into FACTURA values(1,8,'1/1/2022',2,6,1)
insert into FACTURA values(9,8,'2/1/2022',2,2,1)
insert into FACTURA values(6,15,'3/1/2022',2,2,1)
insert into FACTURA values(5,8,'3/1/2022',2,5,1)
insert into FACTURA values(6,17,'4/1/2022',2,2,1)
insert into FACTURA values(4,10,'5/1/2022',2,5,1)
insert into FACTURA values(5,8,'5/1/2022',1,6,1)
insert into FACTURA values(3,16,'6/1/2022',2,3,1)
insert into FACTURA values(5,1,'7/1/2022',2,5,1)
insert into FACTURA values(8,3,'11/1/2022',1,4,1)
insert into FACTURA values(2,12,'11/1/2022',2,4,1)
insert into FACTURA values(6,9,'12/1/2022',1,2,1)
insert into FACTURA values(6,6,'13/1/2022',1,5,1)
insert into FACTURA values(4,1,'13/1/2022',2,2,1)
insert into FACTURA values(1,17,'14/1/2022',1,3,1)
insert into FACTURA values(3,10,'15/1/2022',1,3,1)
insert into FACTURA values(2,3,'15/1/2022',1,1,1)
insert into FACTURA values(2,2,'16/1/2022',1,3,1)
insert into FACTURA values(1,1,'17/1/2022',1,2,1)
insert into FACTURA values(6,1,'17/1/2022',1,5,1)
insert into FACTURA values(4,7,'25/1/2022',1,4,1)
insert into FACTURA values(7,5,'26/1/2022',2,1,1)
insert into FACTURA values(6,14,'27/1/2022',1,6,1)
insert into FACTURA values(7,8,'27/1/2022',1,3,1)
insert into FACTURA values(3,2,'28/1/2022',1,5,1)
insert into FACTURA values(5,4,'29/1/2022',2,5,1)
insert into FACTURA values(9,10,'29/1/2022',2,2,1)
insert into FACTURA values(1,4,'30/1/2022',2,3,1)
insert into FACTURA values(3,14,'31/1/2022',2,1,1)
insert into FACTURA values(5,12,'31/1/2022',1,2,1)
insert into FACTURA values(8,1,'4/2/2022',1,3,1)
insert into FACTURA values(2,3,'5/2/2022',1,4,1)
insert into FACTURA values(1,1,'5/2/2022',2,1,1)
insert into FACTURA values(7,17,'6/2/2022',2,2,1)
insert into FACTURA values(5,7,'7/2/2022',2,6,1)
insert into FACTURA values(7,5,'7/2/2022',2,4,1)
insert into FACTURA values(7,14,'8/2/2022',2,4,1)
insert into FACTURA values(1,8,'9/2/2022',1,1,1)
insert into FACTURA values(9,11,'9/2/2022',1,5,1)
insert into FACTURA values(1,5,'1/2/2022',2,2,1)
insert into FACTURA values(5,1,'1/2/2022',2,1,1)
insert into FACTURA values(7,10,'2/2/2022',2,4,1)
insert into FACTURA values(5,14,'3/2/2022',2,2,1)
insert into FACTURA values(4,4,'3/2/2022',2,6,1)
insert into FACTURA values(5,13,'4/2/2022',1,6,1)
insert into FACTURA values(9,1,'5/2/2022',1,6,1)
insert into FACTURA values(4,4,'5/2/2022',1,5,1)
insert into FACTURA values(8,16,'6/2/2022',2,6,1)
insert into FACTURA values(1,3,'7/2/2022',2,3,1)
insert into FACTURA values(2,14,'14/3/2022',2,5,1)
insert into FACTURA values(1,5,'15/3/2022',2,4,1)
insert into FACTURA values(4,1,'16/3/2022',1,6,1)
insert into FACTURA values(9,9,'16/3/2022',2,1,1)
insert into FACTURA values(7,15,'17/3/2022',1,5,1)
insert into FACTURA values(3,5,'18/3/2022',1,6,1)
insert into FACTURA values(8,14,'18/3/2022',2,2,1)
insert into FACTURA values(5,15,'19/3/2022',2,5,1)
insert into FACTURA values(2,4,'20/3/2022',2,4,1)
insert into FACTURA values(2,4,'20/3/2022',2,5,1)
insert into FACTURA values(6,14,'8/3/2022',2,6,1)
insert into FACTURA values(8,3,'8/3/2022',1,3,1)
insert into FACTURA values(8,16,'9/3/2022',1,6,1)
insert into FACTURA values(2,15,'10/3/2022',1,5,1)
insert into FACTURA values(3,12,'10/3/2022',2,3,1)
insert into FACTURA values(5,13,'11/3/2022',1,5,1)
insert into FACTURA values(4,15,'12/3/2022',1,6,1)
insert into FACTURA values(7,7,'12/3/2022',2,3,1)
insert into FACTURA values(1,4,'13/3/2022',1,1,1)
insert into FACTURA values(8,11,'14/3/2022',1,6,1)
insert into FACTURA values(2,11,'25/4/2022',1,1,1)
insert into FACTURA values(1,9,'26/4/2022',2,1,1)
insert into FACTURA values(1,4,'26/4/2022',2,2,1)
insert into FACTURA values(5,2,'27/4/2022',1,1,1)
insert into FACTURA values(1,8,'28/4/2022',2,6,1)
insert into FACTURA values(5,10,'28/4/2022',2,3,1)
insert into FACTURA values(4,4,'29/4/2022',1,3,1)
insert into FACTURA values(4,3,'30/4/2022',2,4,1)
insert into FACTURA values(3,5,'30/4/2022',2,4,1)
insert into FACTURA values(7,4,'1/4/2022',2,1,1)
insert into FACTURA values(9,4,'2/4/2022',2,3,1)
insert into FACTURA values(1,3,'2/4/2022',2,5,1)
insert into FACTURA values(3,9,'3/4/2022',1,6,1)
insert into FACTURA values(8,8,'4/4/2022',2,4,1)
insert into FACTURA values(4,9,'4/4/2022',2,6,1)
insert into FACTURA values(5,9,'5/4/2022',1,5,1)
insert into FACTURA values(5,7,'6/4/2022',1,5,1)
insert into FACTURA values(3,10,'6/4/2022',1,3,1)
insert into FACTURA values(5,11,'7/4/2022',1,2,1)
insert into FACTURA values(7,5,'8/4/2022',1,6,1)
insert into FACTURA values(3,17,'8/6/2022',1,4,1)
insert into FACTURA values(9,1,'9/6/2022',2,5,1)
insert into FACTURA values(4,11,'9/6/2022',2,5,1)
insert into FACTURA values(5,10,'10/6/2022',2,5,1)
insert into FACTURA values(6,1,'11/6/2022',2,3,1)
insert into FACTURA values(8,12,'11/6/2022',1,2,1)
insert into FACTURA values(6,16,'12/6/2022',2,6,1)
insert into FACTURA values(7,5,'13/6/2022',2,1,1)
insert into FACTURA values(1,16,'13/6/2022',1,4,1)
insert into FACTURA values(2,4,'14/6/2022',2,1,1)
insert into FACTURA values(1,17,'15/6/2022',1,3,1)
insert into FACTURA values(5,9,'15/6/2022',1,3,1)
insert into FACTURA values(8,4,'16/6/2022',2,3,1)
insert into FACTURA values(4,4,'17/6/2022',2,3,1)
insert into FACTURA values(4,15,'17/6/2022',1,4,1)
insert into FACTURA values(5,14,'18/6/2022',2,5,1)
insert into FACTURA values(2,1,'19/6/2022',2,5,1)
insert into FACTURA values(3,8,'19/6/2022',1,5,1)
insert into FACTURA values(5,16,'20/6/2022',1,6,1)
insert into FACTURA values(5,14,'21/6/2022',1,2,1)
insert into FACTURA values(2,11,'12/6/2022',2,3,1)
insert into FACTURA values(4,6,'12/6/2022',1,4,1)
insert into FACTURA values(2,3,'13/6/2022',2,3,1)
insert into FACTURA values(1,6,'14/6/2022',2,4,1)
insert into FACTURA values(3,16,'14/6/2022',1,5,1)
insert into FACTURA values(4,6,'15/6/2022',1,6,1)
insert into FACTURA values(6,13,'16/6/2022',2,1,1)
insert into FACTURA values(9,12,'16/6/2022',1,6,1)
insert into FACTURA values(7,10,'17/6/2022',1,1,1)
insert into FACTURA values(6,10,'18/6/2022',2,2,1)
insert into FACTURA values(3,14,'1/7/2022',1,2,1)
insert into FACTURA values(7,11,'1/7/2022',1,4,1)
insert into FACTURA values(8,5,'2/7/2022',2,3,1)
insert into FACTURA values(7,2,'3/7/2022',1,4,1)
insert into FACTURA values(1,11,'3/7/2022',2,5,1)
insert into FACTURA values(4,13,'4/7/2022',1,4,1)
insert into FACTURA values(7,8,'5/7/2022',1,6,1)
insert into FACTURA values(5,17,'5/7/2022',1,5,1)
insert into FACTURA values(5,4,'6/7/2022',1,6,1)
insert into FACTURA values(1,17,'7/7/2022',2,6,1)
insert into FACTURA values(1,12,'1/7/2022',1,2,1)
insert into FACTURA values(1,10,'1/7/2022',2,5,1)
insert into FACTURA values(4,14,'2/7/2022',1,3,1)
insert into FACTURA values(3,17,'3/7/2022',1,4,1)
insert into FACTURA values(1,11,'3/7/2022',1,4,1)
insert into FACTURA values(1,11,'4/7/2022',1,5,1)
insert into FACTURA values(3,9,'5/7/2022',1,1,1)
insert into FACTURA values(5,2,'5/7/2022',1,3,1)
insert into FACTURA values(8,13,'6/7/2022',2,6,1)
insert into FACTURA values(5,15,'7/7/2022',1,2,1)
insert into FACTURA values(6,14,'7/7/2022',2,6,1)
insert into FACTURA values(1,4,'8/7/2022',1,1,1)
insert into FACTURA values(3,11,'9/7/2022',1,4,1)
insert into FACTURA values(3,11,'9/7/2022',1,5,1)
insert into FACTURA values(7,16,'10/7/2022',2,6,1)
insert into FACTURA values(5,1,'11/7/2022',2,1,1)
insert into FACTURA values(9,8,'11/7/2022',2,1,1)
insert into FACTURA values(1,3,'12/7/2022',2,2,1)
insert into FACTURA values(6,3,'13/7/2022',2,3,1)
insert into FACTURA values(7,16,'13/7/2022',2,6,1)
insert into FACTURA values(3,7,'14/7/2022',1,3,1)
insert into FACTURA values(9,8,'15/7/2022',1,5,1)
insert into FACTURA values(2,17,'15/7/2022',2,2,1)
insert into FACTURA values(6,10,'16/7/2022',2,1,1)
insert into FACTURA values(6,15,'17/7/2022',2,5,1)
insert into FACTURA values(7,15,'17/7/2022',2,3,1)
insert into FACTURA values(4,2,'18/7/2022',2,1,1)
insert into FACTURA values(9,11,'19/7/2022',2,5,1)
insert into FACTURA values(5,13,'19/7/2022',2,6,1)
insert into FACTURA values(3,5,'20/7/2022',1,2,1)
insert into FACTURA values(6,10,'21/7/2022',1,4,1)
insert into FACTURA values(2,5,'21/7/2022',2,2,1)
insert into FACTURA values(4,4,'22/7/2022',1,3,1)
insert into FACTURA values(1,14,'23/7/2022',1,6,1)
insert into FACTURA values(3,7,'23/7/2022',2,6,1)
insert into FACTURA values(2,9,'24/7/2022',1,5,1)
insert into FACTURA values(8,14,'25/7/2022',1,5,1)
insert into FACTURA values(8,3,'25/7/2022',1,3,1)
insert into FACTURA values(6,3,'26/7/2022',2,3,1)
insert into FACTURA values(3,14,'27/7/2022',1,5,1)
insert into FACTURA values(8,13,'27/7/2022',2,6,1)
insert into FACTURA values(4,7,'28/7/2022',1,2,1)
insert into FACTURA values(8,14,'29/7/2022',2,4,1)
insert into FACTURA values(5,12,'29/7/2022',1,2,1)
insert into FACTURA values(9,10,'30/7/2022',2,5,1)
insert into FACTURA values(8,17,'1/8/2022',1,4,1)
insert into FACTURA values(5,5,'1/8/2022',2,1,1)
insert into FACTURA values(9,16,'2/8/2022',2,2,1)
insert into FACTURA values(1,11,'3/8/2022',2,6,1)
insert into FACTURA values(4,9,'3/8/2022',2,3,1)
insert into FACTURA values(2,2,'4/8/2022',1,1,1)
insert into FACTURA values(2,6,'5/8/2022',2,4,1)
insert into FACTURA values(8,15,'5/8/2022',2,5,1)
insert into FACTURA values(1,12,'6/8/2022',1,2,1)
insert into FACTURA values(3,12,'7/8/2022',2,5,1)
insert into FACTURA values(4,2,'7/8/2022',2,4,1)
insert into FACTURA values(4,12,'8/8/2022',1,2,1)
insert into FACTURA values(6,8,'9/8/2022',1,5,1)
insert into FACTURA values(8,4,'9/8/2022',2,1,1)
insert into FACTURA values(2,17,'10/8/2022',2,4,1)
insert into FACTURA values(9,14,'11/8/2022',2,2,1)
insert into FACTURA values(9,8,'11/8/2022',1,2,1)
insert into FACTURA values(9,1,'12/8/2022',2,1,1)
insert into FACTURA values(5,1,'13/8/2022',2,6,1)
insert into FACTURA values(8,7,'13/8/2022',1,1,1)
insert into FACTURA values(7,17,'25/10/2022',1,4,1)
insert into FACTURA values(5,4,'26/10/2022',1,3,1)
insert into FACTURA values(4,9,'26/10/2022',1,5,1)
insert into FACTURA values(3,12,'27/10/2022',2,1,1)
insert into FACTURA values(7,6,'28/10/2022',1,5,1)
insert into FACTURA values(3,17,'28/10/2022',2,4,1)
insert into FACTURA values(1,4,'29/10/2022',2,1,1)
insert into FACTURA values(5,9,'30/10/2022',1,4,1)
insert into FACTURA values(3,9,'30/10/2022',1,2,1)
insert into FACTURA values(8,5,'31/10/2022',2,4,1)
insert into FACTURA values(7,9,'3/11/2022',2,1,1)
insert into FACTURA values(7,10,'4/11/2022',2,5,1)
insert into FACTURA values(8,16,'5/11/2022',2,4,1)
insert into FACTURA values(3,4,'5/11/2022',2,5,1)
insert into FACTURA values(6,9,'6/11/2022',2,6,1)
insert into FACTURA values(9,5,'7/11/2022',1,4,1)
insert into FACTURA values(5,11,'7/11/2022',2,2,1)
insert into FACTURA values(2,15,'8/11/2022',2,5,1)
insert into FACTURA values(1,4,'9/11/2022',1,1,1)
insert into FACTURA values(3,15,'9/11/2022',1,3,1)
insert into FACTURA values(5,17,'10/11/2022',1,6,1)
insert into FACTURA values(4,17,'11/11/2022',1,5,1)
insert into FACTURA values(1,15,'11/11/2022',1,3,1)
insert into FACTURA values(2,15,'12/11/2022',1,3,1)
insert into FACTURA values(5,14,'13/11/2022',2,1,1)
insert into FACTURA values(2,3,'13/11/2022',1,1,1)
insert into FACTURA values(4,7,'14/11/2022',2,4,1)
insert into FACTURA values(1,5,'15/11/2022',1,2,1)
insert into FACTURA values(5,12,'15/11/2022',2,1,1)
insert into FACTURA values(6,4,'16/11/2022',2,6,1)

insert into COMPROBANTE values (1,3,1,500,5,1,'01/01/2022')
insert into COMPROBANTE values (2,2,1,500,3,1,'01/01/2022')
insert into COMPROBANTE values (3,3,2,600,1,1,'01/01/2022')
insert into COMPROBANTE values (4,1,2,600,1,1,'02/01/2022')
insert into COMPROBANTE values (5,2,3,600,2,1,'02/01/2022')
insert into COMPROBANTE values (6,3,3,600,6,1,'02/01/2022')
insert into COMPROBANTE values (7,3,4,600,4,1,'03/01/2022')
insert into COMPROBANTE values (8,2,4,500,5,1,'03/01/2022')
insert into COMPROBANTE values (9,3,5,700,2,1,'03/01/2022')
insert into COMPROBANTE values (10,1,5,700,1,1,'04/01/2022')
insert into COMPROBANTE values (11,2,6,600,3,1,'04/01/2022')
insert into COMPROBANTE values (12,1,6,600,1,1,'04/01/2022')
insert into COMPROBANTE values (13,1,7,600,3,1,'05/01/2022')
insert into COMPROBANTE values (14,2,7,600,3,1,'05/01/2022')
insert into COMPROBANTE values (15,2,8,600,1,1,'05/01/2022')
insert into COMPROBANTE values (16,2,8,600,5,1,'06/01/2022')
insert into COMPROBANTE values (17,2,9,700,6,1,'06/01/2022')
insert into COMPROBANTE values (18,1,9,600,5,1,'06/01/2022')
insert into COMPROBANTE values (19,1,10,600,3,1,'07/01/2022')
insert into COMPROBANTE values (20,2,10,600,2,1,'07/01/2022')
insert into COMPROBANTE values (31,3,11,500,5,1,'11/01/2022')
insert into COMPROBANTE values (32,3,11,500,4,1,'11/01/2022')
insert into COMPROBANTE values (33,1,12,600,5,1,'11/01/2022')
insert into COMPROBANTE values (34,1,12,600,5,1,'12/01/2022')
insert into COMPROBANTE values (35,3,13,700,1,1,'12/01/2022')
insert into COMPROBANTE values (36,1,13,600,5,1,'12/01/2022')
insert into COMPROBANTE values (37,3,14,600,2,1,'13/01/2022')
insert into COMPROBANTE values (38,1,14,600,2,1,'13/01/2022')
insert into COMPROBANTE values (39,1,15,600,6,1,'13/01/2022')
insert into COMPROBANTE values (40,2,15,600,4,1,'14/01/2022')
insert into COMPROBANTE values (41,3,16,700,1,1,'14/01/2022')
insert into COMPROBANTE values (42,1,16,600,5,1,'14/01/2022')
insert into COMPROBANTE values (43,3,17,600,2,1,'15/01/2022')
insert into COMPROBANTE values (44,2,17,600,1,1,'15/01/2022')
insert into COMPROBANTE values (45,2,18,700,5,1,'15/01/2022')
insert into COMPROBANTE values (46,3,18,600,1,1,'16/01/2022')
insert into COMPROBANTE values (47,2,19,600,3,1,'16/01/2022')
insert into COMPROBANTE values (48,1,19,500,4,1,'16/01/2022')
insert into COMPROBANTE values (49,1,20,500,3,1,'17/01/2022')
insert into COMPROBANTE values (50,1,20,700,4,1,'17/01/2022')
insert into COMPROBANTE values (51,2,21,500,4,1,'17/01/2022')
insert into COMPROBANTE values (74,2,21,700,2,1,'25/01/2022')
insert into COMPROBANTE values (75,3,22,600,6,1,'25/01/2022')
insert into COMPROBANTE values (76,2,22,700,6,1,'26/01/2022')
insert into COMPROBANTE values (77,2,23,600,4,1,'26/01/2022')
insert into COMPROBANTE values (78,3,23,700,5,1,'26/01/2022')
insert into COMPROBANTE values (79,1,24,500,3,1,'27/01/2022')
insert into COMPROBANTE values (80,1,24,600,5,1,'27/01/2022')
insert into COMPROBANTE values (81,1,25,600,3,1,'27/01/2022')
insert into COMPROBANTE values (82,2,25,700,3,1,'28/01/2022')
insert into COMPROBANTE values (83,3,26,600,4,1,'28/01/2022')
insert into COMPROBANTE values (84,1,26,700,4,1,'28/01/2022')
insert into COMPROBANTE values (85,1,27,600,4,1,'29/01/2022')
insert into COMPROBANTE values (86,1,27,600,4,1,'29/01/2022')
insert into COMPROBANTE values (87,1,28,600,5,1,'29/01/2022')
insert into COMPROBANTE values (88,3,28,600,4,1,'30/01/2022')
insert into COMPROBANTE values (89,2,29,500,3,1,'30/01/2022')
insert into COMPROBANTE values (90,3,29,600,4,1,'30/01/2022')
insert into COMPROBANTE values (91,2,30,500,4,1,'31/01/2022')
insert into COMPROBANTE values (92,3,30,500,5,1,'31/01/2022')
insert into COMPROBANTE values (93,1,31,600,3,1,'31/01/2022')
insert into COMPROBANTE values (382,1,31,600,6,1,'04/02/2022')
insert into COMPROBANTE values (383,1,32,700,5,1,'04/02/2022')
insert into COMPROBANTE values (384,3,32,600,4,1,'04/02/2022')
insert into COMPROBANTE values (385,2,33,600,1,1,'05/02/2022')
insert into COMPROBANTE values (386,3,33,700,3,1,'05/02/2022')
insert into COMPROBANTE values (387,2,34,700,4,1,'05/02/2022')
insert into COMPROBANTE values (388,1,34,700,6,1,'06/02/2022')
insert into COMPROBANTE values (389,3,35,600,5,1,'06/02/2022')
insert into COMPROBANTE values (390,3,35,600,1,1,'06/02/2022')
insert into COMPROBANTE values (391,1,36,700,6,1,'07/02/2022')
insert into COMPROBANTE values (392,1,36,600,2,1,'07/02/2022')
insert into COMPROBANTE values (393,3,37,500,2,1,'07/02/2022')
insert into COMPROBANTE values (394,1,37,700,4,1,'08/02/2022')
insert into COMPROBANTE values (395,1,38,600,6,1,'08/02/2022')
insert into COMPROBANTE values (396,3,38,600,6,1,'08/02/2022')
insert into COMPROBANTE values (397,1,39,600,4,1,'09/02/2022')
insert into COMPROBANTE values (398,3,39,700,2,1,'09/02/2022')
insert into COMPROBANTE values (399,2,40,500,4,1,'09/02/2022')
insert into COMPROBANTE values (400,3,40,700,1,1,'10/02/2022')
insert into COMPROBANTE values (457,1,41,600,6,1,'01/02/2022')
insert into COMPROBANTE values (458,1,41,600,3,1,'01/02/2022')
insert into COMPROBANTE values (459,3,42,600,1,1,'01/02/2022')
insert into COMPROBANTE values (460,1,42,600,6,1,'02/02/2022')
insert into COMPROBANTE values (461,3,43,700,3,1,'02/02/2022')
insert into COMPROBANTE values (462,3,43,600,1,1,'02/02/2022')
insert into COMPROBANTE values (463,1,44,600,2,1,'03/02/2022')
insert into COMPROBANTE values (464,3,44,500,1,1,'03/02/2022')
insert into COMPROBANTE values (465,1,45,600,1,1,'03/02/2022')
insert into COMPROBANTE values (466,3,45,700,6,1,'04/02/2022')
insert into COMPROBANTE values (467,2,46,600,6,1,'04/02/2022')
insert into COMPROBANTE values (468,2,46,700,6,1,'04/02/2022')
insert into COMPROBANTE values (469,3,47,600,4,1,'05/02/2022')
insert into COMPROBANTE values (470,2,47,600,4,1,'05/02/2022')
insert into COMPROBANTE values (471,1,48,500,6,1,'05/02/2022')
insert into COMPROBANTE values (472,3,48,500,4,1,'06/02/2022')
insert into COMPROBANTE values (473,2,49,600,5,1,'06/02/2022')
insert into COMPROBANTE values (474,1,49,700,3,1,'06/02/2022')
insert into COMPROBANTE values (475,2,50,700,1,1,'07/02/2022')
insert into COMPROBANTE values (476,2,50,700,4,1,'07/02/2022')
insert into COMPROBANTE values (843,3,51,600,1,1,'14/03/2022')
insert into COMPROBANTE values (844,2,51,500,6,1,'15/03/2022')
insert into COMPROBANTE values (845,1,52,600,5,1,'15/03/2022')
insert into COMPROBANTE values (846,3,52,600,6,1,'15/03/2022')
insert into COMPROBANTE values (847,3,53,500,1,1,'16/03/2022')
insert into COMPROBANTE values (848,3,53,500,5,1,'16/03/2022')
insert into COMPROBANTE values (849,2,54,600,2,1,'16/03/2022')
insert into COMPROBANTE values (850,2,54,600,1,1,'17/03/2022')
insert into COMPROBANTE values (851,2,55,600,2,1,'17/03/2022')
insert into COMPROBANTE values (852,1,55,600,4,1,'17/03/2022')
insert into COMPROBANTE values (853,1,56,600,4,1,'18/03/2022')
insert into COMPROBANTE values (854,1,56,600,4,1,'18/03/2022')
insert into COMPROBANTE values (855,1,57,600,2,1,'18/03/2022')
insert into COMPROBANTE values (856,2,57,600,4,1,'19/03/2022')
insert into COMPROBANTE values (857,1,58,700,6,1,'19/03/2022')
insert into COMPROBANTE values (858,3,58,500,3,1,'19/03/2022')
insert into COMPROBANTE values (859,1,59,600,2,1,'20/03/2022')
insert into COMPROBANTE values (860,2,59,600,3,1,'20/03/2022')
insert into COMPROBANTE values (861,2,60,700,1,1,'20/03/2022')
insert into COMPROBANTE values (862,1,60,600,4,1,'21/03/2022')
insert into COMPROBANTE values (823,3,61,700,6,1,'08/03/2022')
insert into COMPROBANTE values (824,2,61,600,4,1,'08/03/2022')
insert into COMPROBANTE values (825,2,62,500,2,1,'08/03/2022')
insert into COMPROBANTE values (826,1,62,500,2,1,'09/03/2022')
insert into COMPROBANTE values (827,3,63,700,4,1,'09/03/2022')
insert into COMPROBANTE values (828,3,63,500,1,1,'09/03/2022')
insert into COMPROBANTE values (829,2,64,600,3,1,'10/03/2022')
insert into COMPROBANTE values (830,3,64,600,2,1,'10/03/2022')
insert into COMPROBANTE values (831,1,65,600,2,1,'10/03/2022')
insert into COMPROBANTE values (832,3,65,700,1,1,'11/03/2022')
insert into COMPROBANTE values (833,2,66,600,6,1,'11/03/2022')
insert into COMPROBANTE values (834,1,66,600,5,1,'11/03/2022')
insert into COMPROBANTE values (835,3,67,600,6,1,'12/03/2022')
insert into COMPROBANTE values (836,3,67,600,4,1,'12/03/2022')
insert into COMPROBANTE values (837,2,68,600,1,1,'12/03/2022')
insert into COMPROBANTE values (838,2,68,700,4,1,'13/03/2022')
insert into COMPROBANTE values (839,2,69,600,6,1,'13/03/2022')
insert into COMPROBANTE values (840,2,69,600,6,1,'13/03/2022')
insert into COMPROBANTE values (841,1,70,600,1,1,'14/03/2022')
insert into COMPROBANTE values (842,1,70,700,3,1,'14/03/2022')
insert into COMPROBANTE values (1154,3,71,500,3,1,'25/04/2022')
insert into COMPROBANTE values (1155,3,71,500,2,1,'25/04/2022')
insert into COMPROBANTE values (1156,2,72,700,6,1,'26/04/2022')
insert into COMPROBANTE values (1157,1,72,700,3,1,'26/04/2022')
insert into COMPROBANTE values (1158,1,73,500,3,1,'26/04/2022')
insert into COMPROBANTE values (1159,1,73,600,1,1,'27/04/2022')
insert into COMPROBANTE values (1160,2,74,700,2,1,'27/04/2022')
insert into COMPROBANTE values (1161,1,74,700,2,1,'27/04/2022')
insert into COMPROBANTE values (1162,3,75,700,6,1,'28/04/2022')
insert into COMPROBANTE values (1163,2,75,700,4,1,'28/04/2022')
insert into COMPROBANTE values (1164,3,76,700,2,1,'28/04/2022')
insert into COMPROBANTE values (1165,3,76,600,2,1,'29/04/2022')
insert into COMPROBANTE values (1166,2,77,600,6,1,'29/04/2022')
insert into COMPROBANTE values (1167,1,77,700,4,1,'29/04/2022')
insert into COMPROBANTE values (1168,1,78,500,1,1,'30/04/2022')
insert into COMPROBANTE values (1169,1,78,600,5,1,'30/04/2022')
insert into COMPROBANTE values (1170,2,79,700,2,1,'30/04/2022')
insert into COMPROBANTE values (1171,1,79,700,4,1,'01/04/2022')
insert into COMPROBANTE values (1172,1,80,500,6,1,'01/04/2022')
insert into COMPROBANTE values (1173,1,80,600,4,1,'01/04/2022')
insert into COMPROBANTE values (1174,3,81,600,2,1,'02/04/2022')
insert into COMPROBANTE values (1175,1,81,600,2,1,'02/04/2022')
insert into COMPROBANTE values (1176,3,82,700,5,1,'02/04/2022')
insert into COMPROBANTE values (1177,1,82,600,2,1,'03/04/2022')
insert into COMPROBANTE values (1178,1,83,600,6,1,'03/04/2022')
insert into COMPROBANTE values (1179,1,83,600,4,1,'03/04/2022')
insert into COMPROBANTE values (1180,2,84,500,6,1,'04/04/2022')
insert into COMPROBANTE values (1181,3,84,700,1,1,'04/04/2022')
insert into COMPROBANTE values (1182,2,85,600,2,1,'04/04/2022')
insert into COMPROBANTE values (1183,3,85,500,2,1,'05/04/2022')
insert into COMPROBANTE values (1184,1,86,600,2,1,'05/04/2022')
insert into COMPROBANTE values (1185,3,86,700,1,1,'05/04/2022')
insert into COMPROBANTE values (1186,1,87,600,2,1,'06/04/2022')
insert into COMPROBANTE values (1187,3,87,700,5,1,'06/04/2022')
insert into COMPROBANTE values (1188,1,88,700,3,1,'06/04/2022')
insert into COMPROBANTE values (1189,1,88,500,4,1,'07/04/2022')
insert into COMPROBANTE values (1190,1,89,700,1,1,'07/04/2022')
insert into COMPROBANTE values (1191,3,89,700,6,1,'07/04/2022')
insert into COMPROBANTE values (1192,1,90,600,4,1,'08/04/2022')
insert into COMPROBANTE values (1193,2,90,600,1,1,'08/04/2022')
insert into COMPROBANTE values (2021,1,91,700,5,1,'08/06/2022')
insert into COMPROBANTE values (2022,1,91,700,3,1,'08/06/2022')
insert into COMPROBANTE values (2023,1,92,600,4,1,'09/06/2022')
insert into COMPROBANTE values (2024,2,92,500,6,1,'09/06/2022')
insert into COMPROBANTE values (2025,3,93,500,5,1,'09/06/2022')
insert into COMPROBANTE values (2026,1,93,600,1,1,'10/06/2022')
insert into COMPROBANTE values (2027,3,94,700,1,1,'10/06/2022')
insert into COMPROBANTE values (2028,1,94,700,2,1,'10/06/2022')
insert into COMPROBANTE values (2029,2,95,700,2,1,'11/06/2022')
insert into COMPROBANTE values (2030,3,95,700,6,1,'11/06/2022')
insert into COMPROBANTE values (2031,1,96,600,2,1,'11/06/2022')
insert into COMPROBANTE values (2032,2,96,600,1,1,'12/06/2022')
insert into COMPROBANTE values (2033,2,97,700,2,1,'12/06/2022')
insert into COMPROBANTE values (2034,2,97,700,1,1,'12/06/2022')
insert into COMPROBANTE values (2035,3,98,600,5,1,'13/06/2022')
insert into COMPROBANTE values (2036,3,98,700,1,1,'13/06/2022')
insert into COMPROBANTE values (2037,3,99,700,2,1,'13/06/2022')
insert into COMPROBANTE values (2038,1,99,600,4,1,'14/06/2022')
insert into COMPROBANTE values (2039,1,100,700,3,1,'14/06/2022')
insert into COMPROBANTE values (2040,1,100,700,4,1,'14/06/2022')
insert into COMPROBANTE values (2041,2,101,600,1,1,'15/06/2022')
insert into COMPROBANTE values (2042,3,101,700,2,1,'15/06/2022')
insert into COMPROBANTE values (2043,1,102,600,3,1,'15/06/2022')
insert into COMPROBANTE values (2044,1,102,700,4,1,'16/06/2022')
insert into COMPROBANTE values (2045,3,103,600,2,1,'16/06/2022')
insert into COMPROBANTE values (2046,1,103,500,2,1,'16/06/2022')
insert into COMPROBANTE values (2047,3,104,600,2,1,'17/06/2022')
insert into COMPROBANTE values (2048,3,104,500,5,1,'17/06/2022')
insert into COMPROBANTE values (2049,1,105,500,4,1,'17/06/2022')
insert into COMPROBANTE values (2050,3,105,600,1,1,'18/06/2022')
insert into COMPROBANTE values (2051,1,106,700,1,1,'18/06/2022')
insert into COMPROBANTE values (2052,1,106,500,1,1,'18/06/2022')
insert into COMPROBANTE values (2053,3,107,600,1,1,'19/06/2022')
insert into COMPROBANTE values (2054,2,107,600,5,1,'19/06/2022')
insert into COMPROBANTE values (2055,1,108,600,3,1,'19/06/2022')
insert into COMPROBANTE values (2056,3,108,600,1,1,'20/06/2022')
insert into COMPROBANTE values (2057,3,109,700,5,1,'20/06/2022')
insert into COMPROBANTE values (2058,2,109,600,6,1,'20/06/2022')
insert into COMPROBANTE values (2059,1,110,600,1,1,'21/06/2022')
insert into COMPROBANTE values (2060,1,110,500,3,1,'21/06/2022')
insert into COMPROBANTE values (2032,2,111,500,4,1,'12/06/2022')
insert into COMPROBANTE values (2033,2,111,600,3,1,'12/06/2022')
insert into COMPROBANTE values (2034,3,112,700,4,1,'12/06/2022')
insert into COMPROBANTE values (2035,2,112,500,4,1,'13/06/2022')
insert into COMPROBANTE values (2036,2,113,600,4,1,'13/06/2022')
insert into COMPROBANTE values (2037,3,113,700,4,1,'13/06/2022')
insert into COMPROBANTE values (2038,1,114,700,1,1,'14/06/2022')
insert into COMPROBANTE values (2039,3,114,600,6,1,'14/06/2022')
insert into COMPROBANTE values (2040,1,115,500,5,1,'14/06/2022')
insert into COMPROBANTE values (2041,3,115,600,2,1,'15/06/2022')
insert into COMPROBANTE values (2042,1,116,700,1,1,'15/06/2022')
insert into COMPROBANTE values (2043,3,116,500,4,1,'15/06/2022')
insert into COMPROBANTE values (2044,3,117,600,3,1,'16/06/2022')
insert into COMPROBANTE values (2045,2,117,600,4,1,'16/06/2022')
insert into COMPROBANTE values (2046,2,118,600,3,1,'16/06/2022')
insert into COMPROBANTE values (2047,1,118,500,3,1,'17/06/2022')
insert into COMPROBANTE values (2048,2,119,500,1,1,'17/06/2022')
insert into COMPROBANTE values (2049,3,119,700,1,1,'17/06/2022')
insert into COMPROBANTE values (2050,1,120,700,5,1,'18/06/2022')
insert into COMPROBANTE values (2051,3,120,700,3,1,'18/06/2022')
insert into COMPROBANTE values (2179,3,121,600,6,1,'01/07/2022')
insert into COMPROBANTE values (2180,3,121,600,1,1,'01/07/2022')
insert into COMPROBANTE values (2181,2,122,600,2,1,'01/07/2022')
insert into COMPROBANTE values (2182,3,122,600,4,1,'02/07/2022')
insert into COMPROBANTE values (2183,3,123,700,4,1,'02/07/2022')
insert into COMPROBANTE values (2184,2,123,600,2,1,'02/07/2022')
insert into COMPROBANTE values (2185,2,124,700,3,1,'03/07/2022')
insert into COMPROBANTE values (2186,2,124,600,1,1,'03/07/2022')
insert into COMPROBANTE values (2187,2,125,600,2,1,'03/07/2022')
insert into COMPROBANTE values (2188,3,125,600,2,1,'04/07/2022')
insert into COMPROBANTE values (2189,1,126,600,1,1,'04/07/2022')
insert into COMPROBANTE values (2190,1,126,500,6,1,'04/07/2022')
insert into COMPROBANTE values (2191,1,127,600,6,1,'05/07/2022')
insert into COMPROBANTE values (2192,1,127,700,2,1,'05/07/2022')
insert into COMPROBANTE values (2193,1,128,600,4,1,'05/07/2022')
insert into COMPROBANTE values (2194,1,128,500,3,1,'06/07/2022')
insert into COMPROBANTE values (2195,1,129,500,2,1,'06/07/2022')
insert into COMPROBANTE values (2196,1,129,600,5,1,'06/07/2022')
insert into COMPROBANTE values (2197,1,130,600,3,1,'07/07/2022')
insert into COMPROBANTE values (2198,2,130,700,6,1,'07/07/2022')
insert into COMPROBANTE values (2272,1,131,600,6,1,'01/07/2022')
insert into COMPROBANTE values (2273,2,131,500,1,1,'01/07/2022')
insert into COMPROBANTE values (2274,2,132,600,3,1,'01/07/2022')
insert into COMPROBANTE values (2275,3,132,700,2,1,'02/07/2022')
insert into COMPROBANTE values (2276,3,133,700,5,1,'02/07/2022')
insert into COMPROBANTE values (2277,2,133,500,6,1,'02/07/2022')
insert into COMPROBANTE values (2278,2,134,500,1,1,'03/07/2022')
insert into COMPROBANTE values (2279,2,134,600,2,1,'03/07/2022')
insert into COMPROBANTE values (2280,2,135,500,2,1,'03/07/2022')
insert into COMPROBANTE values (2281,3,135,600,3,1,'04/07/2022')
insert into COMPROBANTE values (2282,3,136,500,5,1,'04/07/2022')
insert into COMPROBANTE values (2283,3,136,600,1,1,'04/07/2022')
insert into COMPROBANTE values (2284,2,137,700,4,1,'05/07/2022')
insert into COMPROBANTE values (2285,2,137,700,3,1,'05/07/2022')
insert into COMPROBANTE values (2286,1,138,600,3,1,'05/07/2022')
insert into COMPROBANTE values (2287,3,138,700,6,1,'06/07/2022')
insert into COMPROBANTE values (2288,2,139,500,2,1,'06/07/2022')
insert into COMPROBANTE values (2289,1,139,600,6,1,'06/07/2022')
insert into COMPROBANTE values (2290,1,140,600,2,1,'07/07/2022')
insert into COMPROBANTE values (2291,2,140,600,5,1,'07/07/2022')
insert into COMPROBANTE values (2292,3,141,600,4,1,'07/07/2022')
insert into COMPROBANTE values (2293,2,141,700,6,1,'08/07/2022')
insert into COMPROBANTE values (2294,1,142,500,3,1,'08/07/2022')
insert into COMPROBANTE values (2295,3,142,700,3,1,'08/07/2022')
insert into COMPROBANTE values (2296,3,143,700,6,1,'09/07/2022')
insert into COMPROBANTE values (2297,2,143,700,3,1,'09/07/2022')
insert into COMPROBANTE values (2298,3,144,600,6,1,'09/07/2022')
insert into COMPROBANTE values (2299,3,144,600,3,1,'10/07/2022')
insert into COMPROBANTE values (2300,1,145,600,2,1,'10/07/2022')
insert into COMPROBANTE values (2301,2,145,600,1,1,'10/07/2022')
insert into COMPROBANTE values (2302,1,146,600,6,1,'11/07/2022')
insert into COMPROBANTE values (2303,2,146,600,5,1,'11/07/2022')
insert into COMPROBANTE values (2304,1,147,600,3,1,'11/07/2022')
insert into COMPROBANTE values (2305,2,147,700,5,1,'12/07/2022')
insert into COMPROBANTE values (2306,1,148,700,4,1,'12/07/2022')
insert into COMPROBANTE values (2307,3,148,700,5,1,'12/07/2022')
insert into COMPROBANTE values (2308,1,149,600,6,1,'13/07/2022')
insert into COMPROBANTE values (2309,2,149,500,2,1,'13/07/2022')
insert into COMPROBANTE values (2310,3,150,600,1,1,'13/07/2022')
insert into COMPROBANTE values (2311,1,150,700,5,1,'14/07/2022')
insert into COMPROBANTE values (2312,3,151,600,6,1,'14/07/2022')
insert into COMPROBANTE values (2313,1,151,600,5,1,'14/07/2022')
insert into COMPROBANTE values (2314,2,152,700,6,1,'15/07/2022')
insert into COMPROBANTE values (2315,3,152,500,6,1,'15/07/2022')
insert into COMPROBANTE values (2316,2,153,700,2,1,'15/07/2022')
insert into COMPROBANTE values (2317,3,153,600,6,1,'16/07/2022')
insert into COMPROBANTE values (2318,1,154,500,2,1,'16/07/2022')
insert into COMPROBANTE values (2319,3,154,700,1,1,'16/07/2022')
insert into COMPROBANTE values (2320,1,155,600,6,1,'17/07/2022')
insert into COMPROBANTE values (2321,2,155,600,3,1,'17/07/2022')
insert into COMPROBANTE values (2322,2,156,600,6,1,'17/07/2022')
insert into COMPROBANTE values (2323,1,156,600,2,1,'18/07/2022')
insert into COMPROBANTE values (2324,1,157,600,2,1,'18/07/2022')
insert into COMPROBANTE values (2325,3,157,500,2,1,'18/07/2022')
insert into COMPROBANTE values (2326,2,158,600,2,1,'19/07/2022')
insert into COMPROBANTE values (2327,2,158,600,2,1,'19/07/2022')
insert into COMPROBANTE values (2328,1,159,600,3,1,'19/07/2022')
insert into COMPROBANTE values (2329,2,159,600,6,1,'20/07/2022')
insert into COMPROBANTE values (2330,1,160,500,4,1,'20/07/2022')
insert into COMPROBANTE values (2331,3,160,600,1,1,'20/07/2022')
insert into COMPROBANTE values (2332,1,161,700,6,1,'21/07/2022')
insert into COMPROBANTE values (2333,3,161,600,5,1,'21/07/2022')
insert into COMPROBANTE values (2334,3,162,700,5,1,'21/07/2022')
insert into COMPROBANTE values (2335,1,162,500,5,1,'22/07/2022')
insert into COMPROBANTE values (2336,2,163,600,4,1,'22/07/2022')
insert into COMPROBANTE values (2337,1,163,500,5,1,'22/07/2022')
insert into COMPROBANTE values (2338,2,164,600,1,1,'23/07/2022')
insert into COMPROBANTE values (2339,3,164,600,2,1,'23/07/2022')
insert into COMPROBANTE values (2340,3,165,600,6,1,'23/07/2022')
insert into COMPROBANTE values (2341,1,165,700,5,1,'24/07/2022')
insert into COMPROBANTE values (2342,2,166,600,5,1,'24/07/2022')
insert into COMPROBANTE values (2343,3,166,600,5,1,'24/07/2022')
insert into COMPROBANTE values (2344,3,167,600,3,1,'25/07/2022')
insert into COMPROBANTE values (2345,3,167,700,2,1,'25/07/2022')
insert into COMPROBANTE values (2346,1,168,500,5,1,'25/07/2022')
insert into COMPROBANTE values (2347,2,168,700,1,1,'26/07/2022')
insert into COMPROBANTE values (2348,2,169,500,4,1,'26/07/2022')
insert into COMPROBANTE values (2349,1,169,700,5,1,'26/07/2022')
insert into COMPROBANTE values (2350,2,170,600,1,1,'27/07/2022')
insert into COMPROBANTE values (2351,1,170,500,1,1,'27/07/2022')
insert into COMPROBANTE values (2352,2,171,500,6,1,'27/07/2022')
insert into COMPROBANTE values (2353,3,171,700,6,1,'28/07/2022')
insert into COMPROBANTE values (2354,2,172,600,2,1,'28/07/2022')
insert into COMPROBANTE values (2355,1,172,500,6,1,'28/07/2022')
insert into COMPROBANTE values (2356,3,173,600,2,1,'29/07/2022')
insert into COMPROBANTE values (2357,1,173,600,6,1,'29/07/2022')
insert into COMPROBANTE values (2358,3,174,600,1,1,'29/07/2022')
insert into COMPROBANTE values (2359,1,174,700,5,1,'30/07/2022')
insert into COMPROBANTE values (2360,2,175,600,6,1,'30/07/2022')
insert into COMPROBANTE values (2361,2,175,500,4,1,'30/07/2022')
insert into COMPROBANTE values (2551,1,176,600,2,1,'01/08/2022')
insert into COMPROBANTE values (2552,1,176,600,3,1,'01/08/2022')
insert into COMPROBANTE values (2553,3,177,500,4,1,'01/08/2022')
insert into COMPROBANTE values (2554,1,177,500,2,1,'02/08/2022')
insert into COMPROBANTE values (2555,2,178,600,6,1,'02/08/2022')
insert into COMPROBANTE values (2556,2,178,600,4,1,'02/08/2022')
insert into COMPROBANTE values (2557,3,179,600,6,1,'03/08/2022')
insert into COMPROBANTE values (2558,2,179,700,5,1,'03/08/2022')
insert into COMPROBANTE values (2559,1,180,500,6,1,'03/08/2022')
insert into COMPROBANTE values (2560,3,180,600,4,1,'04/08/2022')
insert into COMPROBANTE values (2561,1,181,600,4,1,'04/08/2022')
insert into COMPROBANTE values (2562,3,181,600,2,1,'04/08/2022')
insert into COMPROBANTE values (2563,2,182,600,6,1,'05/08/2022')
insert into COMPROBANTE values (2564,1,182,500,5,1,'05/08/2022')
insert into COMPROBANTE values (2565,1,183,700,6,1,'05/08/2022')
insert into COMPROBANTE values (2566,1,183,600,3,1,'06/08/2022')
insert into COMPROBANTE values (2567,2,184,500,3,1,'06/08/2022')
insert into COMPROBANTE values (2568,1,184,600,6,1,'06/08/2022')
insert into COMPROBANTE values (2569,3,185,700,6,1,'07/08/2022')
insert into COMPROBANTE values (2570,1,185,600,3,1,'07/08/2022')
insert into COMPROBANTE values (2571,1,186,600,6,1,'07/08/2022')
insert into COMPROBANTE values (2572,2,186,700,2,1,'08/08/2022')
insert into COMPROBANTE values (2573,3,187,600,4,1,'08/08/2022')
insert into COMPROBANTE values (2574,3,187,500,2,1,'08/08/2022')
insert into COMPROBANTE values (2575,2,188,600,2,1,'09/08/2022')
insert into COMPROBANTE values (2576,1,188,600,1,1,'09/08/2022')
insert into COMPROBANTE values (2577,1,189,600,3,1,'09/08/2022')
insert into COMPROBANTE values (2578,1,189,600,1,1,'10/08/2022')
insert into COMPROBANTE values (2579,2,190,600,1,1,'10/08/2022')
insert into COMPROBANTE values (2580,2,190,500,3,1,'10/08/2022')
insert into COMPROBANTE values (2581,1,191,500,3,1,'11/08/2022')
insert into COMPROBANTE values (2582,2,191,600,6,1,'11/08/2022')
insert into COMPROBANTE values (2583,1,192,600,1,1,'11/08/2022')
insert into COMPROBANTE values (2584,3,192,500,4,1,'12/08/2022')
insert into COMPROBANTE values (2585,1,193,700,2,1,'12/08/2022')
insert into COMPROBANTE values (2586,2,193,600,1,1,'12/08/2022')
insert into COMPROBANTE values (2587,2,194,600,1,1,'13/08/2022')
insert into COMPROBANTE values (2588,1,194,600,6,1,'13/08/2022')
insert into COMPROBANTE values (2589,3,195,600,5,1,'13/08/2022')
insert into COMPROBANTE values (2590,2,195,600,6,1,'14/08/2022')
insert into COMPROBANTE values (3821,1,196,600,4,1,'25/10/2022')
insert into COMPROBANTE values (3822,2,196,600,4,1,'25/10/2022')
insert into COMPROBANTE values (3823,3,197,600,1,1,'26/10/2022')
insert into COMPROBANTE values (3824,3,197,700,6,1,'26/10/2022')
insert into COMPROBANTE values (3825,3,198,500,2,1,'26/10/2022')
insert into COMPROBANTE values (3826,2,198,500,2,1,'27/10/2022')
insert into COMPROBANTE values (3827,3,199,700,2,1,'27/10/2022')
insert into COMPROBANTE values (3828,1,199,600,1,1,'27/10/2022')
insert into COMPROBANTE values (3829,1,200,500,5,1,'28/10/2022')
insert into COMPROBANTE values (3830,1,200,500,3,1,'28/10/2022')
insert into COMPROBANTE values (3831,2,201,600,4,1,'28/10/2022')
insert into COMPROBANTE values (3832,3,201,600,6,1,'29/10/2022')
insert into COMPROBANTE values (3833,2,202,500,2,1,'29/10/2022')
insert into COMPROBANTE values (3834,1,202,500,2,1,'29/10/2022')
insert into COMPROBANTE values (3835,2,203,600,1,1,'30/10/2022')
insert into COMPROBANTE values (3836,3,203,600,4,1,'30/10/2022')
insert into COMPROBANTE values (3837,2,204,600,2,1,'30/10/2022')
insert into COMPROBANTE values (3838,1,204,700,6,1,'31/10/2022')
insert into COMPROBANTE values (3839,2,205,500,4,1,'31/10/2022')
insert into COMPROBANTE values (3840,1,205,600,5,1,'31/10/2022')
insert into COMPROBANTE values (4089,2,206,600,3,1,'03/11/2022')
insert into COMPROBANTE values (4090,3,206,600,6,1,'04/11/2022')
insert into COMPROBANTE values (4091,1,207,600,1,1,'04/11/2022')
insert into COMPROBANTE values (4092,3,207,500,5,1,'04/11/2022')
insert into COMPROBANTE values (4093,2,208,700,5,1,'05/11/2022')
insert into COMPROBANTE values (4094,1,208,600,5,1,'05/11/2022')
insert into COMPROBANTE values (4095,1,209,500,6,1,'05/11/2022')
insert into COMPROBANTE values (4096,2,209,600,1,1,'06/11/2022')
insert into COMPROBANTE values (4097,1,210,700,1,1,'06/11/2022')
insert into COMPROBANTE values (4098,1,210,600,6,1,'06/11/2022')
insert into COMPROBANTE values (4099,1,211,600,6,1,'07/11/2022')
insert into COMPROBANTE values (4100,2,211,700,6,1,'07/11/2022')
insert into COMPROBANTE values (4101,3,212,600,3,1,'07/11/2022')
insert into COMPROBANTE values (4102,3,212,500,6,1,'08/11/2022')
insert into COMPROBANTE values (4103,2,213,600,4,1,'08/11/2022')
insert into COMPROBANTE values (4104,1,213,600,6,1,'08/11/2022')
insert into COMPROBANTE values (4105,3,214,600,1,1,'09/11/2022')
insert into COMPROBANTE values (4106,1,214,600,6,1,'09/11/2022')
insert into COMPROBANTE values (4107,1,215,600,1,1,'09/11/2022')
insert into COMPROBANTE values (4108,2,215,500,1,1,'10/11/2022')
insert into COMPROBANTE values (4109,3,216,500,5,1,'10/11/2022')
insert into COMPROBANTE values (4110,3,216,600,4,1,'10/11/2022')
insert into COMPROBANTE values (4111,1,217,600,4,1,'11/11/2022')
insert into COMPROBANTE values (4112,1,217,500,5,1,'11/11/2022')
insert into COMPROBANTE values (4113,3,218,700,6,1,'11/11/2022')
insert into COMPROBANTE values (4114,3,218,600,5,1,'12/11/2022')
insert into COMPROBANTE values (4115,1,219,600,6,1,'12/11/2022')
insert into COMPROBANTE values (4116,3,219,600,4,1,'12/11/2022')
insert into COMPROBANTE values (4117,3,220,600,5,1,'13/11/2022')
insert into COMPROBANTE values (4118,2,220,600,3,1,'13/11/2022')
insert into COMPROBANTE values (4119,2,221,600,5,1,'13/11/2022')
insert into COMPROBANTE values (4120,2,221,600,2,1,'14/11/2022')
insert into COMPROBANTE values (4121,3,222,600,1,1,'14/11/2022')
insert into COMPROBANTE values (4122,3,222,700,1,1,'14/11/2022')
insert into COMPROBANTE values (4123,2,223,500,3,1,'15/11/2022')
insert into COMPROBANTE values (4124,1,223,500,4,1,'15/11/2022')
insert into COMPROBANTE values (4125,2,224,700,5,1,'15/11/2022')
insert into COMPROBANTE values (4126,1,224,600,1,1,'16/11/2022')
insert into COMPROBANTE values (4127,3,225,500,2,1,'16/11/2022')
insert into COMPROBANTE values (4128,1,225,500,4,1,'16/11/2022')

insert into RESERVA values('1/1/2022',1)
insert into RESERVA values('1/1/2022',1)
insert into RESERVA values('2/1/2022',1)
insert into RESERVA values('3/1/2022',1)
insert into RESERVA values('3/1/2022',1)
insert into RESERVA values('4/1/2022',1)
insert into RESERVA values('5/1/2022',1)
insert into RESERVA values('5/1/2022',1)
insert into RESERVA values('6/1/2022',1)
insert into RESERVA values('7/1/2022',1)
insert into RESERVA values('11/1/2022',1)
insert into RESERVA values('11/1/2022',1)
insert into RESERVA values('12/1/2022',1)
insert into RESERVA values('13/1/2022',1)
insert into RESERVA values('13/1/2022',1)
insert into RESERVA values('14/1/2022',1)
insert into RESERVA values('15/1/2022',1)
insert into RESERVA values('15/1/2022',1)
insert into RESERVA values('16/1/2022',1)
insert into RESERVA values('17/1/2022',1)
insert into RESERVA values('17/1/2022',1)
insert into RESERVA values('25/1/2022',1)
insert into RESERVA values('26/1/2022',1)
insert into RESERVA values('27/1/2022',1)
insert into RESERVA values('27/1/2022',1)
insert into RESERVA values('28/1/2022',1)
insert into RESERVA values('29/1/2022',1)
insert into RESERVA values('29/1/2022',1)
insert into RESERVA values('30/1/2022',1)
insert into RESERVA values('31/1/2022',1)
insert into RESERVA values('31/1/2022',1)
insert into RESERVA values('4/2/2022',1)
insert into RESERVA values('5/2/2022',1)
insert into RESERVA values('5/2/2022',1)
insert into RESERVA values('6/2/2022',1)
insert into RESERVA values('7/2/2022',1)
insert into RESERVA values('7/2/2022',1)
insert into RESERVA values('8/2/2022',1)
insert into RESERVA values('9/2/2022',1)
insert into RESERVA values('9/2/2022',1)
insert into RESERVA values('1/2/2022',1)
insert into RESERVA values('1/2/2022',1)
insert into RESERVA values('2/2/2022',1)
insert into RESERVA values('3/2/2022',1)
insert into RESERVA values('3/2/2022',1)
insert into RESERVA values('4/2/2022',1)
insert into RESERVA values('5/2/2022',1)
insert into RESERVA values('5/2/2022',1)
insert into RESERVA values('6/2/2022',1)
insert into RESERVA values('7/2/2022',1)
insert into RESERVA values('14/3/2022',1)
insert into RESERVA values('15/3/2022',1)
insert into RESERVA values('16/3/2022',1)
insert into RESERVA values('16/3/2022',1)
insert into RESERVA values('17/3/2022',1)
insert into RESERVA values('18/3/2022',1)
insert into RESERVA values('18/3/2022',1)
insert into RESERVA values('19/3/2022',1)
insert into RESERVA values('20/3/2022',1)
insert into RESERVA values('20/3/2022',1)
insert into RESERVA values('8/3/2022',1)
insert into RESERVA values('8/3/2022',1)
insert into RESERVA values('9/3/2022',1)
insert into RESERVA values('10/3/2022',1)
insert into RESERVA values('10/3/2022',1)
insert into RESERVA values('11/3/2022',1)
insert into RESERVA values('12/3/2022',1)
insert into RESERVA values('12/3/2022',1)
insert into RESERVA values('13/3/2022',1)
insert into RESERVA values('14/3/2022',1)
insert into RESERVA values('25/4/2022',1)
insert into RESERVA values('26/4/2022',1)
insert into RESERVA values('26/4/2022',1)
insert into RESERVA values('27/4/2022',1)
insert into RESERVA values('28/4/2022',1)
insert into RESERVA values('28/4/2022',1)
insert into RESERVA values('29/4/2022',1)
insert into RESERVA values('30/4/2022',1)
insert into RESERVA values('30/4/2022',1)
insert into RESERVA values('1/4/2022',1)
insert into RESERVA values('2/4/2022',1)
insert into RESERVA values('2/4/2022',1)
insert into RESERVA values('3/4/2022',1)
insert into RESERVA values('4/4/2022',1)
insert into RESERVA values('4/4/2022',1)
insert into RESERVA values('5/4/2022',1)
insert into RESERVA values('6/4/2022',1)
insert into RESERVA values('6/4/2022',1)
insert into RESERVA values('7/4/2022',1)
insert into RESERVA values('8/4/2022',1)
insert into RESERVA values('8/6/2022',1)
insert into RESERVA values('9/6/2022',1)
insert into RESERVA values('9/6/2022',1)
insert into RESERVA values('10/6/2022',1)
insert into RESERVA values('11/6/2022',1)
insert into RESERVA values('11/6/2022',1)
insert into RESERVA values('12/6/2022',1)
insert into RESERVA values('13/6/2022',1)
insert into RESERVA values('13/6/2022',1)
insert into RESERVA values('14/6/2022',1)
insert into RESERVA values('15/6/2022',1)
insert into RESERVA values('15/6/2022',1)
insert into RESERVA values('16/6/2022',1)
insert into RESERVA values('17/6/2022',1)
insert into RESERVA values('17/6/2022',1)
insert into RESERVA values('18/6/2022',1)
insert into RESERVA values('19/6/2022',1)
insert into RESERVA values('19/6/2022',1)
insert into RESERVA values('20/6/2022',1)
insert into RESERVA values('21/6/2022',1)
insert into RESERVA values('12/6/2022',1)
insert into RESERVA values('12/6/2022',1)
insert into RESERVA values('13/6/2022',1)
insert into RESERVA values('14/6/2022',1)
insert into RESERVA values('14/6/2022',1)
insert into RESERVA values('15/6/2022',1)
insert into RESERVA values('16/6/2022',1)
insert into RESERVA values('16/6/2022',1)
insert into RESERVA values('17/6/2022',1)
insert into RESERVA values('18/6/2022',1)
insert into RESERVA values('1/7/2022',1)
insert into RESERVA values('1/7/2022',1)
insert into RESERVA values('2/7/2022',1)
insert into RESERVA values('3/7/2022',1)
insert into RESERVA values('3/7/2022',1)
insert into RESERVA values('4/7/2022',1)
insert into RESERVA values('5/7/2022',1)
insert into RESERVA values('5/7/2022',1)
insert into RESERVA values('6/7/2022',1)
insert into RESERVA values('7/7/2022',1)
insert into RESERVA values('1/7/2022',1)
insert into RESERVA values('1/7/2022',1)
insert into RESERVA values('2/7/2022',1)
insert into RESERVA values('3/7/2022',1)
insert into RESERVA values('3/7/2022',1)
insert into RESERVA values('4/7/2022',1)
insert into RESERVA values('5/7/2022',1)
insert into RESERVA values('5/7/2022',1)
insert into RESERVA values('6/7/2022',1)
insert into RESERVA values('7/7/2022',1)
insert into RESERVA values('7/7/2022',1)
insert into RESERVA values('8/7/2022',1)
insert into RESERVA values('9/7/2022',1)
insert into RESERVA values('9/7/2022',1)
insert into RESERVA values('10/7/2022',1)
insert into RESERVA values('11/7/2022',1)
insert into RESERVA values('11/7/2022',1)
insert into RESERVA values('12/7/2022',1)
insert into RESERVA values('13/7/2022',1)
insert into RESERVA values('13/7/2022',1)
insert into RESERVA values('14/7/2022',1)
insert into RESERVA values('15/7/2022',1)
insert into RESERVA values('15/7/2022',1)
insert into RESERVA values('16/7/2022',1)
insert into RESERVA values('17/7/2022',1)
insert into RESERVA values('17/7/2022',1)
insert into RESERVA values('18/7/2022',1)
insert into RESERVA values('19/7/2022',1)
insert into RESERVA values('19/7/2022',1)
insert into RESERVA values('20/7/2022',1)
insert into RESERVA values('21/7/2022',1)
insert into RESERVA values('21/7/2022',1)
insert into RESERVA values('22/7/2022',1)
insert into RESERVA values('23/7/2022',1)
insert into RESERVA values('23/7/2022',1)
insert into RESERVA values('24/7/2022',1)
insert into RESERVA values('25/7/2022',1)
insert into RESERVA values('25/7/2022',1)
insert into RESERVA values('26/7/2022',1)
insert into RESERVA values('27/7/2022',1)
insert into RESERVA values('27/7/2022',1)
insert into RESERVA values('28/7/2022',1)
insert into RESERVA values('29/7/2022',1)
insert into RESERVA values('29/7/2022',1)
insert into RESERVA values('30/7/2022',1)
insert into RESERVA values('1/8/2022',1)
insert into RESERVA values('1/8/2022',1)
insert into RESERVA values('2/8/2022',1)
insert into RESERVA values('3/8/2022',1)
insert into RESERVA values('3/8/2022',1)
insert into RESERVA values('4/8/2022',1)
insert into RESERVA values('5/8/2022',1)
insert into RESERVA values('5/8/2022',1)
insert into RESERVA values('6/8/2022',1)
insert into RESERVA values('7/8/2022',1)
insert into RESERVA values('7/8/2022',1)
insert into RESERVA values('8/8/2022',1)
insert into RESERVA values('9/8/2022',1)
insert into RESERVA values('9/8/2022',1)
insert into RESERVA values('10/8/2022',1)
insert into RESERVA values('11/8/2022',1)
insert into RESERVA values('11/8/2022',1)
insert into RESERVA values('12/8/2022',1)
insert into RESERVA values('13/8/2022',1)
insert into RESERVA values('13/8/2022',1)
insert into RESERVA values('25/10/2022',1)
insert into RESERVA values('26/10/2022',1)
insert into RESERVA values('26/10/2022',1)
insert into RESERVA values('27/10/2022',1)
insert into RESERVA values('28/10/2022',1)
insert into RESERVA values('28/10/2022',1)
insert into RESERVA values('29/10/2022',1)
insert into RESERVA values('30/10/2022',1)
insert into RESERVA values('30/10/2022',1)
insert into RESERVA values('31/10/2022',1)
insert into RESERVA values('3/11/2022',1)
insert into RESERVA values('4/11/2022',1)
insert into RESERVA values('5/11/2022',1)
insert into RESERVA values('5/11/2022',1)
insert into RESERVA values('6/11/2022',1)
insert into RESERVA values('7/11/2022',1)
insert into RESERVA values('7/11/2022',1)
insert into RESERVA values('8/11/2022',1)
insert into RESERVA values('9/11/2022',1)
insert into RESERVA values('9/11/2022',1)
insert into RESERVA values('10/11/2022',1)
insert into RESERVA values('11/11/2022',1)
insert into RESERVA values('11/11/2022',1)
insert into RESERVA values('12/11/2022',1)
insert into RESERVA values('13/11/2022',1)
insert into RESERVA values('13/11/2022',1)
insert into RESERVA values('14/11/2022',1)
insert into RESERVA values('15/11/2022',1)
insert into RESERVA values('15/11/2022',1)
insert into RESERVA values('16/11/2022',1)

insert into ticket values(1,2,2,0)
insert into ticket values(2,2,2,0)
insert into ticket values(3,4,3,0)
insert into ticket values(4,1,1,0)
insert into ticket values(5,4,2,0)
insert into ticket values(6,4,1,0)
insert into ticket values(7,1,3,0)
insert into ticket values(8,2,4,0)
insert into ticket values(9,3,3,0)
insert into ticket values(10,3,3,0)
insert into ticket values(11,1,3,0)
insert into ticket values(12,4,3,0)
insert into ticket values(13,4,2,0)
insert into ticket values(14,1,2,0)
insert into ticket values(15,4,2,0)
insert into ticket values(16,1,1,0)
insert into ticket values(17,3,1,0)
insert into ticket values(18,1,1,0)
insert into ticket values(19,1,3,0)
insert into ticket values(20,4,3,0)
insert into ticket values(21,3,1,0)
insert into ticket values(22,4,2,0)
insert into ticket values(23,4,4,0)
insert into ticket values(24,1,3,0)
insert into ticket values(25,3,1,0)
insert into ticket values(26,4,3,0)
insert into ticket values(27,4,4,0)
insert into ticket values(28,2,4,0)
insert into ticket values(29,2,4,0)
insert into ticket values(30,3,2,0)
insert into ticket values(31,2,3,0)
insert into ticket values(32,3,3,0)
insert into ticket values(33,4,2,0)
insert into ticket values(34,3,3,0)
insert into ticket values(35,1,1,0)
insert into ticket values(36,3,3,0)
insert into ticket values(37,2,3,0)
insert into ticket values(38,1,2,0)
insert into ticket values(39,4,3,0)
insert into ticket values(40,3,3,0)
insert into ticket values(41,1,1,0)
insert into ticket values(42,3,4,0)
insert into ticket values(43,1,1,0)
insert into ticket values(44,1,4,0)
insert into ticket values(45,1,1,0)
insert into ticket values(46,3,3,0)
insert into ticket values(47,2,4,0)
insert into ticket values(48,3,3,0)
insert into ticket values(49,1,4,0)
insert into ticket values(50,1,2,0)
insert into ticket values(51,4,2,0)
insert into ticket values(52,1,2,0)
insert into ticket values(53,3,3,0)
insert into ticket values(54,1,3,0)
insert into ticket values(55,4,2,0)
insert into ticket values(56,2,4,0)
insert into ticket values(57,4,4,0)
insert into ticket values(58,3,1,0)
insert into ticket values(59,1,3,0)
insert into ticket values(60,3,3,0)
insert into ticket values(61,4,2,0)
insert into ticket values(62,1,3,0)
insert into ticket values(63,1,3,0)
insert into ticket values(64,2,4,0)
insert into ticket values(65,3,4,0)
insert into ticket values(66,1,1,0)
insert into ticket values(67,4,1,0)
insert into ticket values(68,1,1,0)
insert into ticket values(69,4,2,0)
insert into ticket values(70,4,2,0)
insert into ticket values(71,4,1,0)
insert into ticket values(72,4,4,0)
insert into ticket values(73,1,4,0)
insert into ticket values(74,3,4,0)
insert into ticket values(75,2,2,0)
insert into ticket values(76,2,4,0)
insert into ticket values(77,3,2,0)
insert into ticket values(78,1,1,0)
insert into ticket values(79,3,3,0)
insert into ticket values(80,1,1,0)
insert into ticket values(81,4,2,0)
insert into ticket values(82,1,2,0)
insert into ticket values(83,2,4,0)
insert into ticket values(84,2,3,0)
insert into ticket values(85,3,1,0)
insert into ticket values(86,1,4,0)
insert into ticket values(87,2,2,0)
insert into ticket values(88,3,1,0)
insert into ticket values(89,4,1,0)
insert into ticket values(90,3,2,0)
insert into ticket values(91,4,1,0)
insert into ticket values(92,2,1,0)
insert into ticket values(93,4,4,0)
insert into ticket values(94,4,3,0)
insert into ticket values(95,4,3,0)
insert into ticket values(96,4,2,0)
insert into ticket values(97,1,4,0)
insert into ticket values(98,1,3,0)
insert into ticket values(99,3,4,0)
insert into ticket values(100,2,2,0)
insert into ticket values(101,3,3,0)
insert into ticket values(102,3,1,0)
insert into ticket values(103,4,4,0)
insert into ticket values(104,2,3,0)
insert into ticket values(105,1,3,0)
insert into ticket values(106,2,3,0)
insert into ticket values(107,3,3,0)
insert into ticket values(108,1,1,0)
insert into ticket values(109,4,2,0)
insert into ticket values(110,4,1,0)
insert into ticket values(111,2,2,0)
insert into ticket values(112,3,3,0)
insert into ticket values(113,4,1,0)
insert into ticket values(114,1,1,0)
insert into ticket values(115,2,2,0)
insert into ticket values(116,3,2,0)
insert into ticket values(117,4,1,0)
insert into ticket values(118,2,1,0)
insert into ticket values(119,3,3,0)
insert into ticket values(120,2,1,0)
insert into ticket values(121,3,3,0)
insert into ticket values(122,2,4,0)
insert into ticket values(123,2,2,0)
insert into ticket values(124,3,4,0)
insert into ticket values(125,2,2,0)
insert into ticket values(126,1,3,0)
insert into ticket values(127,2,3,0)
insert into ticket values(128,2,4,0)
insert into ticket values(129,2,4,0)
insert into ticket values(130,4,4,0)
insert into ticket values(131,1,1,0)
insert into ticket values(132,3,4,0)
insert into ticket values(133,4,1,0)
insert into ticket values(134,1,4,0)
insert into ticket values(135,1,4,0)
insert into ticket values(136,3,2,0)
insert into ticket values(137,4,2,0)
insert into ticket values(138,2,2,0)
insert into ticket values(139,4,4,0)
insert into ticket values(140,3,3,0)
insert into ticket values(141,4,4,0)
insert into ticket values(142,2,1,0)
insert into ticket values(143,2,2,0)
insert into ticket values(144,3,3,0)
insert into ticket values(145,3,1,0)
insert into ticket values(146,1,3,0)
insert into ticket values(147,1,2,0)
insert into ticket values(148,2,1,0)
insert into ticket values(149,2,4,0)
insert into ticket values(150,2,2,0)
insert into ticket values(151,3,4,0)
insert into ticket values(152,2,3,0)
insert into ticket values(153,4,2,0)
insert into ticket values(154,4,2,0)
insert into ticket values(155,3,1,0)
insert into ticket values(156,3,2,0)
insert into ticket values(157,3,4,0)
insert into ticket values(158,2,3,0)
insert into ticket values(159,3,4,0)
insert into ticket values(160,2,2,0)
insert into ticket values(161,1,2,0)
insert into ticket values(162,4,1,0)
insert into ticket values(163,3,1,0)
insert into ticket values(164,4,2,0)
insert into ticket values(165,1,1,0)
insert into ticket values(166,2,4,0)
insert into ticket values(167,3,3,0)
insert into ticket values(168,3,3,0)
insert into ticket values(169,4,1,0)
insert into ticket values(170,1,2,0)
insert into ticket values(171,1,4,0)
insert into ticket values(172,3,3,0)
insert into ticket values(173,3,4,0)
insert into ticket values(174,1,1,0)
insert into ticket values(175,2,4,0)
insert into ticket values(176,3,3,0)
insert into ticket values(177,4,1,0)
insert into ticket values(178,1,3,0)
insert into ticket values(179,4,4,0)
insert into ticket values(180,1,2,0)
insert into ticket values(181,4,4,0)
insert into ticket values(182,1,4,0)
insert into ticket values(183,4,2,0)
insert into ticket values(184,1,4,0)
insert into ticket values(185,4,2,0)
insert into ticket values(186,4,2,0)
insert into ticket values(187,3,2,0)
insert into ticket values(188,4,2,0)
insert into ticket values(189,2,4,0)
insert into ticket values(190,2,2,0)
insert into ticket values(191,4,4,0)
insert into ticket values(192,4,2,0)
insert into ticket values(193,1,2,0)
insert into ticket values(194,1,1,0)
insert into ticket values(195,3,1,0)
insert into ticket values(196,4,4,0)
insert into ticket values(197,4,3,0)
insert into ticket values(198,4,3,0)
insert into ticket values(199,3,1,0)
insert into ticket values(200,2,4,0)
insert into ticket values(201,3,4,0)
insert into ticket values(202,2,4,0)
insert into ticket values(203,4,3,0)
insert into ticket values(204,1,4,0)
insert into ticket values(205,1,3,0)
insert into ticket values(206,3,3,0)
insert into ticket values(207,4,1,0)
insert into ticket values(208,1,3,0)
insert into ticket values(209,2,1,0)
insert into ticket values(210,3,4,0)
insert into ticket values(211,2,1,0)
insert into ticket values(212,3,4,0)
insert into ticket values(213,2,2,0)
insert into ticket values(214,2,3,0)
insert into ticket values(215,3,1,0)
insert into ticket values(216,1,1,0)
insert into ticket values(217,2,2,0)
insert into ticket values(218,3,1,0)
insert into ticket values(219,4,3,0)
insert into ticket values(220,3,4,0)
insert into ticket values(221,4,1,0)
insert into ticket values(222,1,1,0)
insert into ticket values(223,1,1,0)
insert into ticket values(224,3,3,0)
insert into ticket values(225,4,4,0)
insert into ticket values(226,4,3,0)
insert into ticket values(227,4,4,0)
insert into ticket values(228,3,4,0)
insert into ticket values(229,2,2,0)
insert into ticket values(230,3,4,0)
insert into ticket values(231,2,4,0)
insert into ticket values(232,4,2,0)
insert into ticket values(233,1,1,0)
insert into ticket values(234,1,2,0)
insert into ticket values(235,3,3,0)
insert into ticket values(236,4,1,0)
insert into ticket values(237,1,4,0)
insert into ticket values(238,2,3,0)
insert into ticket values(239,3,3,0)
insert into ticket values(240,2,3,0)
insert into ticket values(241,3,3,0)
insert into ticket values(242,2,3,0)
insert into ticket values(243,4,1,0)
insert into ticket values(244,1,3,0)
insert into ticket values(245,1,4,0)
insert into ticket values(246,4,3,0)
insert into ticket values(247,3,2,0)
insert into ticket values(248,2,4,0)
insert into ticket values(249,4,2,0)
insert into ticket values(250,1,1,0)
insert into ticket values(251,3,4,0)
insert into ticket values(252,1,2,0)
insert into ticket values(253,1,4,0)
insert into ticket values(254,2,2,0)
insert into ticket values(255,1,2,0)
insert into ticket values(256,3,2,0)
insert into ticket values(257,2,1,0)
insert into ticket values(258,2,4,0)
insert into ticket values(259,2,2,0)
insert into ticket values(260,3,1,0)
insert into ticket values(261,1,3,0)
insert into ticket values(262,2,1,0)
insert into ticket values(263,2,1,0)
insert into ticket values(264,2,3,0)
insert into ticket values(265,2,4,0)
insert into ticket values(266,1,1,0)
insert into ticket values(267,1,4,0)
insert into ticket values(268,3,4,0)
insert into ticket values(269,2,1,0)
insert into ticket values(270,1,3,0)
insert into ticket values(271,3,1,0)
insert into ticket values(272,2,4,0)
insert into ticket values(273,1,4,0)
insert into ticket values(274,2,1,0)
insert into ticket values(275,3,3,0)
insert into ticket values(276,3,3,0)
insert into ticket values(277,4,3,0)
insert into ticket values(278,3,4,0)
insert into ticket values(279,1,4,0)
insert into ticket values(280,4,3,0)
insert into ticket values(281,3,3,0)
insert into ticket values(282,2,2,0)
insert into ticket values(283,1,3,0)
insert into ticket values(284,3,1,0)
insert into ticket values(285,3,3,0)
insert into ticket values(286,4,3,0)
insert into ticket values(287,4,1,0)
insert into ticket values(288,2,3,0)
insert into ticket values(289,4,4,0)
insert into ticket values(290,3,2,0)
insert into ticket values(291,2,1,0)
insert into ticket values(292,2,3,0)
insert into ticket values(293,2,2,0)
insert into ticket values(294,2,1,0)
insert into ticket values(295,2,3,0)
insert into ticket values(296,4,4,0)
insert into ticket values(297,2,1,0)
insert into ticket values(298,2,4,0)
insert into ticket values(299,4,1,0)
insert into ticket values(300,2,1,0)
insert into ticket values(301,1,2,0)
insert into ticket values(302,2,1,0)
insert into ticket values(303,4,3,0)
insert into ticket values(304,3,4,0)
insert into ticket values(305,2,3,0)
insert into ticket values(306,3,3,0)
insert into ticket values(307,2,2,0)
insert into ticket values(308,2,4,0)
insert into ticket values(309,4,2,0)
insert into ticket values(310,2,4,0)
insert into ticket values(311,1,4,0)
insert into ticket values(312,1,4,0)
insert into ticket values(313,3,1,0)
insert into ticket values(314,3,2,0)
insert into ticket values(315,4,3,0)
insert into ticket values(316,4,4,0)
insert into ticket values(317,3,3,0)
insert into ticket values(318,3,1,0)
insert into ticket values(319,4,2,0)
insert into ticket values(320,3,3,0)
insert into ticket values(321,1,2,0)
insert into ticket values(322,1,4,0)
insert into ticket values(323,3,3,0)
insert into ticket values(324,4,3,0)
insert into ticket values(325,4,3,0)
insert into ticket values(326,3,3,0)
insert into ticket values(327,1,2,0)
insert into ticket values(328,1,1,0)
insert into ticket values(329,3,4,0)
insert into ticket values(330,1,2,0)
insert into ticket values(331,4,1,0)
insert into ticket values(332,2,2,0)
insert into ticket values(333,4,4,0)
insert into ticket values(334,3,1,0)
insert into ticket values(335,3,1,0)
insert into ticket values(336,3,1,0)
insert into ticket values(337,1,1,0)
insert into ticket values(338,1,1,0)
insert into ticket values(339,1,3,0)
insert into ticket values(340,4,4,0)
insert into ticket values(341,3,1,0)
insert into ticket values(342,4,4,0)
insert into ticket values(343,2,4,0)
insert into ticket values(344,1,1,0)
insert into ticket values(345,2,4,0)
insert into ticket values(346,1,2,0)
insert into ticket values(347,2,1,0)
insert into ticket values(348,1,3,0)
insert into ticket values(349,3,1,0)
insert into ticket values(350,3,4,0)
insert into ticket values(351,3,3,0)
insert into ticket values(352,2,2,0)
insert into ticket values(353,1,3,0)
insert into ticket values(354,3,4,0)
insert into ticket values(355,1,4,0)
insert into ticket values(356,3,4,0)
insert into ticket values(357,2,2,0)
insert into ticket values(358,1,3,0)
insert into ticket values(359,1,4,0)
insert into ticket values(360,1,1,0)
insert into ticket values(361,4,4,0)
insert into ticket values(362,1,3,0)
insert into ticket values(363,1,4,0)
insert into ticket values(364,4,2,0)
insert into ticket values(365,3,4,0)
insert into ticket values(366,2,3,0)
insert into ticket values(367,1,1,0)
insert into ticket values(368,2,3,0)
insert into ticket values(369,1,3,0)
insert into ticket values(370,1,1,0)
insert into ticket values(371,3,1,0)
insert into ticket values(372,3,4,0)
insert into ticket values(373,3,2,0)
insert into ticket values(374,3,1,0)
insert into ticket values(375,1,3,0)
insert into ticket values(376,1,1,0)
insert into ticket values(377,4,1,0)
insert into ticket values(378,1,2,0)
insert into ticket values(379,1,3,0)
insert into ticket values(380,3,1,0)
insert into ticket values(381,2,3,0)
insert into ticket values(382,4,3,0)
insert into ticket values(383,1,1,0)
insert into ticket values(384,2,3,0)
insert into ticket values(385,4,4,0)
insert into ticket values(386,1,4,0)
insert into ticket values(387,2,3,0)
insert into ticket values(388,1,2,0)
insert into ticket values(389,4,3,0)
insert into ticket values(390,1,2,0)
insert into ticket values(391,3,2,0)
insert into ticket values(392,3,1,0)
insert into ticket values(393,1,4,0)
insert into ticket values(394,2,4,0)
insert into ticket values(395,3,1,0)
insert into ticket values(396,1,3,0)
insert into ticket values(397,3,3,0)
insert into ticket values(398,1,3,0)
insert into ticket values(399,2,4,0)
insert into ticket values(400,2,1,0)
insert into ticket values(401,4,3,0)
insert into ticket values(402,4,1,0)
insert into ticket values(403,1,3,0)
insert into ticket values(404,4,1,0)
insert into ticket values(405,4,1,0)
insert into ticket values(406,2,1,0)
insert into ticket values(407,4,3,0)
insert into ticket values(408,2,3,0)
insert into ticket values(409,2,4,0)
insert into ticket values(410,3,1,0)
insert into ticket values(411,3,4,0)
insert into ticket values(412,1,2,0)
insert into ticket values(413,4,4,0)
insert into ticket values(414,2,1,0)
insert into ticket values(415,1,3,0)
insert into ticket values(416,4,2,0)
insert into ticket values(417,4,3,0)
insert into ticket values(418,4,3,0)
insert into ticket values(419,4,2,0)
insert into ticket values(420,2,3,0)
insert into ticket values(421,4,2,0)
insert into ticket values(422,4,3,0)
insert into ticket values(423,1,4,0)
insert into ticket values(424,4,3,0)
insert into ticket values(425,1,4,0)
insert into ticket values(426,3,2,0)
insert into ticket values(427,3,4,0)
insert into ticket values(428,2,1,0)
insert into ticket values(429,3,4,0)
insert into ticket values(430,3,1,0)
insert into ticket values(431,1,1,0)
insert into ticket values(432,3,4,0)
insert into ticket values(433,1,2,0)
insert into ticket values(434,4,2,0)
insert into ticket values(435,2,2,0)
insert into ticket values(436,4,2,0)
insert into ticket values(437,3,1,0)
insert into ticket values(438,1,4,0)
insert into ticket values(439,1,4,0)
insert into ticket values(440,1,3,0)
insert into ticket values(441,1,3,0)
insert into ticket values(442,2,3,0)
insert into ticket values(443,4,3,0)
insert into ticket values(444,3,2,0)
insert into ticket values(445,2,4,0)
insert into ticket values(446,4,1,0)
insert into ticket values(447,1,4,0)
insert into ticket values(448,2,1,0)
insert into ticket values(449,1,1,0)
insert into ticket values(450,1,3,0)



create procedure SP_USUARIO_PASS(
	@usuario varchar(50),
	@contraseña varchar(50)
)
as
	select usuario,contraseña
	from VENDEDORES
	where usuario = @usuario and contraseña = @contraseña

go

create procedure SP_OBTENER_VENDEDOR(
	@usuario varchar(50)
)as
	select id_vendedor,p.id_persona, nombre,apellido,direccion,nro_direccion,id_barrio,nro_doc,id_tipo_doc,fecha_nacimiento,Sexo
	from VENDEDORES v
	join PERSONAS p on v.id_persona = p.id_persona
	where usuario = @usuario

go

create procedure SP_OBTENER_CLIENTE
as
	select id_cliente,p.id_persona, nombre,apellido,direccion,nro_direccion,b.id_barrio,nro_doc,tp.id_tipo_doc,fecha_nacimiento,Sexo,tp.tipo_documento,prov.id_provincia,l.id_localidad
	from CLIENTES c
	join PERSONAS p on c.id_persona = p.id_persona
	join TIPOS_DE_DOCUMENTOS tp on tp.id_tipo_doc = p.id_tipo_doc
	join BARRIOS b on p.id_barrio = b.id_barrio
	join LOCALIDADES l on l.id_localidad = b.id_localidad
	join PROVINCIAS prov on prov.id_provincia = l.id_provincia
	where baja_logica = 0




go

create or alter procedure SP_OBTENER_VendedorCrud
as
	select c.id_vendedor,p.id_persona, nombre,apellido,direccion,nro_direccion,b.id_barrio,nro_doc,tp.id_tipo_doc,fecha_nacimiento,Sexo,tp.tipo_documento,prov.id_provincia,l.id_localidad, lv.adminn, lv.usuario,lv.contraseña
	from VENDEDORES c
	join PERSONAS p on c.id_persona = p.id_persona
	join TIPOS_DE_DOCUMENTOS tp on tp.id_tipo_doc = p.id_tipo_doc
	join BARRIOS b on p.id_barrio = b.id_barrio
	join LOCALIDADES l on l.id_localidad = b.id_localidad
	join PROVINCIAS prov on prov.id_provincia = l.id_provincia
	join login_vend lv on lv.id_vendedor = c.id_vendedor
	where c.baja_logica = 0
go
create procedure SP_CBO_TIPO_DOC
as
	select *
	from TIPOS_DE_DOCUMENTOS

go

-------------------------------------------CBO BARRIOS-------------------------------


--PROCEDIMIENTOS
create procedure SP_CBO_PROVINCIA
as
	select *
	from PROVINCIAS

go

create procedure SP_CBO_LOCALIDAD(
	@id_provincia int)
as
select *
from LOCALIDADES
where id_provincia = @id_provincia

go

create procedure SP_CBO_BARRIO(
	@id_localidad int
)as
select *
from BARRIOS 
where id_localidad = @id_localidad


----------------------------------------------------------------------------------------------------------------------------------------------------

go

create procedure SP_ALTA_CLIENTE(
	@nombre varchar (100),
	@apellido varchar (100),
	@direccion varchar (100),
	@nro_direccion int, 
	@id_barrio int,
	@id_tipo_doc int,
	@nro_doc bigint,
	@fecha_nacimiento datetime,
	@Sexo int
)AS
	insert into PERSONAS values(@nombre,@apellido,@direccion,@nro_direccion,@id_barrio,@id_tipo_doc,@nro_doc,@fecha_nacimiento,@Sexo)

	declare @next int
	select @next = (MAX(id_persona))
	from PERSONAS

	insert into CLIENTES values(@next,0)

go

create or alter procedure SP_ALTA_Vendedor(
	@nombre varchar (100),
	@apellido varchar (100),
	@direccion varchar (100),
	@nro_direccion int, 
	@id_barrio int,
	@id_tipo_doc int,
	@nro_doc bigint,
	@fecha_nacimiento datetime,
	@Sexo int,
	@usuario varchar(200),
	@contraseña varchar(200),
	@admin int
)AS
	insert into PERSONAS values(@nombre,@apellido,@direccion,@nro_direccion,@id_barrio,@id_tipo_doc,@nro_doc,@fecha_nacimiento,@Sexo)

	declare @next int
	select @next = (MAX(id_persona))
	from PERSONAS
	insert into VENDEDORES values(@next,0)

	declare @next_ven int
	select @next_ven = (MAX(id_vendedor))
	from VENDEDORES

	insert into login_vend values(@usuario, @contraseña,@next_ven,@admin,0)



go


create procedure SP_BAJA_CLIENTE(
	@id_cliente int
)as
update CLIENTES
set baja_logica = 1
where id_cliente = @id_cliente

go

create or alter procedure SP_BAJA_Vendedor(
	@id_vendedor int
)as
update VENDEDORES
set baja_logica = 1
where id_vendedor = @id_vendedor

update login_vend
set baja_logica = 1
where id_vendedor = @id_vendedor
go

create procedure SP_MODIFY_CLIENTE(
	@id_persona int,
	@direccion varchar (100),
	@nro_direccion int, 
	@id_barrio int,
	@id_tipo_doc int,
	@nro_doc bigint
)as
	update PERSONAS
	set 
		direccion = @direccion,
		nro_direccion = @nro_direccion,
		id_barrio = @id_barrio,
		id_tipo_doc = @id_tipo_doc,
		nro_doc = @nro_doc
	where id_persona = @id_persona
go
create procedure SP_MODIFY_vendedor(
	@id_persona int,
	@direccion varchar (100),
	@nro_direccion int, 
	@id_barrio int,
	@id_tipo_doc int,
	@nro_doc bigint,
	@usuario varchar(200),
	@contraseña varchar(200),
	@admin int,
	@id_vendedor int
)as
	update PERSONAS
	set 
		direccion = @direccion,
		nro_direccion = @nro_direccion,
		id_barrio = @id_barrio,
		id_tipo_doc = @id_tipo_doc,
		nro_doc = @nro_doc
	where id_persona = @id_persona

	update login_vend
	set usuario = @usuario,
		contraseña = @contraseña,
		adminn = @admin
	where id_vendedor = @id_vendedor
go
create procedure SP_BUSCAR_CLIENTE(
	@id_cliente int
)as
	select * from CLIENTES
	where id_cliente = @id_cliente
go

create procedure SP_BUSCAR_Vendedor(
	@id_Vendedor int
)as
	select * from VENDEDORES
	where id_vendedor = @id_Vendedor

go

create procedure SP_BUSCAR_PERSONA(
	@id_cliente int
)as
	select p.id_persona, nombre, apellido,direccion,nro_direccion,id_barrio,tp.id_tipo_doc,nro_doc,fecha_nacimiento,Sexo,tp.tipo_documento
	from CLIENTES c 
	join PERSONAS p on c.id_persona = p.id_persona
	join TIPOS_DE_DOCUMENTOS tp on tp.id_tipo_doc = p.id_tipo_doc
	where id_cliente = @id_cliente
	
go

create procedure SP_BUSCAR_PELICULAS
as
	Select distinct f.id_pelicula, p.titulo
	from FUNCION f
	join PELICULA p on f.id_pelicula= p.id_pelicula
	where f.baja_logica = 0

go

create or alter procedure SP_CARGAR_FECHAS(
	@id_pelicula int
)
as
	Select distinct CONVERT(varchar,fecha,3)'fecha'
	from FUNCION f
	where id_pelicula = @id_pelicula AND baja_logica = 0
	order by fecha asc


go

create procedure SP_CARGAR_HORARIOS(
	@id_pelicula int,
	@fecha datetime
)
as
	Select distinct f.id_horario, h.hora + ':00'HORA
	from FUNCION f
	join HORARIO h on f.id_horario = h.id_horario
	where id_pelicula = @id_pelicula  and f.fecha = @fecha and f.baja_logica = 0
	order by 2

go


create procedure SP_CARGAR_IDIOMAS_FUN(
	@id_pelicula int,
	@fecha datetime,
	@id_horario int
)
as
	Select distinct f.id_idioma, idioma
	from FUNCION f
	join IDIOMAS h on f.id_idioma = h.id_idioma
	where id_pelicula = @id_pelicula and f.fecha = @fecha and id_horario = @id_horario

go

create procedure SP_CARGAR_IDIOMAS
AS
	SELECT id_idioma, idioma
	from IDIOMAS


create or alter procedure SP_cARGAR_HORARIO
AS

	select id_horario, concat(hora, ':00')
	from HORARIO
	order by hora
go
create procedure SP_CARGAR_TIPO_SALA(
	@id_pelicula int,
	@fecha datetime,
	@id_horario int,
	@id_idioma int
)
as
	Select distinct f.id_sala, str(f.id_sala) + '-'+ t.tipo_sala'Sala'
	from FUNCION f
	join SALA h on f.id_sala = h.id_sala
	join TIPO_DE_SALA t on h.id_sala = t.id_tipo_sala 
	where id_pelicula = @id_pelicula and f.fecha = @fecha and id_horario = @id_horario

go

create or alter procedure SP_TIPO_SALA
as
	select id_tipo_sala, tipo_sala
	from TIPO_DE_SALA
	order by tipo_sala


create or alter procedure SP_CARGAR_ID_FUNCION(
	@id_pelicula int,
	@fecha datetime,
	@id_horario int,
	@id_idioma int,
	@id_sala int
)
as
	Select id_funcion, monto
	from FUNCION f
	where id_pelicula = @id_pelicula and f.fecha = @fecha and id_horario = @id_horario and id_idioma = @id_idioma and id_sala = @id_sala

	select * from FUNCION
	where baja_logica = 0

go

create or alter procedure OBTENER_FUNCIONES
AS
	SELECT id_funcion,fecha,i.id_idioma, i.idioma,p.id_pelicula,p.titulo,s.id_sala,ts.tipo_sala,h.id_horario,concat(h.hora,':00'),monto,s.id_tipo_sala
	FROM FUNCION f
	join IDIOMAS i on i.id_idioma = f.id_idioma
	join PELICULA p on p.id_pelicula = f.id_pelicula
	join HORARIO h on h.id_horario = f.id_horario
	join sala s on s.id_sala = f.id_sala
	join TIPO_DE_SALA ts on ts.id_tipo_sala = s.id_tipo_sala
	WHERE f.baja_logica = 0
	order by fecha

go


create procedure buscar_Fun(
	@id_fun int
)
as
	select *
	from FUNCION
	where @id_fun = id_funcion

go


create or alter procedure Bajar_Fun(
	@id_fun int
)as
	update FUNCION
	set baja_logica = 1
	where id_funcion = @id_fun

select * from FUNCION
GO
CREATE or alter PROCEDURE SP_INSER_FUN(
	@FECHA DATETIME,
	@ID_IDIOMA INT,
	@ID_PELICULA INT,
	@ID_SALA INT,
	@ID_HORARIO INT,
	@MONTO MONEY
)
AS

	INSERT INTO FUNCION(fecha,id_idioma,id_pelicula,id_sala,id_horario,monto,baja_logica) VALUES (@FECHA,@ID_IDIOMA,@ID_PELICULA,@ID_SALA,@ID_HORARIO,@MONTO,0)

GO
CREATE or alter PROCEDURE SP_update_FUN(
	@id_funcion int,
	@FECHA DATETIME,
	@ID_IDIOMA INT,
	@ID_PELICULA INT,
	@ID_SALA INT,
	@ID_HORARIO INT,
	@MONTO MONEY
)
AS

	update FUNCION
	set 
		id_pelicula = @ID_PELICULA,
		fecha = @FECHA,
		id_idioma = @ID_IDIOMA,
		id_sala = @ID_SALA,
		id_horario = @ID_HORARIO,
		monto = @MONTO
	where id_funcion = @id_funcion

GO
create procedure SP_CARGAR_BUTACAS_LIBRES(
	@id_sala int,
	@id_funcion int
)as

	select ID_BUTACA_SALA , b.FILA + str(b.NRO)'Butaca' 
	from BUTACA_SALA bs
	join BUTACA b on bs.ID_BUTACA = b.ID_BUTACA
	where ID_SALA = @id_sala and id_butaca_sala not in(select t.id_butaca_sala
								from TICKET t
								join COMPROBANTE c on c.id_comprobante = t.id_comprobante
								join FUNCION f on c.id_funcion = f.id_funcion
								join BUTACA_SALA bs on bs.ID_BUTACA_SALA = t.id_butaca_sala 
								where f.id_funcion = @id_funcion and t.Baja_logica = 1)

go

create procedure SP_CARGA_FORMA_PAGO
as
select  * from FORMA_PAGO

go

create procedure SP_CARGA_TIPO_COMPRA
as
select  * from TIPO_COMPRA

go

create or alter procedure SP_CARGA_CBO_CLIENTE
as
select id_cliente, p.nombre + p.apellido + STR(p.nro_doc)'cliente'
from CLIENTES c
join PERSONAS p on c.id_persona = p.id_persona
where baja_logica = 0

go

create procedure SP_INSERTAR_FACTURA_PAGADA(
	@fecha_reserva datetime,
	@id_vendedor int,
	@id_cliente int,
	@fecha_pago datetime,
	@id_tipo_compra int,
	@id_forma_pago int,
	@id int output
)as	
	insert into FACTURA values(@id_vendedor,@id_cliente,@fecha_pago,@id_tipo_compra,@id_forma_pago,0)
	insert into RESERVA values(@fecha_reserva,0)
	SET @id = SCOPE_IDENTITY();

go

create procedure SP_INSERTAR_FACTURA_POSPUESTA(
	@fecha_reserva datetime,
	@id_vendedor int,
	@id_cliente int,
	@id int output
)as
	insert into FACTURA values(@id_vendedor,@id_cliente,null,null,null,0)
	insert into RESERVA values(@fecha_reserva,0)
	SET @id = SCOPE_IDENTITY();

go

create procedure SP_INSERTAR_COMPROBANTE(
	@id_funcion int,
	@cantidad int,
	@id_factura int,
	@monto money,
	@id_promocion int,
	@fecha_fun datetime,
	@id int output

)as
	insert into COMPROBANTE values(@id_funcion,@cantidad,@id_factura,@monto,@id_promocion,0,@fecha_fun)
	SET @id = SCOPE_IDENTITY();

go

create procedure INSERTAR_TICKET(
	 @id_comprobante int,
	 @id_butaca_sala int
)
as	
	insert into TICKET (id_comprobante,id_butaca_sala,Baja_logica) values(@id_comprobante,@id_butaca_sala,1)

go

create procedure SP_TIPO_PROMO
AS
SELECT * FROM TIPOS_DE_DOCUMENTOS

go

create or alter procedure SP_FACTURAS
as
select f.id_factura, v.id_vendedor, p1.nombre,p1.apellido,
c.id_cliente, p.nombre,p.apellido, fecha_pago, r.FECHA_RESERVA, tp.id_tipo_compra,tp.tipo_compra,fp.id_forma_pago,fp.forma_pago,f.baja_logica
from FACTURA f
join VENDEDORES v on f.id_vendedor = v.id_vendedor
join CLIENTES c on f.id_cliente = c.id_cliente
left join TIPO_COMPRA tp on f.id_tipo_compra = tp.id_tipo_compra
join PERSONAS p on c.id_persona = p.id_persona
join PERSONAS p1 on v.id_persona = p1.id_persona
left join FORMA_PAGO fp on f.id_forma_pago = fp.id_forma_pago
left join RESERVA r on f.id_factura = r.id_factura
where DATEDIFF(MONTH,FECHA_RESERVA,GETDATE()) < 3
order by id_factura desc

go

create or alter procedure SP_FACTURAS_cocretadas
as
select f.id_factura, v.id_vendedor, p1.nombre,p1.apellido,
c.id_cliente, p.nombre,p.apellido, fecha_pago, r.FECHA_RESERVA, tp.id_tipo_compra,tp.tipo_compra,fp.id_forma_pago,fp.forma_pago,f.baja_logica
from FACTURA f
join VENDEDORES v on f.id_vendedor = v.id_vendedor
join CLIENTES c on f.id_cliente = c.id_cliente
join TIPO_COMPRA tp on f.id_tipo_compra = tp.id_tipo_compra
join PERSONAS p on c.id_persona = p.id_persona
join PERSONAS p1 on v.id_persona = p1.id_persona 
join FORMA_PAGO fp on f.id_forma_pago = fp.id_forma_pago 
join RESERVA r on f.id_factura = r.id_factura
order by id_factura desc
go

create or alter procedure SP_FACTURAS_cocretadas_filtered
( @nombre varchar(200))
as
select f.id_factura, v.id_vendedor, p1.nombre,p1.apellido,
c.id_cliente, p.nombre,p.apellido, fecha_pago, r.FECHA_RESERVA, tp.id_tipo_compra,tp.tipo_compra,fp.id_forma_pago,fp.forma_pago,f.baja_logica
from FACTURA f
join VENDEDORES v on f.id_vendedor = v.id_vendedor
join CLIENTES c on f.id_cliente = c.id_cliente
join TIPO_COMPRA tp on f.id_tipo_compra = tp.id_tipo_compra
join PERSONAS p on c.id_persona = p.id_persona
join PERSONAS p1 on v.id_persona = p1.id_persona 
join FORMA_PAGO fp on f.id_forma_pago = fp.id_forma_pago 
join RESERVA r on f.id_factura = r.id_factura
where p.nombre + space(1)+ p.apellido like CONCAT(@nombre, '%')
order by id_factura desc
go

create procedure SP_CARGAR_Comprobante(
	@id_factura int
)as
	select id_comprobante,f.id_funcion, i.id_idioma,i.idioma,p.id_promocion,p.promocion,ts.id_tipo_promocion,ts.tipo_promocion,
	pe.id_pelicula,pe.titulo, f.id_sala, s.id_tipo_sala, tp.tipo_sala,h.id_horario,h.hora,c.monto,f.fecha,c.cantidad
	from COMPROBANTE c
	join FUNCION f on f.id_funcion = c.id_funcion
	join PROMOCION p on p.id_promocion = c.id_promocion
	join TIPO_PROMOCION ts on ts.id_tipo_promocion = p.id_tipo_promocion
	join IDIOMAS i on f.id_idioma = i.id_idioma
	join PELICULA pe on pe.id_pelicula = f.id_pelicula
	join SALA s on s.id_sala = f.id_sala
	join TIPO_DE_SALA tp on tp.id_tipo_sala = s.id_tipo_sala
	join HORARIO h on f.id_horario = h.id_horario
	where id_factura = @id_factura

go

create procedure SP_ACTUALIZAR_PAGO(
	@id_factura int,
	@id_tipo_compra int,
	@id_forma_pago int
)as

	update FACTURA
	set 
		id_tipo_compra = @id_tipo_compra,
		id_forma_pago = @id_forma_pago,
		fecha_pago = GETDATE()
		Where id_factura = @id_factura

go

create procedure SP_CARGA_CBO_VENDEDOR
as
select id_vendedor, p.nombre + SPACE(1) + p.apellido 'vendedor'
from VENDEDORES c
join PERSONAS p on c.id_persona = p.id_persona

go

create or alter procedure SP_CARGA_CBO_CLIENT
as
select id_cliente, p.nombre + SPACE(1) + p.apellido 'cliente'
from CLIENTES c
join PERSONAS p on c.id_persona = p.id_persona
where baja_logica = 0


go


CREATE PROCEDURE SP_CARGA_RESTRICCION AS
	SELECT id_restriccion, edad
	FROM RESTRICION_DE_EDAD

go

CREATE PROCEDURE SP_CARGA_PROD AS
	SELECT id_producto, nombre
	FROM PRODUCTOR





go


create procedure SP_TICKETS_DIARIO
as
	select count(id_ticket)
	from TICKET t
	join COMPROBANTE c on t.id_comprobante = c.id_comprobante
	JOIN FACTURA F ON  F.id_factura = c.id_factura
	where DAY(F.fecha_pago) = day(GETDATE()) and month(F.fecha_pago) = month(GETDATE()) and year(F.fecha_pago) = year(GETDATE())
	group by DAY(F.fecha_pago), month(F.fecha_pago), year(F.fecha_pago)

go

create procedure SP_MONTO_DIARIO 
AS
	select SUM(cantidad * monto)
	From  COMPROBANTE c 
	JOIN FACTURA F ON  F.id_factura = c.id_factura
	where DAY(F.fecha_pago) = day(GETDATE()) and month(F.fecha_pago) = month(GETDATE()) and year(F.fecha_pago) = year(GETDATE())


go


CREATE PROCEDURE SP_MEJOR_PELICULA
AS
	select imagen
	from PELICULA
	where id_pelicula in (select id_pelicula
			from COMPROBANTE c
			join FUNCION f on c.id_funcion = f.id_funcion
			group by f.id_pelicula
			having SUM(cantidad) >= all (select SUM(cantidad)
										  from COMPROBANTE c
										  join FUNCION f on c.id_funcion = f.id_funcion
										  group by f.id_pelicula))

						  
go

create or alter procedure SP_BAJAR_FUNCIONES(
	@fecha datetime
)as

	UPDATE FUNCION
	SET baja_logica = 1
	WHERE id_funcion in (select id_funcion from FUNCION f
						join HORARIO h on h.id_horario = f.id_horario
						where fecha <= @fecha-1 or (fecha <= @fecha and Convert(int,(h.hora)) <=  Convert(int,LEFT(CONVERT(varchar(19),GETDATE(),108),2))))

go



create procedure SP_BAJA_FACTURA
as
	UPDATE FACTURA
	set baja_logica =1 
	where id_factura in (select f.id_factura
						from FACTURA f
						join COMPROBANTE c on f.id_factura = c.id_factura
						join FUNCION fu on fu.id_funcion = c.id_funcion
						JOIN HORARIO h on h.id_horario = fu.id_horario
						where (Convert(int, h.hora)- Convert(int,LEFT(convert(char(8), getdate(), 108),2))) <= 2 and fecha_pago is null and DAY(fu.fecha) = day(GETDATE()) and month(fu.fecha) = month(GETDATE()) and year(fu.fecha) = year(GETDATE()))
	update COMPROBANTE
	set baja_logica =1
	where id_factura in (select f.id_factura
						from FACTURA f
						join COMPROBANTE c on f.id_factura = c.id_factura
						join FUNCION fu on fu.id_funcion = c.id_funcion
						JOIN HORARIO h on h.id_horario = fu.id_horario
						where (Convert(int, h.hora) - Convert(int,LEFT(convert(char(8), getdate(), 108),2))) <= 2 and fecha_pago is null and DAY(fu.fecha) = day(GETDATE()) and month(fu.fecha) = month(GETDATE()) and year(fu.fecha) = year(GETDATE()))
	
	update TICKET
	set Baja_logica = 0
	where id_comprobante in (select id_comprobante
							 from COMPROBANTE
							 where baja_logica = 1)

go

CREATE or alter PROCEDURE SP_CARGAR_PELICULA
AS
SELECT P.id_pelicula, P.TITULO, P.duracion, PR.nombre,RE.EDAD, SUM(cantidad)'ESPECTADORES'
FROM PELICULA P
JOIN PRODUCTOR PR  ON P.id_productor = PR.id_producto
JOIN RESTRICION_DE_EDAD RE ON RE.id_restriccion = P.id_restriccion
JOIN FUNCION F ON F.id_pelicula = P.id_pelicula
left JOIN COMPROBANTE C ON C.id_funcion = F.id_funcion
GROUP BY P.id_pelicula, P.TITULO, P.duracion, PR.nombre,RE.EDAD
order by p.id_pelicula
go

CREATE or alter PROCEDURE SP_CARGAR_PELICULA_crud
AS
SELECT P.id_pelicula, P.TITULO, P.duracion, PR.nombre,RE.EDAD, p.id_restriccion, p.id_productor,p.descripcion,p.imagen
FROM PELICULA P
JOIN PRODUCTOR PR  ON P.id_productor = PR.id_producto
JOIN RESTRICION_DE_EDAD RE ON RE.id_restriccion = P.id_restriccion
where baja_logica = 0
order by p.id_pelicula
go


create or alter procedure BAJAR_PELICULA(
	@id_pel int
)as
	update PELICULA
	set baja_logica = 1
	where id_pelicula = @id_pel


create or alter procedure Buscar_Peli(
	@id_pel int
)as
	select id_pelicula
	from PELICULA
	where id_pelicula = @id_pel

	select * from PELICULA

create or alter procedure Update_Peli(
	@id_pel int,
	@titulo varchar(100),
	@descripcion varchar(500),
	@id_restriccion int,
	@id_productor int,
	@duracion int,
	@imagen Image
)as

	update PELICULA
	set
		titulo = @titulo,
		descripcion = @descripcion,
		id_restriccion = @id_restriccion,
		id_productor = @id_productor,
		duracion = @duracion,
		imagen = @imagen
	where id_pelicula = @id_pel
		
create or alter procedure SP_OBTENER_PELISCBO
as
	select id_pelicula, titulo
	from pelicula
	where baja_logica = 0

create or alter procedure InsertPeli(
	@titulo varchar(100),
	@descripcion varchar(500),
	@id_restriccion int,
	@id_productor int,
	@duracion int,
	@imagen Image
)as

	insert into PELICULA values(@duracion,@id_restriccion,@id_productor,@titulo,@descripcion,@imagen,0)

CREATE or alter PROCEDURE SP_CARGAR_PELICULA_Nombre
(@nombre varchar(50))
AS
SELECT P.id_pelicula, P.TITULO, P.duracion, PR.nombre,RE.EDAD, SUM(cantidad)'ESPECTADORES'
FROM PELICULA P
JOIN PRODUCTOR PR  ON P.id_productor = PR.id_producto
JOIN RESTRICION_DE_EDAD RE ON RE.id_restriccion = P.id_restriccion
JOIN FUNCION F ON F.id_pelicula = P.id_pelicula
left JOIN COMPROBANTE C ON C.id_funcion = F.id_funcion
where p.titulo like CONCAT(@nombre, '%')
GROUP BY P.id_pelicula, P.TITULO, P.duracion, PR.nombre,RE.EDAD
order by p.id_pelicula
go

create or alter procedure SP_CARGAR_GRILLA_CLIENTE
    as
    select c.id_cliente,nombre,apellido,nro_doc,fecha_nacimiento,sexo,id_tipo_doc,sum(cantidad*monto)'Monto'
    from clientes c join personas p on p.id_persona = c.id_persona
    left join FACTURA f on c.id_cliente = f.id_cliente
    left join COMPROBANTE co on co.id_factura = f.id_factura
    group by c.id_cliente,nombre,apellido ,nro_doc,fecha_nacimiento,sexo,id_tipo_doc
	Order by c.id_cliente

go

create or alter procedure SP_CARGAR_GRILLA_CLIENTE_nombre
(@nombre varchar(100))
    as
    select c.id_cliente,nombre,apellido,nro_doc,fecha_nacimiento,sexo,id_tipo_doc,sum(cantidad*monto)'Monto'
    from clientes c join personas p on p.id_persona = c.id_persona
    left join FACTURA f on c.id_cliente = f.id_cliente
    left join COMPROBANTE co on co.id_factura = f.id_factura
	where nombre+ SPace(1)+ apellido like CONCAT(@nombre, '%') 
    group by c.id_cliente,nombre,apellido ,nro_doc,fecha_nacimiento,sexo,id_tipo_doc
	Order by c.id_cliente

go

create procedure  sp_filtro_cliente_fec(
@fecha1 datetime,
@fecha2 datetime)
as
select c.id_cliente,nombre,apellido,nro_doc,fecha_nacimiento,sexo,id_tipo_doc,sum(cantidad*monto)'Monto'
    from clientes c join personas p on p.id_persona = c.id_persona
     join FACTURA f on c.id_cliente = f.id_cliente
     join COMPROBANTE co on co.id_factura = f.id_factura
	 join RESERVA r on f.id_factura=r.id_factura
	where r.FECHA_RESERVA between @fecha1 and @fecha2
    group by c.id_cliente,nombre,apellido ,nro_doc,fecha_nacimiento,sexo,id_tipo_doc


create or alter procedure  sp_filtro_cliente_fec_filter(
@fecha1 datetime,
@fecha2 datetime,
@nombre varchar(100))
as
select c.id_cliente,nombre,apellido,nro_doc,fecha_nacimiento,sexo,id_tipo_doc,sum(cantidad*monto)'Monto'
    from clientes c join personas p on p.id_persona = c.id_persona
     join FACTURA f on c.id_cliente = f.id_cliente
     join COMPROBANTE co on co.id_factura = f.id_factura
	 join RESERVA r on f.id_factura=r.id_factura
	where r.FECHA_RESERVA between @fecha1 and @fecha2 and nombre+ SPace(1)+ apellido like CONCAT(@nombre, '%')
    group by c.id_cliente,nombre,apellido ,nro_doc,fecha_nacimiento,sexo,id_tipo_doc

 ----------------------------------------------------------------------------------------------------------------------------------------


 select * from FACTURA
 select * from RESERVA
 select * from
 PERSONAS

 select *
 from CLIENTES


 create or alter procedure SP_CARGAR_BUTACAS_Prueba(
	@id_sala int,
	@id_funcion int
)as

	select bs.ID_BUTACA_SALA , b.FILA, b.NRO, t.Baja_logica
	from BUTACA_SALA bs
	left join BUTACA b on bs.ID_BUTACA = b.ID_BUTACA
	left join TICKET t on bs.ID_BUTACA_SALA = t.id_butaca_sala
	left join COMPROBANTE c on t.id_comprobante = c.id_comprobante
	where c.id_funcion = @id_funcion and bs.ID_SALA =@id_sala and t.Baja_logica = 1

go

 create or alter procedure SP_CARGAR_BUTACAS_Ocupada(
	@id_sala int,
	@id_funcion int,
	@id_comprobante int
)as

	select bs.ID_BUTACA_SALA , b.FILA, b.NRO, t.Baja_logica
	from BUTACA_SALA bs
	left join BUTACA b on bs.ID_BUTACA = b.ID_BUTACA
	left join TICKET t on bs.ID_BUTACA_SALA = t.id_butaca_sala
	left join COMPROBANTE c on t.id_comprobante = c.id_comprobante
	where c.id_funcion = @id_funcion and bs.ID_SALA =@id_sala and t.id_comprobante = @id_comprobante


go 
create procedure sp_obtener_provincia
as
begin 
select id_provincia, provincia from PROVINCIAS
end

go

create procedure sp_obtener_localidad(@id_provincia int)
as
begin 
select id_localidad, localidad from LOCALIDADES where @id_provincia = id_localidad
end

go

create procedure sp_obtener_barrio(@id_localidad int)
as
begin
select id_barrio, barrio from BARRIOS where @id_localidad = id_localidad
end



















DBCC CHECKIDENT ('TICKET', RESEED,0) 

alter table TICKET
Alter column Baja_logica int


select COUNT(s.id_sala)
from SALA s
join BUTACA_SALA bs on bs.ID_SALA = s.id_sala
join BUTACA b on b.ID_BUTACA = bs.ID_BUTACA
where s.id_sala = 5
group by s.id_sala

select * from BUTACA_SALA bs
join BUTACA b on bs.ID_BUTACA = b.ID_BUTACA
where ID_SALA = 3

delete BUTACA
delete BUTACA_SALA
delete TICKET

DBCC CHECKIDENT ('BUTACA_SALA', RESEED,0) 
select * from BUTACA_SALA

select * from BARRIOS



create procedure SP_BAJAR_FACTURA
(@id_factura int)
as
	UPDATE FACTURA
	set baja_logica =1 
	where id_factura = @id_factura
	

	update COMPROBANTE
	set baja_logica =1
	where id_factura = @id_factura


	update TICKET
	set Baja_logica = 0
	where id_comprobante in (select id_comprobante
							 from COMPROBANTE
							 where id_factura = @id_factura)