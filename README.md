> Thực hiện: **Huỳnh Tấn Chương**
>
> Cập nhật lần cuối: **00/00/0000**

# Bài tập Cấu trúc dữ liệu - Giải thuật bằng ngôn ngữ C#

### Mực lục

[Bài 1 - trang 8](#1-8)

[Bài 2 - trang 8](#2-8)

[Bài 3 - trang 9](#3-9)

[Bài 4 - trang 9](#4-9)

[Bài 1 - trang 24](#1-24)

[Bài 3 - trang 24](#3-24)

[Bài tập bổ sung 1](#bs1)

[Bài tập bổ sung 2](#bs2)

[Bài tập bổ sung 3](#bs3)

[Bài tập bổ sung 4](#bs4)

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





<a name="1-24"></a>
### Bài 1 - trang 24
Viết class Search gồm các phương thức tìm kiếm tuần tự trong mảng, cho biết vị trí và số lượng (nếu yêu cầu tìm tất cả phần tử thỏa điều kiện):
- Tìm kiếm tuần tự:
    + 1.1. Tìm phần từ có giá trị X đầu tiên.
    + 1.2. *Tìm phần tử có giá trị X sau cùng.
    + 1.3. *Tìm tất cả phần tử có giá trị X.
    + 1.4. *Tìm phần tử nhỏ nhất đầu tiên. 
    + 1.5. *Tìm phần tử lớn nhất sau cùng.
    + 1.6. *Tìm tất cả các số nhỏ nhất trong mảng.
    + 1.7. Tìm phần tử là số lẻ lớn nhất đầu tiên trong mảng.
    + 1.8. *Tìm phần tử là số chẵn lớn nhất sau cùng trong mảng.
- Tìm kiếm nhị phân:
    + 1.9. Tìm kiếm nhị phân phần tử có giá trị X, cài đặt dùng phương thức lặp.
    + 1.10. Tìm kiếm nhị phân phần tử X, cài đặt dùng phương thức đệ quy.


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
- e) Cho biết điểm trung bình cao nhất và thấp nhất. In ra tất cả sinh viên có điểm trung bình cao nhất và thất nhất (Dùng BinarySearch).
- f) Thực hiên lại câu d) nhưng dùng BinarySearch có sẵn của C#.
- g) Tìm tất cả sinh viên có họ phổ biến nhất trong danh sách.

<a name="bs2"></a>
### Bài tập bổ sung 2
Kết hợp bài 2 và 4 - trang 8,9. Dùng Interchange, Bubble, Selection, Quick Sort để sắp xếp Điểm trung bình của sinh viên trong danh sách sinh viên.

<a name="bs3"></a>
### Bài tập bổ sung 3
- Cho mảng A gồm n số nguyên dương { 45, 23, 78, 67, 12, 88, 34, 56, 92, 34 }
- a) Kiểm tra dãy có tăng dần hay không? Nếu không hãy sắp xếp tăng dần theo HeapSort.
- b) Chèn phần tử x vào vị trí k của dãy tăng dần.

<a name="bs4"></a>
### Bài tập bổ sung 4
- Danh sách liên kết đơn (LinkedList):
    + In mảng danh sách liên kết
    + 1. Thêm X vào trước V.
    + 2. Thêm X vào sau V.
    + 3. Thêm X vào đầu trong danh sách liên kết.
    + 4. Thêm X vào cuối trong danh sách liên kết.
    + 5. Thêm X vào giữa trong danh sách liên kết.
    + 6. Thêm giá trị X vào trước giá trị chẵn sau cùng trong danh sách liên kết.
    + 7. Thêm X vào sau giá trị chẵn sau cùng trong danh sách liên kết.
    + 8. Thêm X vào trước giá trị chẵn đầu tiên trong danh sách liên kết.
    + 9. Thêm X vào sau giá trị chẵn đầu tiên trong danh sách liên kết.
    + 10. Thêm X vào trước giá trị lẻ sau cùng trong danh sách liên kết.
    + 11. Thêm X vào sau giá trị lẻ sau cùng trong danh sách liên kết.
    + 12. Thêm X vào trước giá trị lẻ đầu tiên trong danh sách liên kết.
    + 13. Thêm X vào sau giá trị lẻ đầu tiên trong danh sách liên kết.
    + 14. Thêm X vào trước giá trị nhỏ nhất sau cùng trong danh sách liên kết.
    + 15. Thêm X vào sau giá trị nhỏ nhất sau cùng trong danh sách liên kết.
    + 16. Thêm X vào trước giá trị nhỏ nhất đầu tiên trong danh sách liên kết.
    + 17. Thêm X vào sau giá trị nhỏ nhất đầu tiên trong danh sách liên kết.
    + 18. Thêm X vào trước giá trị lớn nhất sau cùng trong danh sách liên kết.
    + 19. Thêm X vào sau giá trị lớn nhất sau cùng trong danh sách liên kết.
    + 20. Thêm X vào trước giá trị lớn nhất đầu tiên trong danh sách liên kết.
    + 21. Thêm X vào sau giá trị lớn nhất đầu tiên trong danh sách liên kết.
    + 22. Xóa X trong danh sách liên kết.
    + 23. Xóa hết tất cả các phần tử trong danh sách liên kết.
    + 24. Xóa phần tử kề sau phần tử Q trong danh sách liên kết.
    + 25. Xóa phần tử kề trước phần tử Q trong danh sách liên kết.
    + 26. Xóa phần tử đầu tiên trong danh sách liên kết.
    + 27. Xóa phần tử cuối cùng trong danh sách liên kết.
    + 28. Xóa phần tử ỡ giữa trong danh sách liên kết.
    + 29. Xóa phần tử chẵn đầu tiên trong danh sách liên kết.
    + 30. Xóa phần tử chẵn cuồi cùng trong danh sách liên kết.
    + 31. Xóa phần tử lẻ đầu tiên trong danh sách liên kết.
    + 32. Xóa phần tử lẻ cuồi cùng trong danh sách liên kết.
    + 33. Xóa phần tử nhỏ nhất trong danh sách liên kết.
    + 34. Xóa phần tử nhỏ nhất đầu tiên trong danh sách liên kết.
    + 35. Xóa phần tử nhỏ nhất sau cùng trong danh sách liên kết.
    + 36. Xóa phần tử lớn nhất trong danh sách liên kết.
    + 37. Xóa phần tử lớn nhất đầu tiên trong danh sách liên kết.
    + 38. Xóa phần tử lớn nhất sau cùng trong danh sách liên kết.