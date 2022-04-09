--đây là database nháp được tạo ra để test api Login_Api.

CREATE DATABASE Tuyensinh;

CREATE TABLE DangNhap
(
	LoginId INT UNIQUE NOT NULL ,
	UserName NVARCHAR(36) NOT NULL ,
	Matkhau NVARCHAR(36) NOT NULL,
)

ALTER TABLE DangNhap
ADD CONSTRAINT PK_DangNhap PRIMARY KEY (LoginId);