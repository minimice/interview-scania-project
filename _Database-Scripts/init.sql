INSERT INTO dbo.Customers VALUES('Kalles Grustransporter AB','Cementvägen 8, 111 11 Södertälje');
INSERT INTO dbo.Customers VALUES('Johans Bulk AB','Balkvägen 12, 222 22 Stockholm');
INSERT INTO dbo.Customers VALUES('Haralds Värdetransporter AB','Budgetvägen 1, 333 33 Uppsala');

INSERT INTO dbo.CustomerVehicles VALUES('YS2R4X2000539940','ABC123','OK',1);
INSERT INTO dbo.CustomerVehicles VALUES('VLUR4X20009093588','DEF456','OK',1);
INSERT INTO dbo.CustomerVehicles VALUES('VLUR4X20009048066','GHI789','OK',1);

INSERT INTO dbo.CustomerVehicles VALUES('YS2R4X20005388011','JKL012','OK',2);
INSERT INTO dbo.CustomerVehicles VALUES('YS2R4X20005387949','MNO345','OK',2);

INSERT INTO dbo.CustomerVehicles VALUES('YS2R4X20005387765','PQR678','NOTOK',3);
INSERT INTO dbo.CustomerVehicles VALUES('YS2R4X20005387055','STU901','NOTOK',3);
