USE [p2766188]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStaff_FilterByAddressId]
		@StaffId = 5

SELECT	@return_value as 'Return Value'

GO
