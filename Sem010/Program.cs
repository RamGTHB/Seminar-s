Console.Clear();

// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

void SummRec(int firstNumber, int secondNumber, int count, int element)
{
    if (count < element)
    {
        int sum = firstNumber + secondNumber;
        Console.Write("{0} ", sum);
        count++;
        SummRec(secondNumber, sum, count, element);
    }
}

int firstNumber = 4;
int secondNumber = 6;
int element = 7;

Console.Write($"{firstNumber} {secondNumber} ");
SummRec(firstNumber, secondNumber, 2, element);