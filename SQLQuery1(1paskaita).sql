/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ASMENSKODAS]
      ,[VARDAS]
      ,[PAVARDE]
      ,[DIRBANUO]
      ,[GIMIMOMETAI]
      ,[PAREIGOS]
      ,[SKYRIUS_PAVADINIMAS]
      ,[PROJEKTAS_ID]
  FROM [Projektas].[dbo].[DARBUOTOJAS] WHERE[Vardas] = 'Giedrius'
  SELECT [VARDAS], [PAVARDE], [PAREIGOS]
  FROM [Projektas].[dbo].DARBUOTOJAS 
  SELECT DISTINCT [SKYRIUS_PAVADINIMAS]
  FROM [Projektas].[dbo].[DARBUOTOJAS]
  SELECT [SKYRIUS_PAVADINIMAS]
  FROM [Projektas].[dbo].[DARBUOTOJAS]

  SELECT [PAREIGOS]
  FROM [Projektas].[dbo].[DARBUOTOJAS] WHERE[Vardas] = 'Giedrius'

  SELECT *
  FROM [Projektas].[dbo].[DARBUOTOJAS] WHERE[GIMIMOMETAI] = '1986-09-19'

    SELECT  [VARDAS]
	  FROM [Projektas].[dbo].[DARBUOTOJAS] WHERE[PAVARDE] = 'Sabutis'
INSERT INTO  [Projektas].[dbo].[DARBUOTOJAS]( [ASMENSKODAS]
      ,[VARDAS]
      ,[PAVARDE]
      ,[DIRBANUO]
      ,[GIMIMOMETAI]) VALUES('32232323223','Jonas','Zvyras','2019-02-02','1989-02-02')

DELETE FROM [Projektas].[dbo].[DARBUOTOJAS] WHERE [ASMENSKODAS] = '32232323223'
INSERT INTO  [Projektas].[dbo].[DARBUOTOJAS]([ASMENSKODAS],[PAVARDE],[PAREIGOS]) 
VALUES ('12345678901','ANTANAITIS','Programuotojas'),
		('12345678902','ANTANAITIS','Programuotojas')
UPDATE [Projektas].[dbo].[DARBUOTOJAS] SET [PAREIGOS] = 'Testuotojas' 
WHERE [PAVARDE] = 'ANTANAITIS'
SELECT [PAREIGOS] = 'Testuotojas'
FROM [Projektas].[dbo].[DARBUOTOJAS]

