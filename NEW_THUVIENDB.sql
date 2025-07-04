-- Bảng Độc giả (Reader)
CREATE TABLE doc_gia (
    so_dien_thoai NVARCHAR(15) PRIMARY KEY,
    ho_ten NVARCHAR(100) NOT NULL,
    email NVARCHAR(100),
    dia_chi NVARCHAR(MAX),
    ngay_dang_ky DATE DEFAULT GETDATE()
);

-- Bảng Sách (Book)
CREATE TABLE sach (
    ma_sach INT IDENTITY(1,1) PRIMARY KEY,
    ten_sach NVARCHAR(200) NOT NULL,
    tac_gia NVARCHAR(100),
    nha_xuat_ban NVARCHAR(100),
    nam_xuat_ban INT,
    the_loai NVARCHAR(50),
    don_gia_muon DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    trang_thai NVARCHAR(20) DEFAULT 'co_san'
        CONSTRAINT CHK_sach_trang_thai CHECK (trang_thai IN ('co_san', 'da_muon', 'bao_tri', 'mat'))
);

-- Bảng Phiếu mượn (Borrow Slip)
CREATE TABLE phieu_muon (
    ma_phieu_muon UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    so_dien_thoai_doc_gia NVARCHAR(15) NOT NULL,
    ngay_muon DATE NOT NULL DEFAULT GETDATE(),
    ngay_tra_du_kien DATE NOT NULL,
    ngay_tra_thuc_te DATE NULL,
    trang_thai NVARCHAR(20) DEFAULT 'dang_muon'
        CONSTRAINT CHK_phieu_muon_trang_thai CHECK (trang_thai IN ('dang_muon', 'da_tra', 'qua_han')),

    FOREIGN KEY (so_dien_thoai_doc_gia) REFERENCES doc_gia(so_dien_thoai) ON DELETE CASCADE
);

-- Bảng Chi tiết phiếu mượn (Borrow Detail)
CREATE TABLE chi_tiet_phieu_muon (
    ma_chi_tiet INT IDENTITY(1,1) PRIMARY KEY,
    ma_phieu_muon UNIQUEIDENTIFIER NOT NULL,
    ma_sach INT NOT NULL,
    don_gia_muon DECIMAL(10,2) NOT NULL,
    thanh_tien DECIMAL(10,2) NOT NULL,
    trang_thai NVARCHAR(20) DEFAULT 'dang_muon'
        CONSTRAINT CHK_chi_tiet_trang_thai CHECK (trang_thai IN ('dang_muon', 'da_tra')),
    
    FOREIGN KEY (ma_phieu_muon) REFERENCES phieu_muon(ma_phieu_muon) ON DELETE CASCADE,
    FOREIGN KEY (ma_sach) REFERENCES sach(ma_sach) ON DELETE CASCADE,
    
    CONSTRAINT UQ_phieu_sach UNIQUE (ma_phieu_muon, ma_sach)
);

-- Bảng Hóa đơn (Invoice)
CREATE TABLE hoa_don (
    ma_hoa_don INT IDENTITY(1,1) PRIMARY KEY,
    ma_phieu_muon UNIQUEIDENTIFIER NOT NULL,
    tong_tien DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    tong_thanh_toan DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    trang_thai NVARCHAR(20) DEFAULT 'chua_thanh_toan'
        CONSTRAINT CHK_hoa_don_trang_thai CHECK (trang_thai IN ('chua_thanh_toan', 'da_thanh_toan')),
    ngay_tao_hoa_don DATE DEFAULT GETDATE(),
    ngay_thanh_toan DATE NULL,
    ghi_chu NVARCHAR(MAX),
    
    FOREIGN KEY (ma_phieu_muon) REFERENCES phieu_muon(ma_phieu_muon) ON DELETE CASCADE,
    
    CONSTRAINT UQ_phieu_hoa_don UNIQUE (ma_phieu_muon)
);

-- Tạo index để tối ưu hóa truy vấn
CREATE INDEX IX_doc_gia_ho_ten ON doc_gia(ho_ten);
CREATE INDEX IX_sach_ten_sach ON sach(ten_sach);
CREATE INDEX IX_sach_trang_thai ON sach(trang_thai);
CREATE INDEX IX_phieu_muon_ngay_muon ON phieu_muon(ngay_muon);
CREATE INDEX IX_phieu_muon_trang_thai ON phieu_muon(trang_thai);
CREATE INDEX IX_hoa_don_trang_thai ON hoa_don(trang_thai);

-- Tạo trigger để tự động cập nhật trạng thái phiếu mượn khi quá hạn
GO
CREATE TRIGGER TR_check_overdue_status
ON phieu_muon
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE phieu_muon 
    SET 
        so_dien_thoai_doc_gia = i.so_dien_thoai_doc_gia,
        ngay_muon = i.ngay_muon,
        ngay_tra_du_kien = i.ngay_tra_du_kien,
        ngay_tra_thuc_te = i.ngay_tra_thuc_te,
        trang_thai = CASE 
            WHEN i.ngay_tra_thuc_te IS NULL AND GETDATE() > i.ngay_tra_du_kien THEN 'qua_han'
            WHEN i.ngay_tra_thuc_te IS NOT NULL THEN 'da_tra'
            ELSE i.trang_thai
        END
    FROM phieu_muon p
    INNER JOIN inserted i ON p.ma_phieu_muon = i.ma_phieu_muon;
END;
GO

-- Tạo trigger để tự động cập nhật trạng thái sách khi mượn/trả
CREATE TRIGGER TR_update_book_status_after_borrow
ON chi_tiet_phieu_muon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE sach 
    SET trang_thai = 'da_muon' 
    WHERE ma_sach IN (SELECT ma_sach FROM inserted);
END;
GO

CREATE TRIGGER TR_update_book_status_after_return
ON chi_tiet_phieu_muon
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE sach 
    SET trang_thai = 'co_san' 
    WHERE ma_sach IN (
        SELECT i.ma_sach 
        FROM inserted i 
        INNER JOIN deleted d ON i.ma_chi_tiet = d.ma_chi_tiet
        WHERE i.trang_thai = 'da_tra' AND d.trang_thai = 'dang_muon'
    );
END;
GO

-- Tạo một số dữ liệu mẫu để test
INSERT INTO doc_gia (so_dien_thoai, ho_ten, email, dia_chi) VALUES
(N'0123456789', N'Nguyễn Văn An', N'nguyenvana@email.com', N'123 Nguyễn Trãi, Hà Nội'),
(N'0987654321', N'Trần Thị Bình', N'tranthib@email.com', N'456 Lê Lợi, Hồ Chí Minh'),
(N'0111222333', N'Lê Văn Cường', N'levanc@email.com', N'789 Hai Bà Trưng, Đà Nẵng');

INSERT INTO sach (ten_sach, tac_gia, nha_xuat_ban, nam_xuat_ban, the_loai, don_gia_muon) VALUES
(N'Lập trình MySQL căn bản', N'Nguyễn Văn Xuân', N'NXB Thông Tin', 2023, N'Công nghệ', 15000),
(N'Toán học cao cấp', N'Trần Thị Yến', N'NXB Giáo dục', 2022, N'Giáo dục', 20000),
(N'Truyện Kiều', N'Nguyễn Du', N'NXB Văn học', 2021, N'Văn học', 10000),
(N'Đắc Nhân Tâm', N'Dale Carnegie', N'NXB Tổng hợp', 2020, N'Kỹ năng sống', 12000);

-- Hiển thị thông tin các bảng
SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, IS_NULLABLE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_SCHEMA = 'dbo'
ORDER BY TABLE_NAME, ORDINAL_POSITION;