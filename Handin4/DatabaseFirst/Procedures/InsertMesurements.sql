CREATE PROCEDURE [dbo].[InsertMesurements]
	@SensorId int,
	@Value float
AS
	INSERT INTO Mesurements (SensorId, Timestamp, Value)
	VALUES (@SensorId, CURRENT_TIMESTAMP, @Value);
RETURN 0
