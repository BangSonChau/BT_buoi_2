Console.Write("Nhập tháng: ");

//input
int month = Convert.ToInt32(Console.ReadLine());
//output
string notification = month switch
{
  1 or 2 or 3 => "Xuân",
  4 or 5 or 6 => "Hạ",
  7 or 8 or 9 => "Thu",
  10 or 11 or 12 => "Đông",
  _ => "Không xác định"
};

Console.WriteLine(@$"{notification}");