CREATE TRIGGER trg_InsertSensorValue
ON SensorValue
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SensorId INT;

    -- Get SensorId of the inserted value
    SELECT @SensorId = SensorId
    FROM inserted;

    -- Update min, max, sd, mean in Sensor table
    UPDATE Sensor
    SET
        [Min] = (SELECT MIN(Value) FROM SensorValue WHERE SensorId = @SensorId),
        [Max] = (SELECT MAX(Value) FROM SensorValue WHERE SensorId = @SensorId),
        [Sd] = ROUND((SELECT STDEV(Value) FROM SensorValue WHERE SensorId = @SensorId), 2),
        [Mean] = ROUND((SELECT AVG(Value) FROM SensorValue WHERE SensorId = @SensorId), 2)
    WHERE SensorId = @SensorId;
END