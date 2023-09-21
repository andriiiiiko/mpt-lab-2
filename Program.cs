namespace mpt_lab_2;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int variant = 10;

        int[] taskNumbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            taskNumbers[i] = Task.CalculateNumberOfTask(numbers[i], variant);
        }
        
        
        // Number 1     102
        Task.PrintNumberOfTask(taskNumbers[0]);
        
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        int[] newArray1 = new int[array1.Length - 1];
        int index1 = 0;
        
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] % 6  != 0)
            {
                newArray1[index1] = array1[i];
                index1++;
            }
            else if (i == array1.Length)
            {
                Console.WriteLine("No items found to delete");
            }
        }
        
        PrintArray(newArray1);
        
        
        // Number 2     109
        Task.PrintNumberOfTask(taskNumbers[1]);
        
        double[] array2 = { 2.35, 8.94, 3.65, 4.21, 2.57, 6.22 };
        int k = 4;
        double maxNumber = array2.Max();
        
        
        double[] newArray2 = new double[array2.Length + 1];
        int index2 = 0;
        
        for (int i = 0; i < array2.Length; i++)
        {
            if (i + 1 == k)
            {
                newArray2[index2] = maxNumber;
                index2++;
            }
        
            newArray2[index2] = array2[i];
            index2++;
        }
        
        PrintArray(newArray2);
        
        
        // Number 3     128
        Task.PrintNumberOfTask(taskNumbers[2]);
        
        double[] array3 = { 2.35, 8.94, 3.65, 8.94, 4.21, 2.57, 6.22 };
        double maxNumber2 = array3.Max();
        
        double[] newArray3 = new double[array3.Length];
        bool conditionExecuted = false;
        
        for (int i = 0; i < array3.Length; i++)
        {
            if (array3[i] == maxNumber2 && !conditionExecuted)
            {
                newArray3[i] = 0;
                conditionExecuted = true;
                continue;
            }
        
            newArray3[i] = array3[i];
        }
        
        PrintArray(newArray3);
        
        
        // Number 4     165
        Task.PrintNumberOfTask(taskNumbers[3]);
        
        Random random = new Random();
        MeteorologicalStation station = new MeteorologicalStation();
        
        station.DayCount = 10;
        
        int[] newData = new int[station.DayCount];
        
        for (int i = 0; i < newData.Length; i++)
        {
            newData[i] = random.Next(740, 780);
        }
        
        station.AtmosphericPressureData = newData;
        
        int minValue = station.MinOfAtmosphericPressureData();
        int maxValue = station.MaxOfAtmosphericPressureData();
        int averageValue = station.AverageOfAtmosphericPressureData();
        int[] arraySort = station.SortOfAtmosphericPressureData();
        
        int d = random.Next(740, 780);
        int countDays = station.CountDaysWithPressureExceeding(d);
        int minIndex = Array.IndexOf(station.AtmosphericPressureData, minValue) + 1;
        int maxIndex = Array.IndexOf(station.AtmosphericPressureData, maxValue) + 1;
        
        Console.WriteLine("Atmospheric pressure data:");
        PrintArray(station.AtmosphericPressureData);
        Console.WriteLine($"\nThe minimum atmospheric pressure occurred on day {minIndex} at {minValue} mmHg");
        Console.WriteLine($"\nThe maximum atmospheric pressure occurred on day {maxIndex} at {maxValue} mmHg");
        Console.WriteLine($"\nThroughout the entire research period, the average atmospheric pressure was {averageValue}");
        Console.WriteLine($"\nThe number of days exceeding the value {d} is equal to {countDays}");
        Console.WriteLine("\nSorted atmospheric pressure data (ascending):");
        PrintArray(arraySort);
        
        
        // Number 5     16
        Task.PrintNumberOfTask(taskNumbers[4]);
        
        int[] array5 = { 10, 20, 30, 40, 50 };
        
        for (int i = 0; i < array5.Length; i++)
        {
            array5[i] *= 2;
        }
        
        int a = 5;
        for (int i = 0; i < array5.Length; i++)
        {
            array5[i] -= a;
        }
        
        if (array5.Length > 0 && array5[0] != 0)
        {
            for (int i = 0; i < array5.Length; i++)
            {
                array5[i] /= array5[0];
            }
        }
        
        for (int i = 0; i < array5.Length; i++)
        {
            array5[i] -= 20;
        }
        
        int b = 3;
        for (int i = 0; i < array5.Length; i++)
        {
            array5[i] += b;
        }
        
        PrintArray(array5);
    }
    
    static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item);
        }
    }
}