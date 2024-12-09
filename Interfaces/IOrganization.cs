public interface IOrganization
{
    string Name { get; set; }
    string Address { get; set; }
    int EmployeeCount { get; set; }
    decimal Revenue { get; }
}

public interface IInsurable
{
    decimal CalculateInsurancePremium();
    void ProcessClaim(decimal amount);
}

public interface IManufacturing
{
    int ProductionCapacity { get; set; }
    void StartProduction();
    void StopProduction();
}

public interface IResourceExtraction
{
    decimal ExtractResources(decimal amount);
    decimal ResourceReserves { get; set; }
} 