public class OrganizationModel : Observable
{
    private string _name;
    private string _address;
    private int _employeeCount;
    private decimal _revenue;
    private int _premiumCount;

    public string Name 
    { 
        get => _name;
        set 
        { 
            _name = value;
            NotifyUpdate();
        }
    }

    public string Address 
    { 
        get => _address;
        set 
        { 
            _address = value;
            NotifyUpdate();
        }
    }

    public int EmployeeCount 
    { 
        get => _employeeCount;
        set 
        { 
            _employeeCount = value;
            NotifyUpdate();
        }
    }

    public decimal Revenue
    {
        get => _revenue;
        private set
        {
            _revenue = value;
            NotifyUpdate();
        }
    }

    public int PremiumCount
    {
        get => _premiumCount;
        set
        {
            _premiumCount = value;
            NotifyUpdate();
        }
    }

    public OrganizationModel(string name, string address, int employeeCount)
    {
        _name = name;
        _address = address;
        _employeeCount = employeeCount;
        _revenue = 0;
        _premiumCount = 0;
    }

    public decimal CalculateInsurancePremium()
    {
        var premium = EmployeeCount * 1000m;
        Revenue += premium;
        PremiumCount++;
        return premium;
    }

    public void ProcessClaim(decimal amount)
    {
        Revenue -= amount;
    }
} 