
-- Crear la tabla Cuenta
CREATE TABLE Cuenta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    fecha_creacion DATE NOT NULL
);

-- Alterar la tabla Categoria para relacionarla con Cuenta
ALTER TABLE Categoria
ADD COLUMN cuenta_id INT NULL,
ADD FOREIGN KEY (cuenta_id) REFERENCES Cuenta(id) ON DELETE CASCADE;

-- Alterar la tabla Producto para relacionarla con Cuenta
ALTER TABLE Producto
ADD COLUMN cuenta_id INT NULL,
ADD FOREIGN KEY (cuenta_id) REFERENCES Cuenta(id) ON DELETE CASCADE;

-- Alterar la tabla AtributoPersonalizado para relacionarla con Cuenta
ALTER TABLE AtributoPersonalizado
ADD COLUMN cuenta_id INT NULL,
ADD FOREIGN KEY (cuenta_id) REFERENCES Cuenta(id) ON DELETE CASCADE;

-- Crear la tabla Relacion
CREATE TABLE Relacion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL UNIQUE,
    cuenta_id INT NOT NULL,
    FOREIGN KEY (cuenta_id) REFERENCES Cuenta(id) ON DELETE CASCADE
);

-- Crear la tabla RelacionProducto para relaciones 1:M entre productos
CREATE TABLE RelacionProducto (
    id INT AUTO_INCREMENT PRIMARY KEY,
    producto_sku_principal VARCHAR(50) NOT NULL,
    nombre_relacion VARCHAR(100) NOT NULL,
    producto_sku_relacionado VARCHAR(50) NOT NULL,
    FOREIGN KEY (producto_sku_principal) REFERENCES Producto(sku) ON DELETE CASCADE,
    FOREIGN KEY (producto_sku_relacionado) REFERENCES Producto(sku) ON DELETE CASCADE
);

-- Añadir la columna email a la tabla Cuenta
ALTER TABLE Cuenta
ADD COLUMN email VARCHAR(255) NOT NULL UNIQUE;

