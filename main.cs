using System;

public class Employee
{
    public string Name { get; set; }
    public List<TimeRange> Availability { get; set; }
    public string Position { get; set; }

    public Employee(string name, List<TimeRange> availability, string position)
    {
        Name = name;
        Availability = availability;
        Position = position;
    }
}

public class TimeRange
{
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    public TimeRange(TimeSpan startTime, TimeSpan endTime)
    {
        StartTime = startTime;
        EndTime = endTime;
    }
}