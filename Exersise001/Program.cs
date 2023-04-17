bool IsPalindrome(int number)
{
    char[] stringArray = number.ToString().ToCharArray();
    Array.Reverse(stringArray);
    int reversedNumber = Convert.ToInt32(new string(stringArray));

    return reversedNumber == number;
}

Console.Clear();
Console.WriteLine("Program to check if number is palindrome");
Console.Write("Enter your value: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
    Console.WriteLine("\nValue is Palindrome\n");
else
    Console.WriteLine("Value not a Palindrome");