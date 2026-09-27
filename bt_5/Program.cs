Console.Write("Nhập 1 số nguyên: ");

int number = Convert.ToInt32(Console.ReadLine());

//hàm check
bool checkPrime(int n)
{
  if (n >= 2)
  {
    for (int i = 2; i < n; i++)
    {
      if (n % i == 0)
      {
        return false;
      }
    }
    return true;
  }
  else
  {
    return false;
  }
}

//use
bool result = checkPrime(number);

string notification = result switch
{
  true => @$"Số {number} là số nguyên tố",
  false => @$"Số {number} ko phải số nguyên tố",
};

Console.WriteLine(@$"{notification}");



