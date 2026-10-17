use BookStore
go
INSERT INTO Account (AccountId, Username, Password, FullName, Picture, Email, Address, Phone, IsAdmin, Active)
VALUES 
('ACC01', 'admin', 'admin123', N'Quản trị viên hệ thống', NULL, 'admin@bookstore.com', N'Hà Nội', '0988000111', 1, 1),
('ACC02', 'qpham', '12345', N'Phạm Thị Thúy Quỳnh', NULL, 'qthuy6633@gmail.com', N'Hà Nội', '0392270579', 0, 1),
('ACC03', 'nguyenvana', 'pass123', N'Nguyễn Văn A', NULL, 'nguyenvana@gmail.com', N'Hồ Chí Minh', '0901222333', 0, 1),
('ACC04', 'tranthib', 'pass456', N'Trần Thị B', NULL, 'tranthib@yahoo.com', N'Đà Nẵng', '0912333444', 0, 1),
('ACC05', 'lethic', 'pass789', N'Lê Thị C', NULL, 'lethic@outlook.com', N'Hải Phòng', '0923444555', 0, 0),
('ACC06', 'hoangvand', 'hoang111', N'Hoàng Văn D', NULL, 'hoangvand@gmail.com', N'Cần Thơ', '0934555666', 0, 1),
('ACC07', 'phamvane', 'pham222', N'Phạm Văn E', NULL, 'phamvane@gmail.com', N'Nghệ An', '0945666777', 0, 1),
('ACC08', 'daothif', 'dao333', N'Đào Thị F', NULL, 'daothif@hotmail.com', N'Thanh Hóa', '0956777888', 0, 1),
('ACC09', 'vuminhtri', 'vu444', N'Vũ Minh Trí', NULL, 'vuminhtri@gmail.com', N'Quảng Ninh', '0967888999', 0, 0),
('ACC10', 'dinhtuan', 'dinh555', N'Đinh Tuấn Anh', NULL, 'dinhtuananh@gmail.com', N'Bắc Ninh', '0978999000', 0, 1);