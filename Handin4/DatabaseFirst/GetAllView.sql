CREATE VIEW [dbo].[GetAllView] AS
	SELECT 
	mesurement.MesurementId, mesurement.Timestamp, mesurement.Value,
	sensor.SensorId, sensor.ApartmentId
	FROM Mesurements AS mesurement
	INNER JOIN Sensors AS sensor
	ON sensor.SensorId = mesurement.SensorId;
