IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Academia')
BEGIN
    CREATE DATABASE Academia;
END
GO

USE Academia;
GO