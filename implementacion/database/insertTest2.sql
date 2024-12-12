SELECT * FROM Producto;
SELECT * FROM Cuenta;
SELECT * FROM Categoria;
SELECT * FROM Relacion;
SELECT * FROM AtributoPersonalizado;
INSERT INTO Cuenta (nombre, fecha_creacion) 
VALUES ('Juanma Ganador', CURDATE());

UPDATE Producto
SET cuenta_id = 1
WHERE sku = 'G0003';

ALTER TABLE Producto DROP FOREIGN KEY Producto_ibfk_1;
ALTER TABLE Producto MODIFY COLUMN cuenta_id INT NOT NULL;
ALTER TABLE Producto 
ADD FOREIGN KEY (cuenta_id) REFERENCES Cuenta(id) ON DELETE CASCADE;

INSERT INTO Relacion (nombre, cuenta_id) VALUES ('Más productos épicos', 1);


SHOW CREATE TABLE Producto;
SHOW CREATE TABLE AtributoPersonalizado;
SHOW CREATE TABLE Categoria;
SHOW CREATE TABLE Relacion;
SHOW CREATE TABLE Cuenta;
SHOW CREATE TABLE ProductoAtributo;
SHOW CREATE TABLE ProductoCategoria;
SHOW CREATE TABLE RelacionProducto;

-- 1. Eliminar la clave primaria actual (id)
ALTER TABLE RelacionProducto DROP PRIMARY KEY;

-- 2. Eliminar la columna id si ya no es necesaria
ALTER TABLE RelacionProducto DROP COLUMN id;

-- 3. Definir la nueva clave primaria como la combinación de las tres columnas
ALTER TABLE RelacionProducto 
ADD PRIMARY KEY (producto_sku_principal, nombre_relacion, producto_sku_relacionado);









