-- Inserting dummy data into the Login table
INSERT INTO [Login] ([Username], [Password])
VALUES ('test', 'test');


-- Inserting dummy data into the Building table
INSERT INTO [Building] ([LoginId], [Address])
VALUES (1, 'USN');

-- Inserting dummy data into the Room table
INSERT INTO [Room] ([Name], [BuildingId])
VALUES ('C222', 1);


-- Inserting dummy data into the SensorType table
INSERT INTO [SensorType] ([Type])
VALUES ('PT100');


-- Inserting dummy data into the Sensor table
INSERT INTO [Sensor] ([Name], [Min], [Max], [Sd], [Mean], [RoomId], [TypeId])
VALUES ('Sensor1', 1, 1, 1, 1, 1, 1);


-- Inserting dummy data into the SensorValue table
INSERT INTO [SensorValue] ([Value], [SensorId])
VALUES (20, 1);