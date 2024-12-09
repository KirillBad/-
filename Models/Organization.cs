public abstract class Organization : IOrganization
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int EmployeeCount { get; set; }
    public abstract decimal Revenue { get; }

    protected Organization(string name, string address, int employeeCount)
    {
        Name = name;
        Address = address;
        EmployeeCount = employeeCount;
    }
} 