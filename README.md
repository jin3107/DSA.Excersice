> Thực hiện: **Huỳnh Tấn Chương**
>
> Cập nhật lần cuối: **00/00/0000**

# Bài tập Cấu trúc dữ liệu - Giải thuật bằng ngôn ngữ C#

### Mực lục

[Bài 1 - trang 8](#1-8)

[Bài 2 - trang 8](#2-8)

[Bài 3 - trang 9](#3-9)

[Bài 4 - trang 9](#4-9)

[Bài 3 - trang 24](#3-24)

[Bài tập bổ sung 1](#bs1)

[Bài tập bổ sung 2](#bs2)

<a name="1-8"></a>
### Bài 1 - trang 8
Viết chương trình "Displaynums", nhập n phân tử vào dãy số (n = 10.000; 100.000). Mỗi phần tử là số nguyên phát sinh ngẫu nhiên. Đo thời gian chạy của việc hiển thị dãy số, dùng Stopwatch của thư viện .NET

<a name="2-8"></a>
### Bài 2 - trang 8
Cho 1 danh danh sách các sinh viên thi đạ học. Thông tin được lưu của mỗi sinh viên gồm có mã sinh viên và điểm 3 môn thi: M1, M2, M3. Điểm mỗi môn là số nguyên từ 0 đến 100. Điểm trung bình của mỗi sinh viên là trung bình cộng của 3 sinh viên. Điểm trung bình môn thi là trung bình cộng các điểm môn đó. Điểm trung bình của danh sách có thể tính theo 2 cách:
- Cách 1: Tính trung bình cộng của tất cả điểm trung bình của sinh viên.
- Cách 2: Tính trung bình cộng của tất cả điểm trung bình môn học.
Với danh sách có n sinh viên thì mỗi cách tính thực hiện bao nhiêu phép tính?
* Hãy viết chương trình:
    - Nhập điểm bằng 4 cách sau: 
        + Nhập từ bàn phím.
        + Nhập bằng khởi tạo giá trị trong mã nguồn (dùng khi số lượng sinh viên nhỏ, ≤ 100 sinh viên).
        + Nhập vào số đọc từ file .txt
        + Nhập số từ phát sinh ngẫu nhiên (khi số lượng sinh viên lớn, ≥ 100.000 sinh viên).Bai3
    - Đo thời gian chạy của chức năng tính điểm trung bình của danh sách (không kể thời gian nhập điểm) đối với mỗi cách tính trên. Chạy nhiều lần và lưu thời gian chạy xuống file .txt (hoặc hiển thị thời gian chạy trên cửa số Console). So sánh thời gian chạy của 2 cách tính đối với từng trường hợp: số lượng sinh viên nhỏ, số lượng sinh viên lớn.

<a name="3-9"></a>
### Bài 3 - trang 9 
Viết chương trình hoán vị 2 đối tượng dùng kiểu Generic T:
- Viết phương thức hoán vị 2 đối tượng kiểu Generic T.
- Dùng phương thức trên hoán vị từng cặp đối tượng có kiểu dữ liệu sau: int, double, string.
- Xây dựng struc NhanVien gồm HoTen, MaNhanVien, HeSoLuong. Dùng phương thức trên hoán vị cặp đối tượng NhanVien.
- Xây dựng class SinhVien gồm HoTen, MaSinhVien, DiemTrungBinh. Dùng phương thức trên hoán vị cặp đối tượng SinhVien.

<a name="4-9"></a>
### Bài 4 - trang 9 
Giải bài 2 - trang 8 nhưng dùng cấu trúc dữ liệu Generic List để lưu danh sách sinh viên. So sánh thời gian chạy khi dùng Array đối với mỗi trường hợp: số lượng sinh viên nhỏ, số lượng sinh viên lớn.

<a name="3-24"></a>
### Bài 3 - trang 24 
Viết class ProcessSort gồm các phương thức sắp xếp sau:
- Sắp xếp nổi bọt với cách duyệt đưa phần tử lớn nhất về cuối mảng.
- Sắp xếp nổi bọt với cách duyệt đưa phần tử lớn nhất về đầu mảng.
- Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về cuối mảng.
- Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về đầu mảng.
- Sắp xếp chèn với cách duyệt xem phần tử cuối mảng là dãy đã sắp xếp ban đầu.
- Sắp xếp chèn với cách duyệt xem phần tử đầu mảng là dãy đã sắp xếp ban đầu.
- Sắp xếp nhanh, trong đó phân hoạch dùng phương pháp đệ quy.
- Sắp xếp nhanh, trong đó phân hoạch dùng phương pháp lặp.







<a name="bs1"></a>
### Bài tập bổ sung 1
Cho danh sách n sinh viên gồm: Mã sinh viên, Họ tên, Điểm trung bình, Ngành học. Yêu cầu viết các phương thức sau:
- a) Nhập danh sách sinh viên từ bàn phím và in ra màn hình
- b) Sắp xếp danh sách sinh viên tăng dần theo một trong các tiêu chí sau:
    + Theo Mã sinh viên (Dùng thuật toán Bubble Sort).
    + Theo Họ tên (Dùng thuật toán Selection Sort).
    + Theo điềm trung bình (Dùng thuật toán Quick Sort).
- c) Đo thời gian chạy của các thuật toán ở câu b).
- d) Đếm số lượng sinh viên theo tường ngành học.

<a name="bs2"></a>
### Bài tập bổ sung 2
Kết hợp bài 2 và 4 - trang 8,9. Dùng Interchange, Bubble, Selection, Quick Sort để sắp xếp Điểm trung bình của sinh viên trong danh sách sinh viên.