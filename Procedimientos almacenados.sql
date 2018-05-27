-- SP Insertar Cliente

CREATE PROCEDURE InsertarCliente 
				 @_ClienteID AS NVARCHAR(50),
				 @_Nombre AS NVARCHAR(50),
				 @_Apellidos AS NVARCHAR(50),
				 @_Direccion AS NVARCHAR(50),
				 @_Telefono AS NVARCHAR(50),
				 @_Email AS NVARCHAR(50),
				 @_Fecha_Ingreso AS DATETIME,
				 @_Sexo AS NVARCHAR(50),
				 @_TipoClienteID AS NVARCHAR(50),
				 @_Clave AS NVARCHAR(MAX)
AS
SET NOCOUNT ON;
BEGIN
INSERT INTO Clientes VALUES (@_TipoClienteID,  @_Nombre, @_Apellidos, @_Direccion, @_Telefono, 
                             @_Email, @_Fecha_Ingreso, @_Sexo, @_Clave) 
END

-- SP Actualizar Cliente

CREATE PROCEDURE ActualizarCliente 
				 @_ClienteID AS NVARCHAR(50),
				 @_Nombre AS NVARCHAR(50),
				 @_Apellidos AS NVARCHAR(50),
				 @_Direccion AS NVARCHAR(50),
				 @_Telefono AS NVARCHAR(50),
				 @_Email AS NVARCHAR(50),
				 @_Fecha_Ingreso AS DATETIME,
				 @_Sexo AS NVARCHAR(50),
				 @_TipoClienteID AS NVARCHAR(50),
				 @_Clave AS NVARCHAR(MAX)
AS
SET NOCOUNT ON;
BEGIN

UPDATE Clientes
SET TipoClienteID = @_TipoClienteID, 
    Nombre = @_Nombre, 
	Apellidos = @_Apellidos, 
	Direccion = @_Direccion, 
	Telefono = @_Telefono, 
    Email = @_Email, 
	Fecha_Ingreso = @_Fecha_Ingreso, 
	Sexo = @_Sexo, 
	Clave = @_Clave
WHERE ClienteID = @_ClienteID

END

-- SP Eliminar Cliente

CREATE PROCEDURE EliminarCliente 
                 @_ClienteID AS NVARCHAR(50)
AS
BEGIN
SET NOCOUNT ON;

DELETE 
FROM Clientes 
WHERE ClienteID = @_ClienteID

END

-- SP Buscar Cliente

CREATE PROCEDURE BuscarCliente
				 @_ClienteID AS NVARCHAR(50)
AS
BEGIN
SET NOCOUNT ON;

SELECT ClienteID,
       Nombre,
	   Apellidos,
	   Direccion,
	   Telefono,
	   Email,
	   Fecha_Ingreso,
	   TipoClienteID,
	   Sexo,
	   Clave
FROM Clientes
WHERE ClienteID = @_ClienteID

END

-- SP Listar Clientes

CREATE PROCEDURE ListarClientes
AS
BEGIN
SET NOCOUNT ON;

SELECT ClienteID,
       Nombre,
	   Apellidos,
	   Direccion,
	   Telefono,
	   Email,
	   Fecha_Ingreso,
	   TipoClienteID,
	   Sexo,
	   Clave
FROM Clientes

END