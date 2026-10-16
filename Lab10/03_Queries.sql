USE EduManagerDB;
GO

-- ==========================================
-- I. TRUY VẤN CƠ BẢN & NÂNG CAO
-- ==========================================

-- 1. Liệt kê toàn bộ sinh viên
SELECT MaSV, HoTen, NgaySinh, GioiTinh, MaLop
FROM SINHVIEN;

-- 2. Sinh viên kèm tên lớp và tên khoa
SELECT sv.MaSV, sv.HoTen, l.TenLop, k.TenKhoa
FROM SINHVIEN sv
INNER JOIN LOP l ON sv.MaLop = l.MaLop
INNER JOIN KHOA k ON l.MaKhoa = k.MaKhoa;

-- 3. Tìm sinh viên theo họ tên chứa chữ "An"
SELECT MaSV, HoTen, MaLop
FROM SINHVIEN
WHERE HoTen LIKE N'%An%'
ORDER BY HoTen ASC;

-- 4. Liệt kê sinh viên theo lớp CNTT01
SELECT MaSV, HoTen, GioiTinh
FROM SINHVIEN
WHERE MaLop = 'CNTT01';

-- 5. Cập nhật thông tin sinh viên
UPDATE SINHVIEN
SET HoTen = N'Nguyễn Văn An Updated'
WHERE MaSV = 'SV001';

-- 6. Xóa sinh viên chưa có điểm (Xóa bạn Lê Minh Chi nếu chưa nhập điểm cho bạn ấy)
-- Lưu ý: Bạn Chi (SV003) đang có điểm. Để script chạy đúng yêu cầu, ta tạo tạm 1 sinh viên rồi xóa.
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop) 
VALUES ('SV007', N'SV Xóa Tạm', '2005-01-01', N'Nam', 'CNTT01');

DELETE FROM SINHVIEN
WHERE MaSV = 'SV007' AND NOT EXISTS (SELECT 1 FROM KETQUA WHERE MaSV = 'SV007');

-- 7. Liệt kê điểm của sinh viên theo môn
SELECT sv.MaSV, sv.HoTen, mh.TenMH, kq.Diem
FROM KETQUA kq
INNER JOIN SINHVIEN sv ON kq.MaSV = sv.MaSV
INNER JOIN MONHOC mh ON kq.MaMH = mh.MaMH
ORDER BY sv.MaSV, mh.TenMH;

-- 8. Tính điểm trung bình từng sinh viên
SELECT sv.MaSV, sv.HoTen, AVG(kq.Diem) AS DiemTrungBinh
FROM SINHVIEN sv
INNER JOIN KETQUA kq ON sv.MaSV = kq.MaSV
GROUP BY sv.MaSV, sv.HoTen;

-- 9. Thống kê số sinh viên theo lớp
SELECT l.MaLop, l.TenLop, COUNT(sv.MaSV) AS SoSinhVien
FROM LOP l
LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
GROUP BY l.MaLop, l.TenLop;

-- 10. Các lớp có từ 2 sinh viên trở lên
SELECT l.MaLop, l.TenLop, COUNT(sv.MaSV) AS SoSinhVien
FROM LOP l
LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
GROUP BY l.MaLop, l.TenLop
HAVING COUNT(sv.MaSV) >= 2;

-- ==========================================
-- II. KIỂM THỬ RÀNG BUỘC (SẼ GÂY RA LỖI)
-- Chạy từng câu dưới đây để kiểm chứng lỗi
-- ==========================================

-- 11. Test khóa ngoại: Thêm sinh viên vào lớp CNTT99 (Lớp không tồn tại)
-- Kết quả mong đợi: Lỗi FK_SINHVIEN_LOP
-- INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
-- VALUES ('SV999', N'Sinh viên lỗi', '2005-01-01', N'Nam', 'CNTT99');

-- 12. Test CHECK điểm: Nhập điểm > 10
-- Kết quả mong đợi: Lỗi CK_KETQUA_Diem
-- INSERT INTO KETQUA (MaSV, MaMH, Diem)
-- VALUES ('SV001', 'COMP1019', 12);

-- 13. Test CHECK giới tính: Nhập giới tính không phải Nam/Nữ
-- Kết quả mong đợi: Lỗi CK_SINHVIEN_GioiTinh
-- INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
-- VALUES ('SV998', N'Sinh viên giới tính lỗi', '2005-01-01', N'Khác', 'CNTT01');

-- 14. Test khóa chính: Trùng mã SV
-- Kết quả mong đợi: Lỗi Vi phạm khóa chính (Primary Key)
-- INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
-- VALUES ('SV001', N'Trùng mã', '2005-01-01', N'Nam', 'CNTT01');