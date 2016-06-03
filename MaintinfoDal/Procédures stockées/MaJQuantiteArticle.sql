USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[MaJQuantiteArticle]    Script Date: 03/06/2016 08:42:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[MaJQuantiteArticle]
(
@DesignationArticle varchar(4)
,@Quantite int
)
AS
BEGIN
UPDATE [dbo].[ARTICLE]
SET [QUANTITE_STOCK]=@Quantite
WHERE [DESIGNATION_ARTICLE]=@DesignationArticle
END

