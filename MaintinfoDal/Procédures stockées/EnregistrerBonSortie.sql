USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[EnregistrerBonSortie]    Script Date: 03/06/2016 08:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[EnregistrerBonSortie]
(
@MatDepanneur  int
,@DateDemande datetime
,@ArticleSortie varchar(4)
,@QuantiteSortie int
,@NumSortie int out
)
AS
BEGIN
INSERT[dbo].[BON_SORTIE]([MATRICULE_DEPANNEUR],[DATE_SORTIE],[DESIGNATION_ARTICLE],[QUANTITE_SORTIE])
	VALUES(@MatDepanneur,@DateDemande,@ArticleSortie,@QuantiteSortie)
	SELECT @NumSortie = SCOPE_IDENTITY()
END