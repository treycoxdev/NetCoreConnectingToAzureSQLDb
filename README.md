# NetCoreConnectingToAzureSQLDb

This is a template for an .net core web api that can connect to an azure sql database

Most of this template is based on the tutorial by https://www.bacancytechnology.com/blog/web-api-in-net-6

Add the DBContext Manually if developing from scratch

Add a file called "appsettings.Development.json" that is identical to appsetting.json and fill in the connection string

Here is the code to make the testing table in an azure SQL database

CREATE TABLE Sample (
SampleId INT IDENTITY(1,1) PRIMARY KEY,
SampleName NVARCHAR(50) NOT NULL
);

INSERT INTO Sample (SampleName)
VALUES ('Sample 1'), ('Sample 2'), ('Sample 3');
