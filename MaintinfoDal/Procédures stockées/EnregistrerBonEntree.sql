USE [Maintinfo]
GO
/****** Object:  StoredProcedure [dbo].[EnregistrerBonEntree]    Script Date: 03/06/2016 08:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[EnregistrerBonEntree]
(
@DateEntree datetime
,@ArticleEntree varchar(4)
,@QuantiteEntree int
,@NumEntree int out
)
AS
BEGIN
insert[dbo].[BON_ENTREE]([DATE_ENTREE],[DESIGNATION_ARTICLE],[QUANTITE_ENTREE])
	values(@DateEntree,@ArticleEntree,@QuantiteEntree)
	select @NumEntree = SCOPE_IDENTITY()
END