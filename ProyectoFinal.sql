create database ProyectoBD;
use proyectobd;


create table Usuario(
IdUsuario int primary key auto_increment not null,
Nombre varchar(20) not null,
Apellidos varchar(30) not null,
UserName varchar(10) not null,
password varchar(40) not null,
Tipo enum ('Cliente','Administrador')
);
alter table producto modify column Nombre varchar(35) not null;

create table Producto(
IdProducto int primary key auto_increment not null,
Nombre varchar(35) not null,
Precio int not null,	
Descripcion varchar(50),
Categoria varchar(15) not null,
foreign key Producto(IdProveedor) references Proveedor(IdProveedor)
);

select * from producto;
create table Nota(
IdNota int primary key auto_increment not null,
Idusuario int not null,
Descripcion text not null,
foreign key Nota(IdUsuario) references Usuario(IdUsuario)
);

create table carrito(
idCarrito int primary key auto_increment not null,
idProducto int not null,
NombreProd varchar(20) not null,
Precio decimal not null,
cantidad int not null);

INSERT INTO `proyectobd`.`proveedor` VALUES('T2GO','4451234567','Uriangato');

INSERT INTO `proyectobd`.`producto` VALUES(default,'NIKE XP',180,' ','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'SOCK DART',180,' ','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(59,'TENIS TRECK 501',180,' ','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'PUMA ROMA ',180,'AMARILLO','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'AFI NIKE',180,'NEGRO TOTAL','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'TRECK 1010 ',180,'BLANCO PLATA','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'ADIDAS',180,'CONCHA FRANCIA','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'VANS 500',180,'OXFORD','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'PUMA',180,'TRANSFORT 8.5','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'N-020 7.5',180,' ','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'ADIDAS 006',180,'NEGRO BLANCO','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'NIKE 1070 6',180,'','Varios');
INSERT INTO `proyectobd`.`producto` VALUES(default,'NIKE',180,'NEGRO NEON','Varios');


 -- delete from producto where idproducto=20;
-- drop table producto;
INSERT INTO `proyectobd`.`usuario`VALUES(default,'Omar','Martinez Gaytan','Cat1106',12345678,'Administrador');
INSERT INTO `proyectobd`.`usuario`VALUES(default,'Gato','Martinez Gaytan','Cat0610',12345678,'Cliente');

select * from usuario;
select * from producto;


