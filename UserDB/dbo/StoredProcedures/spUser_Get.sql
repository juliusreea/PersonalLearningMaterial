CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin
	SELECT *
	FROM dbo.[User]
	WHERE Id = @Id;
end
