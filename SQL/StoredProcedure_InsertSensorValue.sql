CREATE PROCEDURE InsertSensorValue
    @SensorName NVARCHAR(50),
    @SensorValue FLOAT,
    @DateTime DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SensorId INT;

    -- Get SensorId based on SensorName
    SELECT @SensorId = SensorId
    FROM Sensor
    WHERE Name = @SensorName;

    IF @SensorId IS NOT NULL
    BEGIN
        -- Insert into SensorValue table
        INSERT INTO SensorValue (Value, SensorId, Time)
        VALUES (@SensorValue, @SensorId, @DateTime);

        PRINT 'Value inserted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Sensor not found.';
    END
END