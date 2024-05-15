
public class Job
{
    //gathering information 
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = ""; 

    public Job()
    {
    }

    public void showJobInfo()
    {
        Console.WriteLine($"{_jobTitle}, {_company}, {_startYear}, {_endYear}.");
    }


}