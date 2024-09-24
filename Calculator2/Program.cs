Console.WriteLine(" Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Tpe the second number, and then press Enter ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;
Console.WriteLine(" Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);