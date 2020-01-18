CREATE DATABASE CoffeeShop
GO
USE CoffeeShop
GO

------------ SECTION: CREATE TABLE --------------
CREATE TABLE Account
(
	AccountID int identity  primary key,
	username nvarchar(100) not null,
	displayname nvarchar(100) not null,
	password nvarchar(100) not null,
	type int not null
)
Go

CREATE TABLE AccountInfo
(
	AccountID int identity primary key,
	AccountName nvarchar(100) not null,
	AccountSex nvarchar(100) not null,
	AccountDOB date not null,
	AccountAddress nvarchar(100) not null,
	AccountPhone nvarchar(100) not null,
	AccountType int not null
)
Go

CREATE TABLE Bill
(
	BillID int identity primary key,
	BillStaffID int not null,
	BillStaffName nvarchar(100) not null,
	BillDate date not null,
	BillPrice nvarchar(100) not null
)
Go

CREATE TABLE Category
(
	CategoryID	varchar(50) primary key,
	CategoryName nvarchar(100) not null
)
Go

CREATE TABLE Item
(
	ItemID int identity primary key,
	ItemName nvarchar(100) not null,
	ItemPrice nvarchar(50) not null,
	ItemCategory nvarchar(50) not null,
	ItemImage nvarchar(50) not null
)	
Go

CREATE TABLE BillDetail
(
	BillDetailID int identity primary key,
	BillID int not null,
	ItemID int not null,
	ItemName nvarchar(100) not null,
	ItemQuantity int not null,
	BillDetailPrice nvarchar(100) not null
)


Go

------------ SECTION: INSERT DATA --------------

-- Insert for Account table
SET IDENTITY_INSERT Account ON 
INSERT Account ([AccountID], [username], [displayname], [password], [type]) VALUES (1, N'admin', 	N'Quản lý', 	N'1234', 1)
INSERT Account ([AccountID], [username], [displayname], [password], [type]) VALUES (2, N'nhanvien2', N'Nhân viên 2', N'1234', 0)
INSERT Account ([AccountID], [username], [displayname], [password], [type]) VALUES (3, N'nhanvien3', N'Nhân viên 3', N'1234', 0)
INSERT Account ([AccountID], [username], [displayname], [password], [type]) VALUES (4, N'nhanvien4', N'Nhân viên 4', N'1234', 0)
INSERT Account ([AccountID], [username], [displayname], [password], [type]) VALUES (5, N'nhanvien5', N'Nhân viên 5', N'1234', 0)
SET IDENTITY_INSERT Account OFF

-- Insert for AccountInfo table
SET IDENTITY_INSERT AccountInfo ON 
INSERT AccountInfo ([AccountID], [AccountName], [AccountSex], [AccountDOB], [AccountAddress], [AccountPhone], [AccountType]) VALUES (1, N'Luận Phạm', N'Nam', CAST(N'1996-01-01' AS Date), N'Ký túc xá A DHQG', N'0123456789', 1)
INSERT AccountInfo ([AccountID], [AccountName], [AccountSex], [AccountDOB], [AccountAddress], [AccountPhone], [AccountType]) VALUES (2, N'Hoàng Kim', N'Nam', CAST(N'1999-11-01' AS Date), N'Dĩ An - Bình Dương', N'09457894586', 0)
INSERT AccountInfo ([AccountID], [AccountName], [AccountSex], [AccountDOB], [AccountAddress], [AccountPhone], [AccountType]) VALUES (3, N'Trúc Ly', N'Nữ', CAST(N'1999-01-01' AS Date), N'Ktx khu A', N'09457894586', 0)
INSERT AccountInfo ([AccountID], [AccountName], [AccountSex], [AccountDOB], [AccountAddress], [AccountPhone], [AccountType]) VALUES (4, N'Thành Đạt', N'Nam', CAST(N'1999-01-01' AS Date), N'445 Lê Văn Thọ - Gò Vấp - Tp.HCM', N'09457894586', 0)
SET IDENTITY_INSERT AccountInfo OFF


-- Insert for Bill table



-- Insert for BillDetail table


-- Insert for Category table
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C1', N'Cà phê')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C2', N'Trà')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C3', N'Sữa chua')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C4', N'Sinh tố')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C5', N'Nước ép')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C6', N'Nước ngọt')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C7', N'Kem')
INSERT Category ([CategoryID], [CategoryName]) VALUES (N'C8', N'Khác')

-- Insert for Item table
SET IDENTITY_INSERT Item ON 
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (101, N'AMERICANO', 			N'45000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')					
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (102, N'CAPPUCCINO', 			N'35000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'ESPRESSO SỮA', 		N'35000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'ESPRESSO', 			N'35000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'VIETNAMESE COFFEE', 	N'30000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'PEACH TEA MANIA', 	N'45000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'BLUBERRY SMOOTHIE', 	N'59000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'RASPBERRY SODA', 		N'45000', 	N'C1',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (201, N'Liptop ice tea', N'25000', N'C2',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (202, N'Lemon ice tea', N'25000', N'C2',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Trà liptop sữa', N'30000', N'C2',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Trà gừng', N'25000', N'C2',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Trà chanh', N'25000', N'C2',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Trà bông cúc', N'30000', N'C2',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (301, N'Yaourt', N'15000', N'C3',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (302, N'Yaour ice', N'20000', N'C3',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Sữa chua dâu tây', N'35000', N'C3',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Sữa chua chanh dây', N'25000', N'C3',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'Sữa chua đá xay', N'3000', N'C3',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (401, N'Sinh tố dâu', N'45000', N'C4',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (402, N'Sinh tố xoài', N'30000', N'C4',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C4003', N'Sinh tố sabo', N'30000', N'C4',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C4004', N'Sinh tố chanh dây', N'30000', N'C4',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C4005', N'Sinh tố mãng cầu', N'40000', N'C4',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C4006', N'Sinh tố bơ', N'40000', N'C4',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (501, N'Nước ép dâu', N'45000', N'C5',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (502, N'Nước ép carot', N'35000', N'C5',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C5003', N'Cam vắt', N'40000', N'C5',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C5004', N'Nước ép thơm', N'30000', N'C5',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C5005', N'Nước ép dưa hấu', N'25000', N'C5',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (601, N'Nước suối', N'10000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (602, N'Cocacola', N'15000',  N'C6',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (603, N'Pepsi', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6004', N'7up', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6005', N'Mỉrinda', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6006', N'Redbull', N'25000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6007', N'Aquarius', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6008', N'Sting dâu', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6009', N'Olong tea', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6010', N'Nutri Boots', N'18000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6011', N'Twister', N'18000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6012', N'Trà đào hạt chia', N'18000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6013', N'0 độ', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C6014', N'C2', N'15000', N'C6',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (701, N'Kem dừa', N'23000', N'C7',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (702, N'Kem sầu riêng', N'23000', N'C7',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C7003', N'Kem dâu', N'23000', N'C7',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C7004', N'Kem chocolate', N'23000', N'C7',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C7005', N'Kem vani', N'23000', N'C7',	N'https://i.imgur.com/toKXt4g.png')

INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (801, N'Khăn lạnh', N'2000', N'C8',	N'https://i.imgur.com/toKXt4g.png')
INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (802, N'Thuốc 555', N'35000', N'C8',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C8003', N'Thuốc Caraven', N'35000', N'C8',	N'https://i.imgur.com/toKXt4g.png')
--INSERT Item ([ItemID], [ItemName], [ItemPrice], [ItemCategory], [ItemImage]) VALUES (N'C8004', N'Thuốc Mallboro', N'25000', N'C8',	N'https://i.imgur.com/toKXt4g.png')

SET IDENTITY_INSERT Item OFF 


--STAFF--
--------load item list
use CoffeeShop
go
create proc USP_GetItemList
As Select * From dbo.Item
go
exec dbo.USP_GetItemList

----load item by itemID
go
CREATE PROC USP_GetItemById
@itemId nvarchar(50)
AS 
BEGIN
	SELECT * FROM dbo.Item WHERE ItemID = @itemId
END
GO
-----insert bill

CREATE PROC USP_InsertBill
@idBill INT, @idStaff INT, @staffName nvarchar(100), @priceBill NVARCHAR (100)
AS
SET IDENTITY_INSERT Bill ON 
BEGIN
	INSERT dbo.Bill 
	        ( BillID ,
	          BillStaffID ,
			  BillStaffName,
	          BillDate ,
	          BillPrice			 
	        )
	VALUES  ( @idBill , 
	          @idStaff ,
			  @staffName, 
	          GETDATE() , 
			  @priceBill
	        )
END
SET IDENTITY_INSERT Bill OFF 

-----insert billDetail
go
CREATE PROC USP_InsertBillDetail
@idBillDetail INT, @idBill INT, @idItem varchar(100), @itemName nvarchar(100), @quantity INT, @totalPrice NVARCHAR  (100)
AS
SET IDENTITY_INSERT BillDetail ON 
BEGIN
	INSERT dbo.BillDetail 
	        (BillDetailID,
			BillID ,
			ItemID ,
			ItemName ,
			ItemQuantity ,
			BillDetailPrice			
	        )
	VALUES  (@idBillDetail,
			 @idBill , 
	         @idItem,
			 @itemName,
			 @quantity,
			 @totalPrice
	        )
END
SET IDENTITY_INSERT BillDetail ON 
--END--STAFF
