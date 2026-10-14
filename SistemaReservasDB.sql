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