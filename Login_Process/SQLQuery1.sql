CREATE TABLE SignIn(
UserId int identity(1,1) primary key,
UserName varchar(50),
UserPassword varchar(50)
);

insert into SignIn values('temel','yazilim');
insert into SignIn values('aleyna','1234');
insert into SignIn values('backend','developer');