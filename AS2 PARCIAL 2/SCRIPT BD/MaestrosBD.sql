create database siu_maestro;
use siu_maestro;

create table maestro(
  codigo_maestro int(5)not null auto_increment,
  nombre_maestro varchar(45)not null,
  apellido_maestro varchar(45)not null,
  direccion_maestro varchar(45)not null,
  dpi_maestro varchar(15)not null,
  nit_maestro varchar(15)not null,
  estatus_maestro varchar(1)not null,
  primary key (codigo_maestro)
 ) engine = InnoDB default charset=latin1;
-- ------------------------------------------------
create table telefono_maestro(
	codigo_registro int(5)not null auto_increment,
    codigo_maestro int(5)not null,
    telefono varchar(45)not null,
    estatus_telefono varchar(1)not null,
    primary key (codigo_registro)
)engine = InnoDB default charset=latin1;

create table email_maestro(
	codigo_registro int(5)not null auto_increment,
    codigo_maestro int(5)not null,
    email varchar(45)not null,
    estatus_telefono varchar(1)not null,
    primary key (codigo_registro)
)engine = InnoDB default charset=latin1;

alter table telefono_maestro add constraint fk_telefono_registro_maestro foreign key(codigo_maestro) references maestro(codigo_maestro);
alter table email_maestro add constraint fk_email_registro_maestro foreign key(codigo_maestro) references maestro(codigo_maestro);