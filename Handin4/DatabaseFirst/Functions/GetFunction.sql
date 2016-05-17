CREATE FUNCTION [dbo].[GetFunction]
(
)
RETURNS TABLE AS RETURN
(
	SELECT * FROM Mesurements
)