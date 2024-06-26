USE [VehicalRentalSystem]
GO
/****** Object:  User [5611-LAP-0083\aditee.khedekar_codi]    Script Date: 6/7/2024 12:30:30 PM ******/
CREATE USER [5611-LAP-0083\aditee.khedekar_codi] FOR LOGIN [5611-LAP-0083\aditee.khedekar_codi] WITH DEFAULT_SCHEMA=[5611-LAP-0083\aditee.khedekar_codi]
GO
/****** Object:  Schema [5611-LAP-0083\aditee.khedekar_codi]    Script Date: 6/7/2024 12:30:30 PM ******/
CREATE SCHEMA [5611-LAP-0083\aditee.khedekar_codi]
GO
/****** Object:  Table [5611-LAP-0083\aditee.khedekar_codi].[__EFMigrationsHistory]    Script Date: 6/7/2024 12:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [5611-LAP-0083\aditee.khedekar_codi].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Booking_Id] [uniqueidentifier] NOT NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
	[Vehical_Id] [uniqueidentifier] NOT NULL,
	[Rental_Start_Date] [datetime] NOT NULL,
	[Rental_End_Date] [datetime] NOT NULL,
	[Total_Rental_Cost] [decimal](18, 0) NOT NULL,
	[Insurance_Option] [bit] NOT NULL,
	[Pickup_Location] [nvarchar](50) NOT NULL,
	[Drop_Off_Location] [nvarchar](50) NOT NULL,
	[Additional_Charges] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[Booking_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chat]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chat](
	[Chat_Id] [uniqueidentifier] NOT NULL,
	[SUser_Id] [uniqueidentifier] NULL,
	[RUser_Id] [uniqueidentifier] NULL,
	[Conversation_Start_Time] [datetime] NOT NULL,
	[Messege_Context] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Chat_1] PRIMARY KEY CLUSTERED 
(
	[Chat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Damage]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Damage](
	[Damage_Id] [uniqueidentifier] NOT NULL,
	[Booking_Id] [uniqueidentifier] NOT NULL,
	[Description_Of_Damage] [nvarchar](max) NOT NULL,
	[Damage_Image] [varbinary](max) NOT NULL,
	[Cost] [decimal](18, 0) NOT NULL,
	[Insurance_Coverage] [decimal](18, 0) NOT NULL,
	[Total_damage_Cost] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Damage_1] PRIMARY KEY CLUSTERED 
(
	[Damage_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[Feedback_Id] [uniqueidentifier] NOT NULL,
	[Transaction_Id] [uniqueidentifier] NOT NULL,
	[Rating] [int] NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[Feedback_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Payment_Id] [uniqueidentifier] NOT NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
	[Booking_Id] [uniqueidentifier] NOT NULL,
	[Damage_Id] [uniqueidentifier] NOT NULL,
	[Total_Payment] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Payment_1] PRIMARY KEY CLUSTERED 
(
	[Payment_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_Transaction]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_Transaction](
	[Transaction_Id] [uniqueidentifier] NOT NULL,
	[Payment_Id] [uniqueidentifier] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Transaction_Date] [datetime] NOT NULL,
	[Payment_Method] [varchar](50) NOT NULL,
	[Proof_Of_Payment] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_Rental_Transaction_1] PRIMARY KEY CLUSTERED 
(
	[Transaction_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Age] [int] NOT NULL,
	[Phone_No] [bigint] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Goverment_Doc] [nvarchar](max) NULL,
	[Username] [varchar](50) NULL,
	[Password1] [nvarchar](100) NULL,
	[Password2] [varchar](50) NOT NULL,
	[ResetToken] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehical]    Script Date: 6/7/2024 12:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehical](
	[Vehical_Id] [uniqueidentifier] NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[License_No] [nvarchar](50) NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Mileage] [int] NOT NULL,
	[Availability_Status] [bit] NOT NULL,
	[Rental_rate_Per_Hour] [int] NOT NULL,
	[Insurance_Available] [bit] NOT NULL,
	[Vehical_Photo] [nvarchar](max) NULL,
	[Insurance_Info] [nvarchar](max) NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Vehical_1] PRIMARY KEY CLUSTERED 
(
	[Vehical_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_ResetToken]  DEFAULT ('default_value') FOR [ResetToken]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_User]
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD  CONSTRAINT [FK_Chat_User] FOREIGN KEY([SUser_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[Chat] CHECK CONSTRAINT [FK_Chat_User]
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD  CONSTRAINT [FK_Chat_User1] FOREIGN KEY([RUser_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[Chat] CHECK CONSTRAINT [FK_Chat_User1]
GO
ALTER TABLE [dbo].[Damage]  WITH CHECK ADD  CONSTRAINT [FK_Damage_Booking] FOREIGN KEY([Booking_Id])
REFERENCES [dbo].[Booking] ([Booking_Id])
GO
ALTER TABLE [dbo].[Damage] CHECK CONSTRAINT [FK_Damage_Booking]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Rental_Transaction] FOREIGN KEY([Transaction_Id])
REFERENCES [dbo].[Rental_Transaction] ([Transaction_Id])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Rental_Transaction]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Booking] FOREIGN KEY([Booking_Id])
REFERENCES [dbo].[Booking] ([Booking_Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Booking]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_User]
GO
ALTER TABLE [dbo].[Rental_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Transaction_Payment] FOREIGN KEY([Payment_Id])
REFERENCES [dbo].[Payment] ([Payment_Id])
GO
ALTER TABLE [dbo].[Rental_Transaction] CHECK CONSTRAINT [FK_Rental_Transaction_Payment]
GO
ALTER TABLE [dbo].[Vehical]  WITH CHECK ADD  CONSTRAINT [FK_Vehical_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vehical] CHECK CONSTRAINT [FK_Vehical_User]
GO
