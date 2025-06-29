use EMPRESA
go

/*INSERT PRODUCTOS*/
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO, NOMBRE_PRODUCTO, EXISTENCIA, NOMBRE_PROVEEDOR)
VALUES 
('001','Vasos Descartables - Paquete', 30, 'La Colonia'),
('002','Cucharas Descartables - Paquete', 20, 'La Colonia'),
('003','Platos Descartables - Paquete', 40, 'La Colonia'),
('004','Servilletas', 20, 'La Colonia'),
('005','Paquete de galletas Oreo', 20, 'La Colonia'),

('007','Coca-Cola - Botella', 30, 'Coca-Cola'),
('008','DFruta', 20, 'Coca-Cola'),
('009','Barrita de frutas', 40, 'AMPM'),
('010','Churritos - Bolsa', 20, 'AMPM')

INSERT INTO PRODUCTOS (CODIGO_PRODUCTO, NOMBRE_PRODUCTO, EXISTENCIA, ESTADO, NOMBRE_PROVEEDOR)
VALUES
('006','Maruchan - Bolsa', 10, 0, 'Waltmart')

Select ID_PRODUCTOS, CODIGO_PRODUCTO, NOMBRE_PRODUCTO, EXISTENCIA, NOMBRE_PROVEEDOR, ESTADO from PRODUCTOS
SELECT * FROM PRODUCTOS 
GO

/*INSERT USUARIOS*/
INSERT USUARIOS (NOMBRE_DE_USUARIO, CONTRASEÑA, NOMBRE, APELLIDO, CORREO, TELEFONO) 
VALUES 
('Leonardo', 'lz130403', 'Leonardo Josue', 'Zapata Castañeda', 'leo13zc@gmail.com','8685-1514'),
('Meli', 'ml150803', 'Melani Stephany', 'Idiaquez Reyes', 'meli15ir@gmail.com','8452-7456'),
('Miguel', 'Miguelito2000', 'Miguel Angel', 'Garcia Perez', 'miguelgpangel@gmail.com','5263-4859')

SELECT * FROM USUARIOS
SELECT ID_USUARIOS,NOMBRE_DE_USUARIO, NOMBRE, APELLIDO, CORREO, TELEFONO, ESTADO FROM USUARIOS
GO

/*INSERT OPCIONES*/
INSERT OPCIONES (NOMBRE_OPCION, ID_PRODUCTO_OPCION)
VALUES


('500 ml', 7),
('2lt', 7),

('Pequeño', 1),
('Pequeño', 2),
('Pequeño', 3),

('Mediano', 1),
('Mediano', 2),
('Mediano', 3),

('Grande', 1),
('Grande', 2),
('Grande', 3),

('Paquete pequeño', 4),
('Paquete Grande', 4),

('Paquete de 12', 5),
('Paquete de 24', 5),

('Unidad', 6),

('12 Onz', 7),
('500 ml', 7),
('2lt', 7),

('Unidad', 9),

('Bolsa pequeña', 10),
('Bolsa MAX', 10),
('Bolsa Grande', 10)


SELECT * FROM OPCIONES
GO