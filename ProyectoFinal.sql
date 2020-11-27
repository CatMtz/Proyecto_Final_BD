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

drop table carrito;
drop table detalleproducto;

create table carrito(
idCarrito int primary key auto_increment not null,
idUsuario int not null,
NombreProd varchar(20) not null,
FechaCompra datetime not null,
foreign key usuario(Idusuario) references Usuario(IdUsuario));
select * from carrito;
insert into carrito values(1,5,'Tenis',now());
insert into detalleproducto values(59,180,1);

select c.idcarrito,c.idUsuario,dp.idproducto,c.NombreProd,c.FechaCompra,dp.precio,dp.cantidad, dp.precio*Cantidad as total 
from carrito c join detalleproducto dp on c.idcarrito=dp.idcarrito 
where idusuario=5 group by idproducto;



create table detalleproducto(
idCarrito int,
idProducto int not null,
Precio int not null,
cantidad int not null,
foreign key detalle(IdCarrito) references Carrito(Idcarrito),
foreign key producto(IdProducto) references Producto(IdProducto)
);

create table compra(
idCompra int primary key auto_increment not null,
Idusuario int not null,
Descripcion text,
foreign key compra(idusuario) references usuario(idusuario)
);

create table log_Registro(
idlog int primary key auto_increment not null,
fecha datetime not null,
idusuario varchar(50) not null,
Descripcion text not null
);

select * from compra;
/*
DELIMITER $$
create trigger log_registros
after insert
on compra for each row
begin
insert into log_Registro values(default,now(),new.idusuario,new.Descripcion);
end $$

DELIMITER $$
create trigger verificar
before insert
on carrito for each row
begin
if exists (select dp.idproducto from detalleproducto dp 
join carrito c on dp.idcarrito=c.idcarrito)  then
update detalleproducto set cantidad =cantidad +1;
update detalleproducto set idcarrito=new.idcarrito;
else
update detalleproducto set cantidad = 1;
end if;
end $$

*/

drop trigger verificar;