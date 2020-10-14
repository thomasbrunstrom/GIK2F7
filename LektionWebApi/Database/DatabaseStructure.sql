-- SQLite
-- DROP TABLE IF EXISTS Games;
CREATE TABLE IF NOT EXISTS Persons 
    (Id integer primary key AUTOINCREMENT, 
        FirstName VARCHAR(100) NOT NULL,
        LastName VARCHAR(100) NOT NULL,
        Image VARCHAR(512) NULL
    );