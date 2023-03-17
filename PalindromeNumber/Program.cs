// See https://aka.ms/new-console-template for more information
int inputNumber = 12223;
int reversedNumber = 0;
int originalNumber = inputNumber;

while (inputNumber != 0)
{
    int digit = inputNumber % 10;
    reversedNumber = reversedNumber * 10 + digit;
    inputNumber = inputNumber / 10;

    Console.WriteLine(string.Format("Digit {0} ReversedNumber {1} InputNumber {2}", digit, reversedNumber, inputNumber));
}

Console.WriteLine(string.Format("Is the input number {0} is a palindrome {1}", originalNumber, (originalNumber == reversedNumber)));

Console.ReadKey();