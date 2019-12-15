USE [SinavSistemi]
GO
/****** Object:  StoredProcedure [dbo].[OgrenciBasariGetir]    Script Date: 15.12.2019 21:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[OgrenciBasariGetir] @ogrenciID int,@sinavNo int
AS
SELECT konuAdi,basariOrani,sinavID FROM tbl_Basari B INNER JOIN tbl_Konu K 
ON K.konuID = B.konuID
WHERE ogrenciID = @ogrenciID AND sinavID = @sinavNo
