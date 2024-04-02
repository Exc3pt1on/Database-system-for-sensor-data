CREATE Procedure CheckLogin
	@Username char(50), 
	@Password char(64)

AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Login WHERE Username = @Username AND Password = @Password)
		SELECT 1 AS ResultCode, (SELECT FirstName FROM Login WHERE Username = @Username) as ResultMessage;
	ELSE
		SELECT 0 AS ResultCode;
END
