using System;

public class Job
{
    public string _jobTitle = "tracker, administrative clerk";
    public string _company = "Renwood Carriers, Premier group";
    public int _startYear = 2020-2023;
    public int _endYear = 2024;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}