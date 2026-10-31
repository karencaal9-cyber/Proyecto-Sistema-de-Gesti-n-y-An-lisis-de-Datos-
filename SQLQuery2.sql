SELECT *
FROM Mesas
WHERE IdMesa = 2;

SELECT *
FROM Reservas
WHERE IdMesa = 2;

SET IDENTITY_INSERT Mesas ON;

INSERT INTO Mesas (IdMesa, CapacidadMesa, EstadoMesa, IdZona)
VALUES (2, 2, 'Ocupada', 1);

SET IDENTITY_INSERT Mesas OFF;


SELECT *
FROM Mesas
WHERE IdMesa = 2;