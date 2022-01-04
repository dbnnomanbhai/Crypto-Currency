CREATE DATABASE TODAY_DB; 

select * from  Adminreg;
select * from CRYPT;
select * from customer;
select * from help;
select * from transactions;

create table Adminreg(

adminid int primary key,
username varchar(255),
email varchar(255),
pw varchar(255),
conpw  varchar(255),
);


 create table crypt(

 customerid int primary key,
 secret  varchar(255),
 encrypted  varchar(255),
 
 
);



 create table customer(

 customerid int primary key,
username varchar(255),
 pass varchar(255),
 confirmpass varchar(255),
 
);


 create table help(

 customerid int primary key,
username varchar(255),
 mail  varchar(255),
  query varchar(255),
 
);

create table transactions(

tid int primary key,
coinprice int  not null,
coinname varchar(255),
deposit int  ,
 withdraw int  ,
 balance int  ,
 customerid int  ,
 coinvalue int  ,
);
 
