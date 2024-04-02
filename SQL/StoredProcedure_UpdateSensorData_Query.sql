CREATE PROCEDURE UpdateSensorData
	@Name nChar(18),
    @NewValue FLOAT,
	@Min FLOAT,
	@Max FLOAT,
	@Sd FLOAT,
	@Mean FLOAT
AS
BEGIN
    -- Update the sensor values
    UPDATE Sensor
    SET [value] = @NewValue, [min] = @Min, [max] = @Max, sd = @Sd, mean = @Mean
	WHERE name = @Name;
END;