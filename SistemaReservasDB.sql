CREATE DATABASE SistemaReservasDB;
GO

USE SistemaReservasDB;
GO

CREATE TABLE Zonas (
    IdZona INT IDENTITY(1,1) PRIMARY KEY,
    NombreZona VARCHAR(50) NOT NULL,
    DescripcionZona VARCHAR(200)
);

CREATE TABLE Empleados (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    NombreEmpleado VARCHAR(50) NOT NULL,
    ApellidoEmpleado VARCHAR(50) NOT NULL,
    UsuarioEmpleado VARCHAR(50) NOT NULL UNIQUE,
    ContrasenaEmpleado VARCHAR(100) NOT NULL,
    RolEmpleado VARCHAR(30) NOT NULL
);

CREATE TABLE Menu (
    IdMenu INT IDENTITY(1,1) PRIMARY KEY,
    NombreMenu VARCHAR(100) NOT NULL,
    CategoriaMenu VARCHAR(50) NOT NULL,
    DescripcionMenu VARCHAR(250),
    PrecioMenu DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    NombreCliente VARCHAR(50) NOT NULL,
    ApellidoCliente VARCHAR(50) NOT NULL,
    TelefonoCliente VARCHAR(20) NOT NULL,
    PuntosFidelidad INT DEFAULT 0
);

CREATE TABLE Mesas (
    IdMesa INT IDENTITY(1,1) PRIMARY KEY,
    CapacidadMesa INT NOT NULL,
    EstadoMesa VARCHAR(30) NOT NULL,
    IdZona INT NOT NULL,
    FOREIGN KEY (IdZona) REFERENCES Zonas(IdZona)
);

CREATE TABLE Turnos (
    IdTurno INT IDENTITY(1,1) PRIMARY KEY,
    InicioTurno DATETIME NOT NULL,
    FinalizacionTurno DATETIME NOT NULL,
    IdEmpleado INT NOT NULL,
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);

CREATE TABLE Bitacora (
    IdBitacora INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado INT NOT NULL,
    TipoOperacion VARCHAR(50) NOT NULL,
    FechaOperacion DATE NOT NULL,
    HoraOperacion TIME NOT NULL,
    TablaAfectada VARCHAR(50) NOT NULL,
    DescripcionBitacora VARCHAR(300),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);

CREATE TABLE Reservas (
    IdReserva INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdMesa INT NOT NULL,
    IdEmpleado INT NOT NULL,
    FechaReserva DATE NOT NULL,
    HoraReserva TIME NOT NULL,
    AnticipoReserva DECIMAL(10, 2) DEFAULT 0.00,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdMesa) REFERENCES Mesas(IdMesa),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);

CREATE TABLE DetalleReserva (
    IdDetalle INT IDENTITY(1,1),
    IdReserva INT NOT NULL,
    IdMenu INT NOT NULL,
    CantidadReserva INT NOT NULL,
    Observaciones VARCHAR(250),
    PRIMARY KEY (IdDetalle, IdReserva),
    FOREIGN KEY (IdReserva) REFERENCES Reservas(IdReserva),
    FOREIGN KEY (IdMenu) REFERENCES Menu(IdMenu)
);

USE SistemaReservasDB;
GO

-- =============================================
-- 1. ZONAS
-- =============================================
INSERT INTO Zonas (NombreZona, DescripcionZona) VALUES
('Terraza Principal', 'Zona al aire libre con vista panorámica y ambiente relajado.'),
('Salón VIP', 'Zona exclusiva y climatizada para eventos privados o cenas formales.'),
('Bar & Lounge', 'Area de niños');
GO

-- =============================================
-- 2. EMPLEADOS
-- =============================================
INSERT INTO Empleados (NombreEmpleado, ApellidoEmpleado, UsuarioEmpleado, ContrasenaEmpleado, RolEmpleado) VALUES
('Carlos', 'Pérez', 'cperez', 'Admin123*', 'Administrador'),
('María', 'González', 'mgonzalez', 'Mesero2026#', 'Mesero'),
('Luis', 'Ramírez', 'lramirez', 'Host123$', 'Recepcionista');
GO

-- =============================================
-- 3. MENU
-- =============================================
INSERT INTO Menu (NombreMenu, CategoriaMenu, DescripcionMenu, PrecioMenu) VALUES
('Lomo Saltado', 'Plato Fuerte', 'Trozos de lomo fino salteados con cebolla, tomate y papas fritas, acompañado de arroz.', 18.50),
('Ceviche Clásico', 'Entrada', 'Pescado fresco del día marinado en limones de la región con cebolla morada y cilantro.', 12.00),
('Cheesecake de Queso', 'Postre', 'Suave pastel de queso bañado en mermelada de fresa', 6.50),
('Mojito Tradicional', 'Bebida', 'Cóctel refrescante con ron blanco, hierbabuena, lima, azúcar y soda.', 5.00);
GO

-- =============================================
-- 4. CLIENTES
-- =============================================
INSERT INTO Clientes (NombreCliente, ApellidoCliente, TelefonoCliente, PuntosFidelidad) VALUES
('Ana', 'López', '+50255123456', 150),
('Jorge', 'Martínez', '+50244987654', 50),
('Sofía', 'Castillo', '+50233112233', 300);
GO

-- =============================================
-- 5. MESAS (Depende de Zonas)
-- =============================================
INSERT INTO Mesas (CapacidadMesa, EstadoMesa, IdZona) VALUES
(4, 'Disponible', 1), -- Terraza Principal
(2, 'Ocupada', 1),    -- Terraza Principal
(8, 'Disponible', 2), -- Salón VIP
(6, 'Reservada', 3);  -- Bar & Lounge
GO

-- =============================================
-- 6. TURNOS (Depende de Empleados)
-- =============================================
INSERT INTO Turnos (InicioTurno, FinalizacionTurno, IdEmpleado) VALUES
('2026-06-01 08:00:00', '2026-06-01 16:00:00', 1), -- Carlos (Admin)
('2026-06-01 12:00:00', '2026-06-01 20:00:00', 2), -- María (Mesero)
('2026-06-01 15:00:00', '2026-06-01 23:00:00', 3); -- Luis (Recepcionista)
GO

-- =============================================
-- 7. BITACORA (Depende de Empleados)
-- =============================================
INSERT INTO Bitacora (IdEmpleado, TipoOperacion, FechaOperacion, HoraOperacion, TablaAfectada, DescripcionBitacora) VALUES
(1, 'INSERT', '2026-06-01', '08:15:00', 'Menu', 'Se agregó el plato Lomo Saltado al menú general.'),
(3, 'UPDATE', '2026-06-01', '15:30:00', 'Mesas', 'Se cambió el estado de la mesa 2 a Ocupada.');
GO

-- =============================================
-- 8. RESERVAS (Depende de Clientes, Mesas y Empleados)
-- =============================================
INSERT INTO Reservas (IdCliente, IdMesa, IdEmpleado, FechaReserva, HoraReserva, AnticipoReserva) VALUES
(1, 3, 3, '2026-06-05', '19:30:00', 25.00),
(2, 4, 3, '2026-06-06', '21:00:00', 15.00);
GO

-- =============================================
-- 9. DETALLE RESERVA (Depende de Reservas y Menu)
-- =============================================
INSERT INTO DetalleReserva (IdReserva, IdMenu, CantidadReserva, Observaciones) VALUES
(1, 1, 2, 'Uno de los lomos bien cocido y sin cebolla.'),
(1, 3, 2, 'Postres para compartir.'),
(2, 2, 1, 'Ceviche con el ají aparte por favor.'),
(2, 4, 2, 'Bebidas con poco hielo.');
GO