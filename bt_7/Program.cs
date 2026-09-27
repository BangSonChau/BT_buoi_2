Console.WriteLine("1.Standard");
Console.WriteLine("2.Premium");
Console.WriteLine("3.Vip");
Console.Write("Chọn hạng vé: ");

//input
int choice = Convert.ToInt16(Console.ReadLine());

//output
string description = choice switch
{
  1 => "Ghế ngồi thường, ko có đồ uống",
  2 => "Ghế ngôi thoải mái, có đồ uống miễn phí",
  3 => "Chế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí",
  _ => "Không xác định"
};

Console.WriteLine(@$"
Tiện ích kèm theo
{description}
");


