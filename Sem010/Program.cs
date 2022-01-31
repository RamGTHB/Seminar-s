Console.Clear();

// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

// void SummRec(int firstNumber, int secondNumber, int count, int element)
// {
//     if (count < element)
//     {
//         int sum = firstNumber + secondNumber;
//         Console.Write("{0} ", sum);
//         count++;
//         SummRec(secondNumber, sum, count, element);
//     }
// }

// int firstNumber = 4;
// int secondNumber = 6;
// int element = 7;

// Console.Write($"{firstNumber} {secondNumber} ");
// SummRec(firstNumber, secondNumber, 2, element);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// void ShowNumbers(int number1, int number2, int howmanytimes, bool firstTime)
// {
//     if(howmanytimes>1)
//     {
//         if(firstTime)
//         {
//             Console.Write($"{number1} {number2} ");
//             firstTime=false;
//             ShowNumbers(number2,number1+number2,howmanytimes-1,firstTime);
//         }
//         else
//         {
//             Console.Write($"{number2} ");
//             ShowNumbers(number2,number1+number2,howmanytimes-1,firstTime);
//         }
//     }
// }
// Console.WriteLine("Введите число номер 1");
// int usernumber1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число номер 2");
// int usernumber2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сколько чисел показать?");
// int userEnter = Convert.ToInt32(Console.ReadLine());
// bool firstTime = true;
// ShowNumbers(usernumber1,usernumber2,userEnter,firstTime);