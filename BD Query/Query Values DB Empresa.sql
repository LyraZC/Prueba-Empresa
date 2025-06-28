use EMPRESA
go

/*INSERT PRODUCTOS*/
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO, NOMBRE_PRODUCTO, EXISTENCIA, NOMBRE_PROVEEDOR)
VALUES 
('001','Vasos Descartables - Paquete', 30, 'La Colonia'),
('002','Cucharas Descartables - Paquete', 20, 'La Colonia'),
('003','Platos Descartables - Paquete', 40, 'La Colonia'),
('004','Servilletas', 20, 'La Colonia'),
('005','Paquete de galletas Oreo', 20, 'La Colonia')


SELECT * FROM PRODUCTOS 
GO

/*INSERT USUARIOS*/
INSERT USUARIOS (NOMBRE_DE_USUARIO, CONTRASEÑA, NOMBRE, APELLIDO, CORREO, TELEFONO) 
VALUES 
('Leonardo', 'lz130403', 'Leonardo Josue', 'Zapata Castañeda', 'leo13zc@gmail.com','8695-1414'),
('Meli', 'ml150803', 'Melani Stephany', 'Idiaquez Reyes', 'meli15ir@gmail.com','8452-7456'),
('Miguel', 'Miguelito2000', 'Miguel Angel', 'Garcia Perez', 'miguelgpangel@gmail.com','5263-4859')

SELECT * FROM USUARIOS
SELECT ID_USUARIOS,NOMBRE_DE_USUARIO, NOMBRE, APELLIDO, CORREO, TELEFONO, ESTADO FROM USUARIOS
GO

/*INSERT OPCIONES*/
INSERT OPCIONES (NOMBRE_OPCION, ID_PRODUCTO_OPCION)
VALUES
('Pequeño', 1),
('Pequeño', 2),
('Pequeño', 3),

('Mediano', 1),
('Mediano', 2),
('Mediano', 3),

('Grande', 1),
('Grande', 2),
('Grande', 3)


SELECT * FROM OPCIONES
GO