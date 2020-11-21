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
Precio int not null,	
Descripcion varchar(50),
Categoria varchar(15) not null,
foreign key Producto(IdProveedor) references Proveedor(IdProveedor)
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
