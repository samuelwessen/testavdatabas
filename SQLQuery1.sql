CREATE TABLE Customer(
Id int not null identity(1,1) primary key,
FullName nvarchar(100) not null,
Email nvarchar(100) not null,
PhoneNr int not null
)