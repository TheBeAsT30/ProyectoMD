DROP TABLE users;
CREATE TABLE users(
    Id INT NOT NULL IDENTITY,
    Name VARCHAR(80) NOT NULL,
    Last_name VARCHAR(80) NOT NULL,
    NUser VARCHAR(80) UNIQUE NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Score INT,
    PRIMARY KEY(Id)
    );  
    SELECT * FROM users;

    /*SELECT Name, Last_name, NUser, Password FROM users WHERE NUser= 'Isa' COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = '4321' OR 
    Email= 'guevaravic100@gmail.com';*/


    /*UPDATE users SET Password = '4321' WHERE Email = 'guevaravic25@gmail.com';
    create table usuario(
	ID int(11) auto_increment,
    loginName nvarchar(80) unique not null,
    Password nvarchar(80) not null,
    Nombre nvarchar(80) not null,
    Apellido nvarchar(80) not null,
    Email nvarchar(150) not null,
    primary key(ID)
);*/

IF EXISTS(SELECT NUser FROM users WHERE NUser = 'Vico')
BEGIN
SELECT * FROM users;
END
IF NOT EXISTS(SELECT NUser FROM users WHERE NUser = 'Vico')
BEGIN 
INSERT INTO users VALUES('Victor','XD','Vico','Cwecw@gmail.com','43215', 12);
IF EXISTS(SELECT NUser FROM users WHERE NUser = 'Vico')
BEGIN
SELECT * FROM users;
END
END


SELECT Name, Last_name FROM users WHERE NUser='Vico';