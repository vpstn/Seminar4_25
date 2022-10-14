// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exp(int chisloA, int chisloB){

    int result = 1;
  for(int i=1; i <= chisloB; i++){
    result = result * chisloA;
}

return result;
}
Console.WriteLine("Введите число A: ");
  int chisloA = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int chisloB = Convert.ToInt32(Console.ReadLine());

  int res = Exp(chisloA, chisloB);
  Console.WriteLine("Ответ: " + res);