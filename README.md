# ĐỒ ÁN MÔN HỌC - CSC12001 - AN TOÀN VÀ BẢO MẬT DỮ LIỆU TRONG HTTT
# Hệ Thống Quản Lý Cơ Sở Dữ Liệu Oracle - ATBM 2025

## Tổng Quan

Đây là ứng dụng WinForm được phát triển cho môn học **An Toàn Bảo Mật Dữ Liệu Trong Hệ Thống Thông Tin (ATBM)** 
- Đồ án 3. Ứng dụng bao gồm hai phân hệ chính:

1. **Phân Hệ 1**: Ứng dụng quản trị CSDL Oracle dành cho người quản trị cơ sở dữ liệu
2. **Phân Hệ 2**: Ứng dụng quản lý dữ liệu nội bộ của trường Đại học X

## Công Nghệ Sử Dụng

- **Framework**: .NET Framework 4.7.2
- **Database**: Oracle Database với Oracle.ManagedDataAccess
- **UI**: Windows Forms
- **ORM**: Entity Framework 6.5.1
- **Icons**: FontAwesome.Sharp

## Cấu Trúc Dự Án

### Phân Hệ 1: Quản Trị CSDL Oracle

#### Chức Năng Chính:
1. **Quản lý User và Role**
   - Tạo mới, xóa, sửa user/role
   - Xem danh sách tài khoản người dùng và role trong hệ thống

2. **Cấp Quyền (Grant Privileges)**
   - Cấp quyền cho user, cấp quyền cho role, cấp role cho user
   - Hỗ trợ WITH GRANT OPTION
   - Cấp quyền trên các đối tượng: table, view, stored procedure, function
   - Phân quyền cấp độ cột cho SELECT, UPDATE

3. **Thu Hồi Quyền (Revoke Privileges)**
   - Thu hồi quyền từ user hoặc role

4. **Xem Thông Tin Quyền**
   - Xem quyền của mỗi user/role trên các đối tượng dữ liệu

#### Các Form Chính:
- `LoginUI.cs` - Giao diện đăng nhập
- `ADMINUI.cs` - Giao diện chính cho Admin
- `CreateEditUserRoleForm.cs` - Tạo/sửa user và role
- `UserPrivileges.cs` - Quản lý quyền user
- `RolePrivileges.cs` - Quản lý quyền role
- `ObjectPrivileges.cs` - Quản lý quyền đối tượng
- `RevokePrivileges.cs` - Thu hồi quyền
- `PrivilViewer.cs` - Xem thông tin quyền

### Phân Hệ 2: Quản Lý Dữ Liệu Nội Bộ

#### Cơ Sở Dữ Liệu:
- **NHANVIEN**: Quản lý thông tin nhân viên
- **SINHVIEN**: Quản lý thông tin sinh viên
- **DONVI**: Quản lý đơn vị (khoa/phòng)
- **HOCPHAN**: Quản lý học phần
- **MOMON**: Quản lý mở môn học
- **DANGKY**: Quản lý đăng ký học phần

#### Chính Sách Bảo Mật RBAC:

**1. Quan hệ NHANVIEN:**
- **NVCB**: Xem dữ liệu của chính mình, sửa số điện thoại
- **TRGĐV**: Xem nhân viên thuộc đơn vị (trừ lương, phụ cấp)
- **NV TCHC**: Toàn quyền trên quan hệ NHANVIEN

**2. Quan hệ MOMON:**
- **GV**: Xem phân công giảng dạy của chính mình
- **NV PĐT**: Toàn quyền trên học kỳ hiện tại
- **TRGĐV**: Xem phân công của giảng viên thuộc đơn vị
- **Sinh viên**: Xem môn học của khoa mình

#### Chính Sách Bảo Mật VPD:

**3. Quan hệ SINHVIEN:**
- **Sinh viên**: Xem/sửa thông tin của chính mình
- **NV CTSV**: Toàn quyền (trừ TINHTRANG)
- **NV PĐT**: Cập nhật TINHTRANG
- **GV**: Xem sinh viên thuộc khoa

**4. Quan hệ DANGKY:**
- **Sinh viên**: Xem/sửa đăng ký của chính mình (14 ngày đầu)
- **NV PĐT**: Quản lý đăng ký (14 ngày đầu)
- **NV PKT**: Cập nhật điểm số
- **GV**: Xem danh sách lớp và điểm

#### Các Form Chính:
- `GiaoDienSV.cs` - Giao diện sinh viên
- `GIAOVIENUI.cs` - Giao diện giảng viên
- `NhanVienUI.cs` - Giao diện nhân viên
- `SinhVienUI.cs` - Giao diện sinh viên
- `MoMon_table.cs` - Quản lý mở môn
- `DangKy_table.cs` - Quản lý đăng ký
- `Nhanvien_table.cs` - Quản lý nhân viên
- `SinhVien_table.cs` - Quản lý sinh viên

### Phân Hệ 3: Oracle Label Security (OLS)

#### Chức Năng:
- **Phát tán thông báo** dựa trên cấp bậc, lĩnh vực, vị trí địa lý
- **Hệ thống nhãn 3 thành phần**: Cấp bậc:Lĩnh vực:Cơ sở
- **Cấp bậc**: Trưởng đơn vị > Nhân viên > Sinh viên
- **Lĩnh vực**: Toán, Lý, Hóa, Hành chính
- **Cơ sở**: CS1, CS2

#### Form Chính:
- `OLSForm.cs` - Giao diện hệ thống thông báo OLS

## Cài Đặt và Chạy Ứng Dụng

### Yêu Cầu Hệ Thống:
- Windows 10/11
- .NET Framework 4.7.2 hoặc cao hơn
- Oracle Database (đã cài đặt và cấu hình)
- Visual Studio 2019/2022 (để build)

### Cấu Hình Database:
1. Cập nhật connection string trong `App.config`:
```xml
<connectionStrings>
    <add name="TestDB.Properties.Settings.ConnectionString" 
         connectionString="Data Source=XE;User ID=C##ADMIN;Unicode=True" 
         providerName="System.Data.OracleClient" />
</connectionStrings>
```

2. Đảm bảo Oracle Database đã được cài đặt và service đang chạy

### Build và Chạy:
1. Mở solution trong Visual Studio
2. Restore NuGet packages
3. Build solution (Ctrl+Shift+B)
4. Chạy ứng dụng (F5)

## Hướng Dẫn Sử Dụng

### Đăng Nhập:
1. Mở ứng dụng
2. Nhập thông tin:
   - **Username**: Tên đăng nhập Oracle
   - **Password**: Mật khẩu
   - **Role**: Chọn vai trò (ADMIN, Nhân Viên, Sinh Viên)
3. Click "Đăng Nhập"

### Vai Trò và Quyền Hạn:

#### ADMIN:
- Quản lý user/role
- Cấp/thu hồi quyền
- Xem thông tin quyền
- Quản lý hệ thống OLS

#### Nhân Viên:
- **NV PĐT**: Quản lý mở môn, đăng ký học phần
- **GV**: Xem phân công giảng dạy, danh sách lớp
- **TRGĐV**: Quản lý nhân viên đơn vị
- **NV TCHC**: Quản lý nhân viên
- **NVCB**: Xem thông tin cá nhân

#### Sinh Viên:
- Xem thông tin cá nhân
- Đăng ký học phần
- Xem điểm số
- Xem thông báo

## Tính Năng Bảo Mật

### 1. Role-Based Access Control (RBAC):
- Phân quyền dựa trên vai trò
- Kiểm soát truy cập dữ liệu theo chức năng

### 2. Virtual Private Database (VPD):
- Lọc dữ liệu tự động dựa trên người dùng
- Bảo vệ dữ liệu nhạy cảm

### 3. Oracle Label Security (OLS):
- Phân cấp bảo mật dữ liệu
- Kiểm soát truy cập dựa trên nhãn

### 4. Audit và Logging:
- Ghi nhật ký hoạt động hệ thống
- Theo dõi truy cập dữ liệu

## Cấu Trúc Thư Mục

```
TestDB/
├── bin/Debug/                 # File thực thi
├── Resources/                 # Tài nguyên (hình ảnh, icon)
├── Properties/               # Cấu hình assembly
├── *.cs                     # Source code chính
├── *.Designer.cs            # Code designer
├── *.resx                   # Resources
├── App.config               # Cấu hình ứng dụng
├── ATBM_2025_iss05.csproj   # Project file
└── packages.config          # NuGet packages
```

## Lưu Ý Quan Trọng

1. **Bảo mật**: Đảm bảo thay đổi mật khẩu mặc định của Oracle
2. **Backup**: Thường xuyên backup dữ liệu quan trọng
3. **Permissions**: Kiểm tra quyền truy cập file và thư mục
4. **Network**: Đảm bảo kết nối mạng ổn định với Oracle Database

## Phiên Bản

- **Version**: 1.0
- **Ngày tạo**: 03/2025
