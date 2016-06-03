USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[RecupererCatalogueParCategorie]    Script Date: 03/06/2016 08:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[RecupererCatalogueParCategorie]
(
@Categorie char
)
AS
BEGIN
SELECT [DESIGNATION_ARTICLE],[PARENT_DESIGNATION_ARTICLE],[NOM_ARTICLE],[QUANTITE_STOCK],[SEUIL_MINIMAL]
FROM [dbo].[ARTICLE]
WHERE [DESIGNATION_ARTICLE] LIKE @Categorie+'%'
END