double GetDistance(int[] pointA, int[] pointB)
{
    return Math.Round(Math.Sqrt(Math.Pow((pointB[0] - pointA[0]), 2) +
        Math.Pow((pointB[1] - pointA[1]), 2) +
        Math.Pow((pointB[2] - pointA[2]), 2)), 2);
}

int[] GetPoint()
{
    int arrayLength = 3;
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Enter coordinate {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

Console.Clear();
Console.WriteLine("Program to calculate distance betwen two 3D points");
Console.WriteLine($"Enter first point");
int[] pointA = GetPoint();
Console.WriteLine($"Enter second point");
int[] pointB = GetPoint();
Console.WriteLine($"Distance between 2 points is: {GetDistance(pointA, pointB)}");