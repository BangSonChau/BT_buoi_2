Console.Write("Nhập tuổi công dân: ");
//input
int age = Convert.ToInt32(Console.ReadLine());
//output
string notification = age switch
{
  > 27 => "Quá tuổi tham gia NVQS",
  >= 18 => "Đủ tuổi tham gia NVQS",
  _ => "Chưa đủ tuổi tham gia NVQS"
};

Console.WriteLine(@$"{notification}");