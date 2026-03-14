Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Họ tên: Nguyễn Đỗ Hữu Giang");
Console.WriteLine("Mã sv: 2415053122312");
Console.Write("Nhập số phần tử của mảng n = ");
int n;
string input = Console.ReadLine();
int.TryParse(input, out n);
// Kiểm tra nếu nhập không phải là số
if (n <= 0)
{
    Console.WriteLine("Lỗi: Số phần tử phải là số nguyên dương.");
    return;
}
int[] mang = new int[n];
double tong = 0;
if (mang == null)
{
    Console.WriteLine("Lỗi: Mảng chưa được khởi tạo.");
    return;
}

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i}: ");
    mang[i] = int.Parse(Console.ReadLine());

    tong += mang[i];
}

Console.WriteLine("------------------------");
Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}");
Console.ReadLine();