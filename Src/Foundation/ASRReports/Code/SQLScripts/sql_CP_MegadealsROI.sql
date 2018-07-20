-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sql_CP_MegadealsROI')
DROP PROCEDURE sql_CP_MegadealsROI
GO

CREATE PROCEDURE sql_CP_MegadealsROI
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [CustomerID]
      ,[CreateDate]
      ,[CampaignName]
      ,[CustomerName]
      ,[Email]
      ,[CustomerDetail1]
      ,[CustomerDetail2]
  FROM [MegadealsROI];
END
GO
