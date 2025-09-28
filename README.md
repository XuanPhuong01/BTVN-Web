# BTVN-Web
## TẠO SOLUTION GỒM CÁC PROJECT SAU: 
DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis). Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

## SINH VIÊN : NGUYỄN THỊ XUÂN PHƯƠNG - MSSV: K225480106054 - K58KTP
## BÀI TẬP VỀ NHÀ 01  

### Yêu cầu:  
Tạo **Solution** gồm các **Project** sau:  
  - DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
  - Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
  - Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
  - Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
### Bài làm
#### Thuật toán phương trình bậc 3  
# 1.Giới thiệu  

  <img width="649" height="310" alt="image" src="https://github.com/user-attachments/assets/7573ea47-b3f7-4708-b909-051c8e7b1e39" />
  
# 2.Công thức  

  <img width="767" height="581" alt="image" src="https://github.com/user-attachments/assets/da67bbd4-c71e-47d2-bf3f-1dbfcd7efb6a" />

## 1. Tạo 1 Solution mới  
<img width="1919" height="1033" alt="image" src="https://github.com/user-attachments/assets/c6f84ded-506f-44f4-a646-4b94e081a658" />  
<img width="1121" height="774" alt="image" src="https://github.com/user-attachments/assets/73ba4bbd-be05-4563-813d-e5f939646681" />  

## 2. Tạo các Project với yêu cầu đề bài.
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/fcb8e545-aa8e-40ec-ba94-8ffcce6ced59" />  
- project: CubicLib, để chứa thư viện thuật toán cho bài toán.
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/2b2cc3ab-8876-4c3a-b3f8-f802cce737ec" />
- Project: ConsoleApp_Cubic với mục đích Ứng dụng console (đen trơn) nhập hệ số từ người dùng, gọi DLL, in kết quả.
<img width="1917" height="1079" alt="image" src="https://github.com/user-attachments/assets/7cdd11ce-7048-40b4-92a7-fc33941dcd72" />
- Sau khi tạo project console mới ta phải add reference để link với DLL của thư viện ở trên.
<img width="796" height="546" alt="image" src="https://github.com/user-attachments/assets/0b5a0fd5-39a9-4135-a98e-79d6c9447765" />

- Kết quá sau khi nhập giá trị
<img width="1134" height="646" alt="image" src="https://github.com/user-attachments/assets/ff8d4910-02a3-49d2-8f1b-aad75111a651" />
- Project: WinForm_Cubic, để tạo Form có TextBox cho a,b,c,d; Button "Solve" gọi DLL, hiển thị kết quả trong Label hoặc TextBox.
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/be9092f2-76cb-4a62-bd06-b60dc8960251" />
- Project: WebApp_Cubic, để front-end (index.html + script.js) gửi AJAX (XMLHttpRequest) tới api.aspx (backend). api.aspx.cs gọi Personal.CubicLib.dll và trả về JSON. Host bằng IIS; dùng hosts để map custom domain.
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/d4f92615-8065-4659-b1a8-601fef64b18f" />

3. Kết quả khi chạy ra web
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/44e2d265-fa87-4859-8825-7522edd68252" />

  




