DROP DATABASE IF EXISTS "stock";
CREATE DATABASE IF NOT EXISTS "stock";
USE "stock";

--
--  TypesProduits
--

CREATE TABLE TypesProduits(
   Id_TypesProduits INT AUTO_INCREMENT,
   LibelleTypeProduit VARCHAR(100) ,
   PRIMARY KEY(Id_TypesProduits)
);

ALTER TABLE TypesProduits ENGINE=InnoDB CHARSET=utf8 COLLATE=utf8_general_ci;

--
--  Categories
--

CREATE TABLE Categories(
   Id_Categories INT AUTO_INCREMENT,
   LibelleCategorie VARCHAR(50) ,
   Id_TypesProduits INT NOT NULL,
   PRIMARY KEY(Id_Categories)
);
ALTER TABLE Categories ENGINE=InnoDB CHARSET=utf8 COLLATE=utf8_general_ci;

--
--  Articles
--

CREATE TABLE Articles(
   Id_Articles INT AUTO_INCREMENT,
   LibelleArticle VARCHAR(100) ,
   QuantiteStockee INT,
   Id_Categories INT NOT NULL,
   PRIMARY KEY(Id_Articles)
);

ALTER TABLE Articles ENGINE=InnoDB CHARSET=utf8 COLLATE=utf8_general_ci;



ALTER TABLE Categories
ADD CONSTRAINT FK_TYPE_PRODUITS FOREIGN KEY(Id_TypesProduits) REFERENCES TypesProduits(Id_TypesProduits),

ALTER TABLE Articles
ADD CONSTRAINT FK_CATEGORIES FOREIGN KEY(Id_Categories) REFERENCES Categories(Id_Categories)

