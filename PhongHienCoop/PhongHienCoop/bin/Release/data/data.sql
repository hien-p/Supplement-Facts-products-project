USE [master]
GO
/****** Object:  Database [PhongHienCoop]    Script Date: 12/11/2022 9:21:15 PM ******/
CREATE DATABASE [PhongHienCoop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PhongHienCoop_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PhongHienCoop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PhongHienCoop_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PhongHienCoop.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PhongHienCoop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PhongHienCoop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PhongHienCoop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PhongHienCoop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PhongHienCoop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PhongHienCoop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PhongHienCoop] SET ARITHABORT OFF 
GO
ALTER DATABASE [PhongHienCoop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PhongHienCoop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PhongHienCoop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PhongHienCoop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PhongHienCoop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PhongHienCoop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PhongHienCoop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PhongHienCoop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PhongHienCoop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PhongHienCoop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PhongHienCoop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PhongHienCoop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PhongHienCoop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PhongHienCoop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PhongHienCoop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PhongHienCoop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PhongHienCoop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PhongHienCoop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PhongHienCoop] SET  MULTI_USER 
GO
ALTER DATABASE [PhongHienCoop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PhongHienCoop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PhongHienCoop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PhongHienCoop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PhongHienCoop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PhongHienCoop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PhongHienCoop] SET QUERY_STORE = OFF
GO
USE [PhongHienCoop]
GO
/****** Object:  Table [dbo].[Accountant]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accountant](
	[accountant_id] [int] NOT NULL,
	[accountant_name] [varchar](50) NOT NULL,
	[acc_password] [varchar](50) NOT NULL,
	[name] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[acc_email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[accountant_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agents]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agents](
	[agent_id] [int] NOT NULL,
	[agent_name] [varchar](50) NOT NULL,
	[agent_pass] [varchar](50) NOT NULL,
	[agent_telenum] [int] NOT NULL,
	[agent_address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[agent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[bill_id] [int] NOT NULL,
	[product_id] [int] NULL,
	[product_name] [varchar](50) NULL,
	[price] [int] NULL,
	[shipment_id] [int] NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodsDeliveryNote]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodsDeliveryNote](
	[products_id] [int] IDENTITY(1,1) NOT NULL,
	[GDN_id] [int] NULL,
	[agents_name] [nvarchar](255) NULL,
	[agents_phone] [nvarchar](50) NULL,
	[GDN_date] [date] NULL,
	[product_name] [nvarchar](255) NOT NULL,
	[quantity] [int] NULL,
	[price_per_prod] [int] NULL,
	[payment_status] [nvarchar](255) NOT NULL,
	[shipping_status] [nvarchar](255) NULL,
 CONSTRAINT [PK__GoodsDel__D5706EBCCCB27752] PRIMARY KEY CLUSTERED 
(
	[products_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodsRecievedNote]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodsRecievedNote](
	[products_id] [int] IDENTITY(1,1) NOT NULL,
	[GRN_id] [int] NULL,
	[agents_name] [nvarchar](255) NULL,
	[agents_phone] [nvarchar](255) NOT NULL,
	[GRN_date] [date] NULL,
	[product_name] [nvarchar](255) NULL,
	[quantity] [int] NULL,
	[price_per_prod] [int] NULL,
	[total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[products_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] NOT NULL,
	[order_date] [date] NOT NULL,
	[product_id] [int] NOT NULL,
	[agent_id] [int] NULL,
	[agent_tel] [int] NULL,
	[price] [int] NULL,
	[quantity] [int] NULL,
	[agent_address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[product_id] [int] NOT NULL,
	[product_name] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[product_info] [nvarchar](max) NOT NULL,
	[product_img] [nvarchar](255) NULL,
 CONSTRAINT [PK__Products__47027DF51C348EEF] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipment]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipment](
	[shipment_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[shipment_date] [date] NOT NULL,
	[agent_name] [varchar](50) NULL,
	[agent_tel] [int] NOT NULL,
	[shipment_status] [varchar](50) NULL,
	[bill_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[shipment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[product_id] [int] NOT NULL,
	[product_name] [varchar](50) NOT NULL,
	[price_in] [decimal](10, 2) NULL,
	[price_out] [decimal](10, 2) NULL,
	[quantity] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Accountant] ([accountant_id], [accountant_name], [acc_password], [name], [phone], [acc_email]) VALUES (1, N'Phong', N'123456', NULL, NULL, NULL)
INSERT [dbo].[Accountant] ([accountant_id], [accountant_name], [acc_password], [name], [phone], [acc_email]) VALUES (2, N'Hien', N'123456', NULL, NULL, NULL)
GO
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (1, N'agents1', N'123456', 904769075, N'19 Nguyen Huu Tho, p.Tan Phong, Quan 7')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (2, N'agents2', N'123456', 957473213, N'781 Nguyen Huu Tho, p.Tan Phong, Quan 7, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (3, N'agents3', N'123456', 931143341, N'23 Lam Van Ben, p.Tan Phong, Quan 7, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (4, N'agents4', N'123456', 931234111, N'360A Ben Van Don, p1, Quan 4, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (5, N'agents5', N'123456', 901434557, N'25 Nguyen Thai Binh, p1, Quan 1, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (6, N'agents6', N'123456', 904769075, N'35 Tran Hung Dao, p1, Quan 1, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (7, N'agents7', N'123456', 901235652, N'1213 Nguyen Huu Canh, p.Tan Phong, VungTau')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (8, N'agents8', N'123456', 902198501, N'233 Le Van Luong, p.Tan Phong, Quan 7, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (9, N'agents9', N'123456', 903476191, N'19 Tran Xuan Soan, p.Tan Hung, Quan 7, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (10, N'agents10', N'123456', 901245781, N'1 Mai Van Vinh, p.Tan Phong, Quan 7, HCM')
INSERT [dbo].[Agents] ([agent_id], [agent_name], [agent_pass], [agent_telenum], [agent_address]) VALUES (11, N'agents11', N'123456', 908038742, N'361 Binh Gia, p.Tan Phong, Quan 8, HCM')
GO
SET IDENTITY_INSERT [dbo].[GoodsDeliveryNote] ON 

INSERT [dbo].[GoodsDeliveryNote] ([products_id], [GDN_id], [agents_name], [agents_phone], [GDN_date], [product_name], [quantity], [price_per_prod], [payment_status], [shipping_status]) VALUES (1, 336, N'agent10', N'901245781', CAST(N'2022-11-12' AS Date), N'Centrum Adults Multivitamin', 10, 100000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[GoodsDeliveryNote] ([products_id], [GDN_id], [agents_name], [agents_phone], [GDN_date], [product_name], [quantity], [price_per_prod], [payment_status], [shipping_status]) VALUES (3, 313, N'agent5', N'901434557', CAST(N'2022-11-12' AS Date), N'Puritan’s Pride', 100, 175000, N'Đã thanh toán', N'Đã xử lý')
INSERT [dbo].[GoodsDeliveryNote] ([products_id], [GDN_id], [agents_name], [agents_phone], [GDN_date], [product_name], [quantity], [price_per_prod], [payment_status], [shipping_status]) VALUES (4, 332, N'agent4', N'931234111', CAST(N'2022-11-12' AS Date), N'One A Day', 2000, 300000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[GoodsDeliveryNote] ([products_id], [GDN_id], [agents_name], [agents_phone], [GDN_date], [product_name], [quantity], [price_per_prod], [payment_status], [shipping_status]) VALUES (5, 313, N'agent5', N'901434557', CAST(N'2022-11-12' AS Date), N'Orihiro Most Chewable', 100, 175000, N'Đã thanh toán', N'Đã xử lý')
INSERT [dbo].[GoodsDeliveryNote] ([products_id], [GDN_id], [agents_name], [agents_phone], [GDN_date], [product_name], [quantity], [price_per_prod], [payment_status], [shipping_status]) VALUES (7, 332, N'agent4', N'931234111', CAST(N'2022-11-12' AS Date), N'DHC vitamin', 2000, 300000, N'Chưa thanh toán', N'Đang xử lý')
SET IDENTITY_INSERT [dbo].[GoodsDeliveryNote] OFF
GO
SET IDENTITY_INSERT [dbo].[GoodsRecievedNote] ON 

INSERT [dbo].[GoodsRecievedNote] ([products_id], [GRN_id], [agents_name], [agents_phone], [GRN_date], [product_name], [quantity], [price_per_prod], [total]) VALUES (1, 246, N'agent1', N'0904769075', CAST(N'2022-12-10' AS Date), N'Centrum Adults Multivitamin', 10, 100000, 1000000)
INSERT [dbo].[GoodsRecievedNote] ([products_id], [GRN_id], [agents_name], [agents_phone], [GRN_date], [product_name], [quantity], [price_per_prod], [total]) VALUES (2, 249, N'agent6', N'0904769075', CAST(N'2022-10-11' AS Date), N'Blackmores Multivitamin', 15000, 200000, 300000000)
INSERT [dbo].[GoodsRecievedNote] ([products_id], [GRN_id], [agents_name], [agents_phone], [GRN_date], [product_name], [quantity], [price_per_prod], [total]) VALUES (4, 247, N'agent2', N'0904769075', CAST(N'2022-12-15' AS Date), N'One A Day', 200, 300000, 60000000)
INSERT [dbo].[GoodsRecievedNote] ([products_id], [GRN_id], [agents_name], [agents_phone], [GRN_date], [product_name], [quantity], [price_per_prod], [total]) VALUES (5, 251, N'agent5', N'0901434557', CAST(N'2022-11-15' AS Date), N'Orihiro Most Chewable', 500, 500000, 250000000)
INSERT [dbo].[GoodsRecievedNote] ([products_id], [GRN_id], [agents_name], [agents_phone], [GRN_date], [product_name], [quantity], [price_per_prod], [total]) VALUES (7, 250, N'agent2', N'0904769075', CAST(N'2022-12-15' AS Date), N'DHC vitamin', 200, 300000, 60000000)
INSERT [dbo].[GoodsRecievedNote] ([products_id], [GRN_id], [agents_name], [agents_phone], [GRN_date], [product_name], [quantity], [price_per_prod], [total]) VALUES (8, 248, N'agent5', N'0901434557', CAST(N'2022-12-15' AS Date), N'MegaActiv', 500, 500000, 250000000)
SET IDENTITY_INSERT [dbo].[GoodsRecievedNote] OFF
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [product_id], [agent_id], [agent_tel], [price], [quantity], [agent_address]) VALUES (1, CAST(N'2022-12-10' AS Date), 1, 1, 904769075, 1000000, 10, N'19 Nguyen Huu Tho, p.Tan Phong, Quan 7')
INSERT [dbo].[Orders] ([order_id], [order_date], [product_id], [agent_id], [agent_tel], [price], [quantity], [agent_address]) VALUES (2, CAST(N'2022-10-11' AS Date), 1, 6, 904769075, 300000000, 15000, N'35 Tran Hung Dao, p1, Quan 1, HCM')
INSERT [dbo].[Orders] ([order_id], [order_date], [product_id], [agent_id], [agent_tel], [price], [quantity], [agent_address]) VALUES (3, CAST(N'2022-12-15' AS Date), 1, 2, 904769075, 60000000, 200, N'781 Nguyen Huu Tho, p.Tan Phong, Quan 7, HCM')
INSERT [dbo].[Orders] ([order_id], [order_date], [product_id], [agent_id], [agent_tel], [price], [quantity], [agent_address]) VALUES (4, CAST(N'2022-11-15' AS Date), 1, 5, 901434557, 250000000, 500, N'25 Nguyen Thai Binh, p1, Quan 1, HCM')
INSERT [dbo].[Orders] ([order_id], [order_date], [product_id], [agent_id], [agent_tel], [price], [quantity], [agent_address]) VALUES (5, CAST(N'2022-12-15' AS Date), 1, 2, 904769075, 60000000, 200, N'781 Nguyen Huu Tho, p.Tan Phong, Quan 7, HCM')
GO
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (1, N'Centrum Adults Multivitamin', 100000, N'Centrum Adults Under 50 có chứa các loại vitamin A, C, D, E, K, B6, B12 và một số vitamin nhóm B dưới dạng riboflavin, niacin, thiamin, folic acid và biotin. Đặc biệt, sản phẩm còn chứa nhiều chất khoáng thiết yếu cho cơ thể như: canxi, sắt, clo, photpho, iot, kẽm, magie, đồng, crom, selen cùng một số chất khoáng khác.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (2, N'Blackmores Multivitamin', 200000, N'Viên uống Blackmores Multivitamin + Energy là thực phẩm chức năng bổ sung vitamin và khoáng chất hỗ trợ tăng cường sức khỏe và hồi phục năng lượng. Điểm nổi bật của sản phẩm là sự kết hợp giữa nhiều vitamin nhóm B cùng các loại khoáng chất thiết yếu khác.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (3, N'Puritan’s Pride', 175000, N'Puritan’s pride có hai sản phẩm được biết đến là thực phẩm chức năng bổ sung vitamin và khoáng chất dành cho hai đối tượng khác nhau là nam và nữ. One Daily Men Multivitamin là viên uống bổ sung vitamin và chất khoáng dành cho nam giới. Trong khi đó, One Daily Women’s Multivitamin là viên uống bổ sung vitamin và chất khoáng dành cho nữ giới.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (4, N'One A Day', 300000, N'One A Day là một thương hiệu dược phẩm nổi tiếng ở Mỹ thuộc tập đoàn Bayer với nhiều sản phẩm nổi tiếng trong lĩnh vực bảo vệ và chăm sóc sức khỏe. Đúng như tên gọi của thương hiệu, các sản phẩm One A Day đáp ứng nhu cầu của người dùng chỉ với một viên uống mỗi ngày. Điều này không chỉ giúp việc sử dụng sản phẩm trở nên thuận tiện hơn mà còn đem lại hiệu quả nhanh chóng.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (5, N'Orihiro Most Chewable', 215000, N'Sản phẩm là sự kết hợp của nhiều loại vitamin và khoáng chất cần thiết cho hoạt động sống mỗi ngày. Các vitamin có trong viên nhai chính là các vitamin A, C, D, E, K, B1, B2, B6, B12. Ngoài ra còn có một số vitamin dưới dạng niacin, biotin, folic acid và pantothenic acid. Một số chất khoáng canxi, magie, sắt, kẽm, selen cũng được bổ sung vào viên nhai bổ sung vitamin và khoáng chất Orihiro Most Chewable.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (6, N'Daily Multi Kirkland Signature', 315000, N'Viên uống Daily Multi Kirkland Signature là sản phẩm thực phẩm chức năng bổ sung vitamin và khoáng chất hàng ngày cho cơ thể. Sản phẩm hỗ trợ bổ sung đúng cách các chất dinh dưỡng bị thiếu hụt trong chế độ ăn uống hàng ngày.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (7, N'DHC vitamin', 400000, N'DHC là hãng thực phẩm chức năng đến từ Nhật Bản và đang được rất nhiều khách hàng Việt Nam tin dùng hiện nay. Các sản phẩm bổ sung dưỡng chất của DHC luôn đa dạng với nhiều dưỡng chất khác nhau phù hợp với nhu cầu thể trạng của từng đối tượng sử dụng.', NULL)
INSERT [dbo].[Products] ([product_id], [product_name], [price], [product_info], [product_img]) VALUES (8, N'MegaActiv', 500000, N'Bổ sung vitamin và khoáng chất cho cơ thể. Hỗ trợ tăng cường sức khỏe và sức đề kháng cho cơ thể.', NULL)
GO
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (1, N'Centrum Adults Multivitamin', CAST(75000.00 AS Decimal(10, 2)), CAST(100000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (2, N'Blackmores Multivitamin', CAST(150000.00 AS Decimal(10, 2)), CAST(200000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (3, N'Puritan’s Pride', CAST(100000.00 AS Decimal(10, 2)), CAST(175000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (4, N'One A Day', CAST(250000.00 AS Decimal(10, 2)), CAST(300000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (5, N'Orihiro Most Chewable', CAST(150000.00 AS Decimal(10, 2)), CAST(215000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (6, N'Daily Multi Kirkland Signature', CAST(250000.00 AS Decimal(10, 2)), CAST(315000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (7, N'DHC vitamin', CAST(75000.00 AS Decimal(10, 2)), CAST(100000.00 AS Decimal(10, 2)), 100000)
INSERT [dbo].[Warehouse] ([product_id], [product_name], [price_in], [price_out], [quantity]) VALUES (8, N'MegaActiv', CAST(400000.00 AS Decimal(10, 2)), CAST(500000.00 AS Decimal(10, 2)), 100000)
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK__BillDetai__shipm__4222D4EF] FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([product_id])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK__BillDetai__shipm__4222D4EF]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD FOREIGN KEY([shipment_id])
REFERENCES [dbo].[Shipment] ([shipment_id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([agent_id])
REFERENCES [dbo].[Agents] ([agent_id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__product___300424B4] FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([product_id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__product___300424B4]
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD FOREIGN KEY([bill_id])
REFERENCES [dbo].[BillDetails] ([bill_id])
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK__Warehouse__produ__2B3F6F97] FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([product_id])
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK__Warehouse__produ__2B3F6F97]
GO
/****** Object:  StoredProcedure [dbo].[USERSYSTEM_CHECKLOGIN]    Script Date: 12/11/2022 9:21:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USERSYSTEM_CHECKLOGIN] 
@username varchar(50), 
@password varchar(50)

as 

select accountant_name, acc_password, name
from Accountant
where @username = accountant_name and @password = acc_password

GO
USE [master]
GO
ALTER DATABASE [PhongHienCoop] SET  READ_WRITE 
GO
