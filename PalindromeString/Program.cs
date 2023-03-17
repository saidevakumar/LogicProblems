// See https://aka.ms/new-console-template for more information
string inputText = "Level";

inputText = inputText.ToLower();

bool isPalindrome = true;
for (int index=0; index<inputText.Length/2; index++)
{
    if (inputText[index] != inputText[inputText.Length - index - 1])
    { 
        isPalindrome = false; 
        break; 
    }
}
Console.WriteLine(string.Format("Is the input string {0} is a palindrome {1}", inputText,isPalindrome));

Console.ReadKey();