Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập chuỗi bất kỳ: ");
string input = Console.ReadLine();

if (input == null)
{
    Console.WriteLine("Số từ: 0");
    return;
}

string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Số từ trong chuỗi: {words.Length}");