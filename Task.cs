namespace mpt_lab_2;

/// <summary>
/// Represents a class for handling number of tasks
/// </summary>
public class Task
{
    private Task()
    {
        
    }
    
    /// <summary>
    /// Calculates the task number based on the given number and variant
    /// </summary>
    /// <param name="number">The task number</param>
    /// <param name="variant">The task variant</param>
    /// <returns>The task number for execution</returns>
    public static int CalculateNumberOfTask(int number, int variant)
    {
        return (number * number * number + variant * variant) % 210 + 1;
    }

    /// <summary>
    /// Prints the task number to the console
    /// </summary>
    /// <param name="taskNumber">The task number to print</param>
    public static void PrintNumberOfTask(int taskNumber)
    {
        Console.WriteLine($"\n\n{taskNumber} number of task:\n");
    }
}