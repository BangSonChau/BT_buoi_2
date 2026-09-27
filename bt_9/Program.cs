Console.Write("Nhập chữ cái: ");

//input
string character = Console.ReadLine();

string notification = character.ToLower() switch
{
  "a" or "e" or "i" or "u" => "Là nguyên âm",
  _ => "Là phụ âm"
};

Console.WriteLine(notification);
