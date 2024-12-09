using System;

public class InsuranceCompany : Organization, IInsurable
{
    private decimal _totalPremiums;
    private decimal _totalClaims;

    public override decimal Revenue => _totalPremiums - _totalClaims;

    public InsuranceCompany(string name, string address, int employeeCount)
        : base(name, address, employeeCount)
    {
        _totalPremiums = 0;
        _totalClaims = 0;
    }

    public decimal CalculateInsurancePremium()
    {
        var premium = 1000m;
        _totalPremiums += premium;
        return premium;
    }

    public void ProcessClaim(decimal amount)
    {
        _totalClaims += amount;
    }
}

public class OilGasCompany : Organization, IResourceExtraction
{
    public decimal ResourceReserves { get; set; }
    private decimal _extractionPrice = 60m;

    public override decimal Revenue => _totalExtracted * _extractionPrice;
    private decimal _totalExtracted;

    public OilGasCompany(string name, string address, int employeeCount, decimal initialReserves)
        : base(name, address, employeeCount)
    {
        ResourceReserves = initialReserves;
    }

    public decimal ExtractResources(decimal amount)
    {
        if (amount <= ResourceReserves)
        {
            ResourceReserves -= amount;
            _totalExtracted += amount;
            return amount;
        }
        return 0;
    }
}

public class Factory : Organization, IManufacturing
{
    public int ProductionCapacity { get; set; }
    private bool _isProducing;
    private decimal _revenuePerUnit = 100m;

    public override decimal Revenue => ProductionCapacity * _revenuePerUnit * (_isProducing ? 1 : 0);

    public Factory(string name, string address, int employeeCount, int productionCapacity)
        : base(name, address, employeeCount)
    {
        ProductionCapacity = productionCapacity;
        _isProducing = false;
    }

    public void StartProduction()
    {
        _isProducing = true;
    }

    public void StopProduction()
    {
        _isProducing = false;
    }
} 