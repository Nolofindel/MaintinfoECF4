USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[EnregistrerBonDeCommande]    Script Date: 03/06/2016 08:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[EnregistrerBonDeCommande]
(
@DateCommande datetime
,@ArticleCommande varchar(4)
,@QuantiteCommande int
,@NumCommande int out
)
AS
BEGIN
INSERT [dbo].[BON_DE_COMMANDE]([DATE_COMMANDE],[DESIGNATION_ARTICLE],[QUANTITE_COMMANDE])
	values(@DateCommande,@ArticleCommande,@QuantiteCommande)
	select @NumCommande =SCOPE_IDENTITY() 
END
