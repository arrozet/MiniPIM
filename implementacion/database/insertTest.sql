-- Insertar gormitis en la tabla Producto

INSERT INTO Producto (sku, gtin, label, fechaCreacion, ultimaModificacion, descripcionCorta, descripcionLarga, espacioOcupado, thumbnail)
VALUES 
-- ('G001', '123456789001', 'Hirok', '2024-11-21', '2024-11-21', 'Gormiti del fuego', 'Hirok es el líder valiente y noble del clan del fuego. Con su fuerza imparable y su dominio sobre las llamas, lidera a sus guerreros en la batalla contra los enemigos. Sus poderes están conectados con el calor de la tierra, convirtiéndolo en un aliado formidable en tiempos de guerra.', 10, NULL),
('G002', '123456789002', 'Ikalos', '2024-11-21', '2024-11-21', 'Gormiti del agua', 'Ikalos, el guerrero del agua, es conocido por su agilidad y destreza. Su conexión con los océanos le permite manipular las aguas a su alrededor, creando poderosos remolinos y tormentas. Como protector del clan del agua, su astucia es tan afilada como la espuma del mar.', 8, NULL),
('G003', '123456789003', 'Karak', '2024-11-21', '2024-11-21', 'Gormiti del aire', 'Karak es el guardián ágil y veloz del clan del aire. Sus movimientos son tan rápidos como el viento, y su destreza en combate es inigualable. Siempre alerta, Karak usa sus alas para esquivar ataques y para ayudar a sus compañeros de clan a alcanzar nuevas alturas.', 7, NULL),
('G004', '123456789004', 'Lord Titano', '2024-11-21', '2024-11-21', 'Gormiti de la tierra', 'Lord Titano es el defensor titánico del clan de la tierra. Con una fuerza inhumana, puede causar terremotos y levantar montañas. Su gran resistencia lo convierte en la primera línea de defensa contra cualquier invasión. Su presencia es un símbolo de poder y protección para su pueblo.', 12, NULL);

-- Se me olvidó Yridium
INSERT INTO Producto (sku, gtin, label, fechaCreacion, ultimaModificacion, descripcionCorta, descripcionLarga, espacioOcupado, thumbnail)
VALUES 
('G005', '123456789005', 'Yridium', '2024-11-21', '2024-11-21', 
 'Gormiti del plasma', 
 'Yridium es el guerrero del plasma, conocido por su poder de controlar la energía y las partículas subatómicas. Su habilidad para manipular la energía lo convierte en un luchador indomable. En el campo de batalla, Yridium desata una energía devastadora capaz de desintegrar a sus enemigos.', 
 9, NULL);
 
-- Meto atributo precio 
INSERT INTO AtributoPersonalizado (nombre, tipo) VALUES ('precio', 'number');

-- Meto valor para precio a primer producto
INSERT INTO ProductoAtributo (producto_sku, atributo_id, valor)
VALUES ('G001', (SELECT id FROM AtributoPersonalizado WHERE nombre = 'precio'), '777');
INSERT INTO ProductoCategoria (producto_sku, categoria_id) VALUES ('chocho', 1);
INSERT INTO Categoria (nombre) VALUES ('Figuras');
INSERT INTO Categoria (nombre) VALUES ('Decoración');

-- Meto valor para precio a primer producto


VALUES ('G001', (SELECT id FROM Categoria WHERE nombre = 'Figuras'));
 
 INSERT INTO ProductoCategoria (producto_sku, categoria_id)
VALUES ('G001', (SELECT id FROM Categoria WHERE nombre = 'Decoración'));

 