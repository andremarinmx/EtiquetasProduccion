CREATE DATABASE EtiquetasProduccion;

USE EtiquetasProduccion;

CREATE TABLE Order_(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderNumber VARCHAR(6),
    Height FLOAT,
    Width FLOAT,
    Line_ INT,
    Pcs_Order INT,
    Pcs_Box INT,
    Address_ VARCHAR(255),
    Customer VARCHAR(255),
    Status_ VARCHAR(6)
);

CREATE TABLE Evidence(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Img VARCHAR(MAX),
	Date_ DATETIME DEFAULT GETDATE()
);

CREATE TABLE Order_Evidence(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Id_Order INT,
    Id_Evidences INT,
    FOREIGN KEY (Id_Order) REFERENCES Order_(Id),
    FOREIGN KEY (Id_Evidences) REFERENCES Evidence(Id)
);

CREATE TABLE Line_Made(
	Id INT PRIMARY KEY IDENTITY(1,1),
	OrderNumber VARCHAR(6),
    Height FLOAT,
    Width FLOAT,
    Line_ INT,
    Pcs_Order INT,
    Pcs_Box INT,
    Status_ INT
);

CREATE TABLE Folio(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderNumber VARCHAR(6),
    Total_Pcs INT,
	Date_ DATETIME DEFAULT GETDATE(),
);