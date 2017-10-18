drop database if exists AlgranatiGroup;

create database AlgranatiGroup;

use AlgranatiGroup;

create table Platos(
id int auto_increment primary key,
nombrePlato varchar(100) not null,
precio double not null
);

create table PlatosPedido(
id int auto_increment primary key,
numeroPed bigint not null,
nombrePlato varchar(100) not null,
precio double not null
);

create table Mesa(
numero int not null primary key,
numeroPedido bigint not null,
estado varchar(20) not null,
mesero varchar(20) not null,
cliente varchar(20) not null
);

create table Ticket(
numero int auto_increment primary key,
total double not null,
tipoPago varchar (10) not null,
fecha datetime 
)

