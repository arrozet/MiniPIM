
-- Crear la tabla Categoria
CREATE TABLE Categoria (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL
);


-- Crear la tabla Producto
CREATE TABLE Producto (
    sku VARCHAR(50) PRIMARY KEY,
    gtin VARCHAR(50),
    label VARCHAR(100),
    fechaCreacion DATE NOT NULL,
    ultimaModificacion DATE,
    descripcionCorta VARCHAR(255),
    descripcionLarga TEXT,
    espacioOcupado INT,
    thumbnail BLOB -- Para almacenar imágenes en formato jpg 200x200 píxeles
);

-- Crear la tabla AtributoPersonalizado
CREATE TABLE AtributoPersonalizado (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    tipo ENUM('texto', 'numero', 'booleano', 'video', 'foto') NOT NULL,
    espacioOcupado INT
);

-- Crear tabla intermedia ProductoAtributo para la relación Producto-AtributoPersonalizado (0..5 - 0..*)
CREATE TABLE ProductoAtributo (
    producto_sku VARCHAR(50),
    atributo_id INT,
    valor TEXT NOT NULL,
    PRIMARY KEY (producto_sku, atributo_id),
    FOREIGN KEY (producto_sku) REFERENCES Producto(sku) ON DELETE CASCADE,
    FOREIGN KEY (atributo_id) REFERENCES AtributoPersonalizado(id) ON DELETE CASCADE
);


-- Crear tabla intermedia ProductoCategoria para la relación Producto-Categoria (0..* - 0..*)
CREATE TABLE ProductoCategoria (
    producto_sku VARCHAR(50),
    categoria_id INT,
    PRIMARY KEY (producto_sku, categoria_id),
    FOREIGN KEY (producto_sku) REFERENCES Producto(sku) ON DELETE CASCADE,
    FOREIGN KEY (categoria_id) REFERENCES Categoria(id) ON DELETE CASCADE
);

