// Task 1: Find the Sum of Array Elements
int[] arr = { 1, 2, 3, 4, 5 };
int sum = 0;

foreach (int num in arr)
{
    sum += num;
}

Console.WriteLine("Sum of array elements: " + sum);

// Task 2: Find the Count of Elements Greater Than 10
int[] arr2 = { 5, 12, 7, 15, 9, 22 };
int count = 0;

foreach (int num in arr2)
{
    if (num > 10)
    {
        count++;
    }
}

Console.WriteLine("Count of elements greater than 10: " + count);

// Task 3: Find the Average of Array Elements
int[] arr3 = { 1, 2, 3, 4, 5 };
int sum3 = 0;

foreach (int num in arr3)
{
    sum3 += num;
}

double average = (double)sum3 / arr3.Length;

Console.WriteLine("Average of array elements: " + average);

// Task 4: Identify and Print Spring Months
string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
string[] springMonths = { "March", "April", "May" };

foreach (string month in months)
{
    if (springMonths.Contains(month))
    {
        Console.WriteLine($"{month} is a spring month.");
    }
}