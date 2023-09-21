namespace mpt_lab_2;

public class MeteorologicalStation
{
    private int[] _atmosphericPressureData;
    private int _dayCount;
    
    public int[] AtmosphericPressureData
    {
        get => _atmosphericPressureData;
        set => _atmosphericPressureData = value;
    }

    public int DayCount
    {
        get => _dayCount;
        set => _dayCount = value;
    }
    
    /// <summary>
    /// Calculates and returns the minimum atmospheric pressure recorded in the data
    /// </summary>
    /// <returns>The minimum atmospheric pressure value</returns>
    public int MinOfAtmosphericPressureData()
    {
        EnsureDataInitialized();
        return _atmosphericPressureData.Min();
    }
    
    /// <summary>
    /// Calculates and returns the maximum atmospheric pressure recorded in the data
    /// </summary>
    /// <returns>The maximum atmospheric pressure value</returns>
    public int MaxOfAtmosphericPressureData()
    {
        EnsureDataInitialized();
        return _atmosphericPressureData.Max();
    }
    
    /// <summary>
    /// Calculates and returns the average atmospheric pressure recorded in the data
    /// </summary>
    /// <returns>The average atmospheric pressure value</returns>
    public int AverageOfAtmosphericPressureData()
    {
        EnsureDataInitialized();
        
        if (_dayCount <= 0)
        {
            throw new InvalidOperationException("Invalid day count. It should be greater than 0");
        }
        
        int totalAtmosphericPressure = 0;

        foreach (int atmosphericPressure in _atmosphericPressureData)
        {
            if (_dayCount == 1)
            {
                totalAtmosphericPressure = atmosphericPressure;
                break;
            }
            
            totalAtmosphericPressure += atmosphericPressure;
        }
        
        return totalAtmosphericPressure / _dayCount;
    }

    /// <summary>
    /// Counts and returns the number of days with atmospheric pressure exceeding the given value
    /// </summary>
    /// <param name="atmosphericPressure">The threshold atmospheric pressure value</param>
    /// <returns>The count of days with pressure exceeding the threshold</returns>
    public int CountDaysWithPressureExceeding(int atmosphericPressure)
    {
        EnsureDataInitialized();
        
        if (atmosphericPressure <= 0)
        {
            throw new InvalidOperationException("Invalid atmospheric pressure count. It should be greater than 0");
        }

        int countDays = 0;

        foreach (int pressure in _atmosphericPressureData)
        {
            if (atmosphericPressure < pressure)
            {
                countDays++;
            }
        }

        return countDays;
    }

    /// <summary>
    /// Returns a sorted copy of the atmospheric pressure data
    /// </summary>
    /// <returns>An array containing the sorted atmospheric pressure data</returns>
    public int[] SortOfAtmosphericPressureData()
    {
        EnsureDataInitialized();

        int[] arrayCopy = new int[_atmosphericPressureData.Length];
        
        Array.Copy(_atmosphericPressureData, arrayCopy, _atmosphericPressureData.Length);
        Array.Sort(arrayCopy);

        return arrayCopy;
    }
    
    private void EnsureDataInitialized()
    {
        if (_atmosphericPressureData == null || _atmosphericPressureData.Length == 0)
        {
            throw new InvalidOperationException("Atmospheric pressure data is empty");
        }
    }
}