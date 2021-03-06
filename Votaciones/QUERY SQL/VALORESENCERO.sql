USE MASTER
GO
CREATE DATABASE CANDIDATOS
GO
USE [CANDIDATOS]
GO
/****** Object:  Table [dbo].[ELEJIDOS]    Script Date: 02/12/2020 3:16:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ELEJIDOS](
	[NUMEROTARJETON] [varchar](10) NOT NULL,
	[NOMBRE] [varchar](100) NOT NULL,
	[CANTIDADVOTOS] [int] NULL,
	[PARTIDO] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Candidato-Votos]    Script Date: 02/12/2020 3:16:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Candidato-Votos]
AS
SELECT        NOMBRE, CANTIDADVOTOS
FROM            dbo.ELEJIDOS
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'1', N'DANIEL', 0, N'VERDE')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'2', N'CAMILA', 0, N'ROJO')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'3', N'JOSE', 0, N'NARANJA')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'4', N'ANA', 0, N'AZUL')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'5', N'MATEO', 0, N'GRIS')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'6', N'CARLOS', 0, N'ROJO')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'7', N'SANTIAGO', 0, N'ROJO')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'8', N'BRYAN', 0, N'ROJO')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'9', N'RAMIRO', 0, N'NARANJA')
GO
INSERT [dbo].[ELEJIDOS] ([NUMEROTARJETON], [NOMBRE], [CANTIDADVOTOS], [PARTIDO]) VALUES (N'10', N'ANDRES', 0, N'AZUL')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ELEJIDOS"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Candidato-Votos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Candidato-Votos'
GO
