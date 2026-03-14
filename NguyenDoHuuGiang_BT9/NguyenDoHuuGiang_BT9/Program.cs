Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Họ tên: Nguyễn Đỗ Hữu Giang");
Console.WriteLine("Mã sv: 2415053122312");
Console.Write("Nhập số lượng chuỗi n = ");
int n;

if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Lỗi: Số lượng không hợp lệ.");
    return;
}

string[] mangChuoi = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i}: ");
    string input = Console.ReadLine();
        mangChuoi[i] = input;
}

int dem = 0;

if (mangChuoi != null)
{
    foreach (string s in mangChuoi)
    {
        // !string.IsNullOrWhiteSpace(s) kiểm tra: khác null, khác rỗng "", khác khoảng trắng " "
        if (!string.IsNullOrWhiteSpace(s))
        {
            dem++;
        }
    }
}
Console.WriteLine($"Số lượng chuỗi khác null và khác rỗng là: {dem}");
Console.ReadLine();