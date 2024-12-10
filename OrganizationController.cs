public class OrganizationController
{
    private readonly OrganizationModel _model;

    public OrganizationController(OrganizationModel model)
    {
        _model = model;
    }

    public void SetName(string name)
    {
        _model.Name = name;
    }

    public void SetAddress(string address)
    {
        _model.Address = address;
    }

    public void SetEmployeeCount(int count)
    {
        _model.EmployeeCount = count;
    }

    public decimal CalculateInsurancePremium()
    {
        return _model.CalculateInsurancePremium();
    }

    public void ProcessClaim(decimal amount)
    {
        _model.ProcessClaim(amount);
    }
}