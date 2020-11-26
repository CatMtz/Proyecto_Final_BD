create database ProyectoBD;
use proyectobd;

create table Usuario(
IdUsuario int primary key auto_increment not null,
IdCarrito int not null,
Nombre varchar(20) not null,
Apellidos varchar(30) not null,
UserName varchar(10) not null,
password varchar(40) not null,
Tipo enum ('Cliente','Administrador'),
foreign key Usuario(IdCarrito) references Carrito(IdCarrito)
);

create table Producto(
IdProducto int primary key auto_increment not null,
Nombre varchar(35) not null,
Precio decimal(10,2) not null,	
Descripcion varchar(50),
Categoria varchar(15) not null
);


create table carrito(
idCarrito int primary key auto_increment not null,
idUsuario int not null,
idProducto int not null,
NombreProd varchar(20) not null,
Precio int not null,
foreign key Carrito(IdProducto) references Producto(IdProducto),
foreign key usuario(Idusuario) references Usuario(IdUsuario));

select *,count(*) as cantidad , sum(precio) as total from carrito where idusuario=3 group by idproducto;

create table detalleproducto(
idCarrito int not null,
idProducto int not null,
Precio int not null,
foreign key detalle(IdCarrito) references Carrito(Idcarrito),
foreign key producto(IdProducto) references Producto(IdProducto)
);
create table venta(
idVenta int primary key auto_increment not null,
idCarrito int not null,
Idusuario int not null,
Descripcion text,
foreign key carrito(idCarrito) references Carrito(IdCarrito)
);

create table log_Registro(
idlog int primary key auto_increment not null,
fecha datetime not null,
idusuario varchar(50) not null,
total decimal(10,2) not null
);

DELIMITER $$
create trigger log_registros
after insert
on venta for each row
begin
insert into log_Registro values(default,now(),new.idusuario);
end $$
