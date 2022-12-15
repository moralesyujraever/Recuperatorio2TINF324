create table FlujoProceso          
(
Flujo varchar(3),
Proceso varchar(3),
ProcesoSiguiente varchar(3),
Tipo varchar(1),
Pantalla varchar(20),
Rol varchar(20)
)

insert into flujo values('F1','P1','P2','I','Ingresar','Estudiante');
insert into flujo values('F1','P2','P3','P','Preinscripcion','Estudiante');
insert into flujo values('F1','P3','','C','Habilitada','Estudiante');
insert into flujo values('F1','P4','','F','CursoRegular','Estudiante');
insert into flujo values('F1','P5','P6','P','Deposito','Caja');
insert into flujo values('F1','P6','P7','P','Presentar','Kardex');
insert into flujo values('F1','P7','','F','Inscripcion','Kardex');


create table FlujoProcesoCondicionante
(      
Flujo varchar(3),
Proceso varchar(3),
ProcesoSI varchar(3),
ProcesoNO varchar(3)
)


insert into FlujoProcesoCondicionante values('F1','P3','P4','P7');

create table FlujoProcesoSeguimiento
(
	Flujo varchar(3),
	Proceso varchar(3),
	NumeroTramite int,
	Usuario varchar(15),
	FechaInicio date,
	HoraInicio time,
	FechaFin date,
	HoraFin time
)


insert into FlujoProcesoSeguimiento values('F1','P1','1000','julia','2022/04/20','10:00:00','2022/04/20','14:00:00');
insert into FlujoProcesoSeguimiento values('F1','P2','1000','julia','2022/04/20','14:01:00','2022/04/22','10:00:00');
insert into FlujoProcesoSeguimiento values('F1','P3','1100','julia','2022/04/22','10:01:00',null,null);
insert into FlujoProcesoSeguimiento values('F2','P1','2020','julia','2022/04/20','10:10:00','2022/04/21','11:10:00');
insert into FlujoProcesoSeguimiento values('F2','P2','2020','julia','2022/04/21','11:11:00',null,null);
insert into FlujoProcesoSeguimiento values('F1','P1','1010','mercedes','2022/04/11','09:00:00','2022/04/11','09:10:00');
insert into FlujoProcesoSeguimiento values('F1','P2','10','mercedes','2022/04/11','09:11:00',null,null);
