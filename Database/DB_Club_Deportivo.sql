drop database if exists Club_Deportivo;
create database Club_Deportivo;
use Club_Deportivo;

-- ==========================
-- CLIENTE
-- ==========================
CREATE TABLE IF NOT EXISTS Cliente (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    tipoDoc ENUM('dni', 'pasaporte','lc') NOT NULL,
    dni VARCHAR(15) UNIQUE NOT NULL,
    direccion VARCHAR(50),
    tel VARCHAR(20),
    email VARCHAR(50),
    fechaNac DATE NOT NULL,
    estado BOOLEAN DEFAULT TRUE,
    aptoFisico BOOLEAN DEFAULT FALSE
);

-- ==========================
-- SOCIO (hereda de Cliente)
-- ==========================
CREATE TABLE IF NOT EXISTS Socio (
    idSocio INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT NOT NULL UNIQUE,
    nroSocio INT UNIQUE NOT NULL,
    fechaInscripcion DATE NOT NULL,
    FOREIGN KEY (idCliente)
        REFERENCES Cliente(idCliente)
        ON DELETE CASCADE
);

-- ==========================
-- NO SOCIO (hereda de Cliente)
-- ==========================
CREATE TABLE IF NOT EXISTS  NoSocio (
    idNoSocio INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT NOT NULL UNIQUE,
    fechaVisita DATE NOT NULL,
    FOREIGN KEY (idCliente)
        REFERENCES Cliente(idCliente)
        ON DELETE CASCADE
);

-- ==========================
-- CARNET
-- ==========================
CREATE TABLE IF NOT EXISTS Carnet (
    idCarnet INT AUTO_INCREMENT PRIMARY KEY,
    idSocio INT NOT NULL UNIQUE,
    nroSocio INT NOT NULL,
    fechaInicio DATE NOT NULL,
    fechaVenc DATE NOT NULL,

    FOREIGN KEY (idSocio)
        REFERENCES Socio(idSocio)
        ON DELETE CASCADE
);

-- ==========================
-- CUOTA
-- ==========================
CREATE TABLE IF NOT EXISTS Cuota (
    idCuota INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT NOT NULL,
    tipo ENUM('mensual', 'diaria') NOT NULL,
    modoPago ENUM('efectivo', 'tarjetaCredito', 'tarjetaDebito','transferencia' ) NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    fechaPago DATE NOT NULL,
    fechaVenc DATE NOT NULL,
    pagado BOOLEAN DEFAULT FALSE,

    FOREIGN KEY (idCliente)
        REFERENCES Cliente(idCliente)
        ON DELETE CASCADE
);

-- ==========================
-- USUARIO
-- ==========================
CREATE TABLE IF NOT EXISTS Usuario(
idUsuario INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50),
pass VARCHAR(50),
rol ENUM('administrador', 'empleado') NOT NULL,
username VARCHAR(50),
estado boolean default true
);


-- ==========================
-- INSERTs INICIALES
-- ==========================
INSERT INTO Usuario (nombre, pass, rol, username)
VALUES ('Administrador', 'admin123', 'administrador', 'admin'),
	('Silvia Cañizares', 'admin', 'administrador', 'silvia'),
	('Barbara', 'b1234', 'empleado', 'barby'),
	('Christian', 'c1234', 'empleado', 'christian'),
	('Diego', 'd1234', 'empleado', 'diego'),
	('Romina', 'r1234', 'empleado', 'romina');

INSERT INTO Cliente(nombre, apellido, tipoDoc, dni, email, fechaNac, aptoFisico) 
VALUES ('Salome', 'Giacomini', 'dni', '7663675789', 'sgiacomini0@nytimes.com', '2013-05-02',  true),
('Annmaria', 'McChruiter', 'dni', '5534668482', 'amcchruiter1@google.nl', '2013-02-06', true),
('Rene', 'Christoffe', 'dni', '6618229952', 'rchristoffe3@pinterest.com', '2019-04-09', true),
('Rog', 'Wickey', 'dni', '5372416270', 'rwickey4@wikispaces.com', '1993-02-22', true),
('Guilbert', 'Grigor', 'dni', '2908855542', 'ggrigor5@opera.com', '1981-09-03', true),
('Hollis', 'Curry', 'dni', '2920853163', 'hcurry6@gov.uk', '2009-02-28', true),
('Myrah', 'Bontine', 'dni', '8905516254', 'mbontine7@odnoklassniki.ru', '1997-08-02', true),
('Theodore', 'Spriggen', 'dni', '9802684473', 'tspriggen8@youtube.com', '1991-05-15', true),
('Marwin', 'Woolen', 'dni', '0870043919', 'mwoolen2@ifeng.com', '2019-11-22', true),
('Gabriell', 'Beininck', 'dni', '8050872017', 'gbeininck9@google.es', '1997-12-10', true);

INSERT INTO Socio (idCliente, nroSocio, fechaInscripcion)
VALUES (1, 1001, '2026-05-10'),
(2, 1002, '2026-05-14'),
(3, 1003, '2026-02-05'),
(4, 1004, '2026-04-01'),
(5, 1005, '2026-04-11'),
(6, 1006, '2026-04-06');

INSERT INTO NoSocio (idCliente, fechaVisita)
VALUES (7, '2026-05-12'),
(8, '2026-04-03'),
(9, '2026-04-15'),
(10, '2026-05-24');

INSERT INTO Carnet (idSocio, nroSocio, fechaInicio, fechaVenc)
VALUES (1, 1001, '2026-05-10', '2027-05-10'),
(2, 1002, '2026-05-14', '2027-05-14'),
(3, 1003, '2026-02-05', '2027-02-05'),
(4, 1004, '2026-04-01', '2027-01-01'),
(5, 1005, '2026-04-11', '2027-04-11'),
(6, 1006, '2026-04-06', '2027-04-06');

INSERT INTO Cuota (idCliente, tipo, modoPago, monto, fechaPago, fechaVenc, pagado)
VALUES (1, 'mensual', 'tarjetaCredito', 30000, '2026-05-10',  '2026-06-10', true),
(2, 'mensual', 'efectivo', 30000, '2026-05-14', '2026-06-14', true),
(3, 'mensual', 'tarjetaCredito', 30000, '2026-02-05', '2026-03-05', true),
(3, 'mensual', 'tarjetaCredito', 30000, '2026-03-05', '2026-04-05', true),
(3, 'mensual', 'tarjetaCredito', 30000, '2026-04-05', '2026-05-05', true),
(3, 'mensual', 'tarjetaCredito', 30000, '2026-05-05', '2026-06-05', true),
(4, 'mensual', 'tarjetaDebito', 30000, '2026-04-01', '2026-05-01', true),
(4, 'mensual', 'tarjetaDebito', 30000, '2026-05-01', '2026-06-01', true),
(5, 'mensual', 'tarjetaDebito', 30000, '2026-04-11', '2026-05-11', true),
(5, 'mensual', 'tarjetaDebito', 30000, '2026-05-11', '2026-06-11', true),
(6, 'mensual', 'transferencia', 30000, '2026-04-06', '2026-05-06', true),
(6, 'mensual', 'transferencia', 30000, '2026-05-06', '2026-06-06', true),
(7, 'diaria', 'transferencia', 19000.99, '2026-05-12', '2026-05-12', true),
(8, 'diaria', 'transferencia', 6000.99, '2026-03-04', '2026-03-04', true),
(9, 'diaria', 'efectivo', 26000.99, '2026-04-5', '2026-04-5', true),
(10, 'diaria', 'tarjetaDebito', 39000.99, '2026-05-24', '2026-05-24', true);




-- ====================================
-- STORE PROCEDURE
-- ====================================
DELIMITER //  
CREATE PROCEDURE IngresoLogin(in p_usuario varchar(50),in p_pass varchar(50))
BEGIN  
	SELECT *
	FROM Usuario
	WHERE username = p_usuario AND pass = p_pass AND estado = 1; 
end 
//
DELIMITER ;  
-- call IngresoLogin('admin', 'admin123');

DELIMITER //

CREATE PROCEDURE NuevoCliente(
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_tipoDoc ENUM('dni','pasaporte','lc'),
    IN p_dni VARCHAR(15),
    IN p_direccion VARCHAR(50),
    IN p_tel VARCHAR(20),
    IN p_email VARCHAR(50),
    IN p_fechaNac DATE,
    IN p_esSocio BOOLEAN,
    OUT rta INT
)
BEGIN
    DECLARE existe INT DEFAULT 0;
    DECLARE nuevoIdCliente INT;
    DECLARE nuevoNroSocio INT;

    -- Verificar si existe la persona
    SELECT COUNT(*)
    INTO existe
    FROM Cliente
    WHERE tipoDoc = p_tipoDoc AND dni = p_dni;

    IF existe > 0 THEN
        SET rta = -1;  -- ya existe
    ELSE

        -- Insertar Cliente
        INSERT INTO Cliente (nombre, apellido, tipoDoc, dni, direccion, tel, email, fechaNac)
        VALUES (p_nombre, p_apellido, p_tipoDoc, p_dni, p_direccion, p_tel, p_email, p_fechaNac);

        -- Obtener id generado
        SET nuevoIdCliente = LAST_INSERT_ID();

        -- Si es socio
        IF p_esSocio THEN
            SELECT IFNULL(MAX(nroSocio),1000)+1
            INTO nuevoNroSocio
            FROM Socio;

            INSERT INTO Socio(idCliente, nroSocio, fechaInscripcion)
            VALUES( nuevoIdCliente, nuevoNroSocio, CURDATE());

        ELSE
            INSERT INTO NoSocio(idCliente, fechaVisita)
            VALUES( nuevoIdCliente, CURDATE());

        END IF;

        SET rta = nuevoIdCliente;
    END IF;
END //

DELIMITER ;

-- CALL NuevoCliente( 'Ana', 'Perez', 'dni', '44123456', '', '','aperez@gmail.com', '1998-03-20', true, @resultado);
-- SELECT @resultado;