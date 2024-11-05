USE QuanLySinhVien;
GO

CREATE PROCEDURE proc_logic
    @user NVARCHAR(50),
    @pass NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem các tham số @user và @pass có giá trị hợp lệ không
    IF @user IS NULL OR @pass IS NULL OR @pass = ''
    BEGIN
        RAISERROR('Thiếu tham số tài khoản hoặc mật khẩu.', 16, 1)
        RETURN
    END

    -- Lệnh SELECT kiểm tra thông tin đăng nhập
    SELECT * 
    FROM tbl_taikhoan 
    WHERE sTaiKhoan = @user AND sMatKhau = @pass
END

   

USE QuanLySinhVien;
GO
EXEC sp_helptext 'proc_logic';

DROP PROCEDURE IF EXISTS proc_logic;
GO

SELECT * FROM tbl_taikhoan WHERE sTaiKhoan = @user AND (sMatKhau = @pass OR sMatKhau IS NULL)

ALTER TABLE tbl_taikhoan
ALTER COLUMN sMatKhau NVARCHAR(50) NOT NULL;
