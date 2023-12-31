create databse OLX_DB

create table ProductDetails(ProductDetailsId int identity(300,1),
CategoryId int,
Price int,StateName varchar(20),
CityName varchar(30),UserId int)

Insert into ProductDetails values(200,450,'Bangal','Kulcutta',2)

select * from ProductDetails
ALTER  PROCEDURE InsertProduct
	@catid int,
	@pri int,
	@sname varchar(20),
	@cname varchar(20),
	@uid int
AS
BEGIN
	Insert into ProductDetails values(@catid,@pri,@sname,@cname,@uid)
END

 ALTER  PROCEDURE UpdateProduct
	@pid int,
	@catid int,
	@pri int,
	@sname varchar(20),
	@cname varchar(20),
	@uid int
AS
BEGIN
	Update ProductDetails  set CategoryId=@catid,Price=@pri,StateName=@sname,CityName=@cname,UserId=@uid where ProductDetailsId=@pid
END


ALTER  PROCEDURE DeleteProduct
	@pid int
AS
BEGIN
	Delete from ProductDetails where ProductDetailsId=@pid
END


ALTER  PROCEDURE GetProduct
AS
BEGIN
	Select * from ProductDetails order by ProductDetailsId
END





