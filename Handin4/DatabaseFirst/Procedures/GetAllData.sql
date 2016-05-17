CREATE PROCEDURE [dbo].[GetAllData]
	@ApartmentId int = 0
AS
	SELECT * 
	FROM GetFunction() AS mes
	INNER JOIN Sensors AS sen
	ON sen.SensorId = mes.SensorId
	WHERE sen.ApartmentId = @ApartmentId
RETURN

