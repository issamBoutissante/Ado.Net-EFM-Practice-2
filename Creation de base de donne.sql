create database hopital
use hopital
create table specialite(
idSpecialite int identity(1,1),
libelle varchar(100),
constraint pk_specialite primary key(idSpecialite)
)
insert into specialite values('doctor')
insert into specialite values('helper')
create table operation(
idOperation int identity(1,1),
code varchar(8),
libelle varchar(100)
constraint pk_operation primary key(idOperation)
)
create table medecin(
idMedecin int identity(1,1),
cin varchar(6),
nom varchar(20),
prenom varchar(20),
telephone varchar(10),
idSpecialite int,
constraint pk_medecin primary key(idMedecin),
constraint fk_medecin_specialite foreign key(idSpecialite) references specialite(idSpecialite)
)
insert into medecin values('ee3333','boutissante','issam','0610811157',2)
insert into medecin values('dd1453','Mazzouz','chaimae','0610811157',1)
create table ligneMedecinOperation(
idMedecin int,
idOperation int,
dateOperation date,
duree float,
prix money
constraint pk_ligneMedecinOperation primary key(idMedecin,idOperation,dateOperation),
constraint fk_ligneMedecinOperation_medecin foreign key(idMedecin) references medecin(idMedecin),
constraint fk_ligneMedecinOperation_Operation foreign key(idOperation) references operation(idOperation),
)
create procedure spGetNombreOperation(@date date,@idSpecialite int)
as
begin
	select COUNT(*) from ligneMedecinOperation lmo join medecin m
	on lmo.idMedecin=m.idMedecin join operation o
	on lmo.idOperation=o.idOperation
	where dateOperation=@date and idSpecialite=@idSpecialite
end
