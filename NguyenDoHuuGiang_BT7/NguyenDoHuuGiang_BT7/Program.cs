Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Họ tên: Nguyễn Đỗ Hữu Giang");
Console.WriteLine("Mã sv: 2415053122312");
Console.Write("Nhập họ và tên: ");
string hoTen = Console.ReadLine();

if (string.IsNullOrEmpty(hoTen))
{
    Console.WriteLine("Thông báo: Chuỗi null hoặc rỗng, không thực hiện tách.");
    return;
}

string[] mangKetQua = hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

if (mangKetQua == null || mangKetQua.Length == 0)
{
    return;
}


Console.WriteLine("--- Kết quả sau khi tách ---");
for (int i = 0; i < mangKetQua.Length; i++)
{
    Console.WriteLine(mangKetQua[i]);
}
Console.ReadLine();