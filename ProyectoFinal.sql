create database ProyectoBD;
use proyectobd;



select * from compra;

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

delete from carrito;
drop table detalleproducto;

create table carrito(
idCarrito int primary key auto_increment not null,
idUsuario int not null,
NombreProd varchar(35) not null,
FechaCompra datetime not null,
foreign key usuario(Idusuario) references Usuario(IdUsuario));


insert into carrito values(default,5,'Tenis',now());

INSERT INTO detalleproducto VALUES (
(select c.idcarrito from carrito c 
where c.NombreProd='Tenis' and idUsuario=5 group by idUsuario),59,180,1);

select c.idcarrito from carrito c join detalleproducto dp on c.idcarrito=dp.idcarrito 
 where NombreProd='Tenis' group by dp.idproducto ;

select c.idcarrito,c.idUsuario,dp.idproducto,c.NombreProd,c.FechaCompra,dp.precio,dp.cantidad, dp.precio*Cantidad as total 
from carrito c join detalleproducto dp on c.idcarrito=dp.idcarrito 
where c.idusuario=5 group by dp.idproducto;

select * from detalleproducto group by idcarrito;
delete from detalleproducto;

create table detalleproducto(
idCarrito int not null,
idProducto int not null,
Precio int not null,
cantidad int not null,
foreign key detalle(IdCarrito) references Carrito(Idcarrito),
foreign key producto(IdProducto) references Producto(IdProducto)
);

create table compra(
idCompra int primary key auto_increment not null,
Idusuario int not null,
NombreUsuario varchar(50),
Descripcion text,
Cantidad_Venta decimal(10,2),
foreign key compra(idusuario) references usuario(idusuario)
);
select * from compra;
create table log_Registro(
idlog int primary key auto_increment not null,
fecha datetime not null,
idusuario varchar(50) not null,
Descripcion text not null
);

/*
DELIMITER $$
create procedure Reporte_Compras_Cliente(in anio int(4),in mes int(2))
begin 
Select idUsuario,NombreUsuario,count(*) as Cantidad_Compras,
sum(Cantidad_Venta) as Cantidad_Total
from log_Registro where (year(fecha)=anio and month(fecha)=mes) group by idUsuario
having Cantidad_Total order by Cantidad_Total desc ;
end $$

DELIMITER $$
create procedure Reporte_Ventas_Periodo(in FechaI varchar(11),in FechaF varchar(11))
begin 
select c.idCompra,l.fecha,c.Cantidad_Venta,l.NombreUsuario 
from Compra c join log_Registro l 
where c.idUsuario = l.Idusuario and 
fecha between FechaI and FechaF
group by c.idcompra;
end $$

/*
DELIMITER $$
create trigger log_registros
after insert
on compra for each row
begin
insert into log_Registro values(default,now(),new.idusuario,new.NombreUsuario,new.Descripcion,new.Cantidad_Venta);
end $$

DELIMITER $$
create trigger verificar
before insert
on carrito for each row
begin
if exists (select dp.idproducto from detalleproducto dp 
join carrito c on dp.idcarrito=c.idcarrito)  then
update detalleproducto set cantidad =cantidad +1;
else
update detalleproducto set cantidad = 1;
end if;
end $$

*/

