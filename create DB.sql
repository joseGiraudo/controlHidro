Create database DBControlHidro;


use DBControlHidro;

create table tipos_controles(
	id_tipo_control int identity(1,1),
	tipo_control varchar(100) not null
	constraint pk_t_controles primary key(id_tipo_control)
);

create table tipos_cultivos(
	id_tipo_cultivo int identity(1,1),
	tipo_cultivo varchar(100) not null
	constraint pk_t_cultivos primary key(id_tipo_cultivo)
);

create table cultivos(
	id_cultivo int identity(1,1),
	nombre varchar(100) not null,
	fecha_inicio datetime not null,
	id_tipo_cultivo int not null,
	observaciones varchar(250),
	genetica varchar(250)
	constraint pk_cultivos primary key (id_cultivo),
	constraint fk_cultivos_tipos foreign key(id_tipo_cultivo) references tipos_cultivos(id_tipo_cultivo)
);

create table controles(
	id_control int identity(1,1),
	id_tipo_control int not null,
	fecha_control datetime not null,
	id_cultivo int not null,
	ph decimal(4,2),
	ppm decimal(6,2),
	ec decimal(6,2),
	observaciones varchar(250)
	constraint pk_controles primary key (id_control),
	constraint fk_controles_tipos foreign key(id_tipo_control) references tipos_controles(id_tipo_control),
	constraint fk_controles_cultivos foreign key(id_cultivo) references cultivos(id_cultivo)
);

insert into tipos_controles(tipo_control)
	values('Control Normal');

insert into tipos_controles(tipo_control)
	values('Agregado de Fertis');

insert into tipos_controles(tipo_control)
	values('Cambio de Agua');

select * from tipos_controles;

-- 08/06 
use DBControlHidro;

select * from tipos_cultivos;

select * from controles;

insert into tipos_cultivos(tipo_cultivo)
	values('Automatica');

insert into tipos_cultivos(tipo_cultivo)
	values('Fotoperiodica');

insert into tipos_cultivos(tipo_cultivo)
	values('Regular');

insert into tipos_cultivos(tipo_cultivo)
	values('Regular Feminizada');