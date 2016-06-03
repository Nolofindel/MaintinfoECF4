USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[RecupererArticle]    Script Date: 03/06/2016 08:46:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[RecupererArticle]
(
@DesignationArticle varchar(4)
)
AS
BEGIN
SELECT [DESIGNATION_ARTICLE],[PARENT_DESIGNATION_ARTICLE],[NOM_ARTICLE],[QUANTITE_STOCK],[SEUIL_MINIMAL]
FROM [dbo].[ARTICLE]
WHERE [DESIGNATION_ARTICLE]=@DesignationArticle
END