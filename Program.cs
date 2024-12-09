class Program
{
    static void Main(string[] args)
    {
        var organizations = new List<IOrganization>
        {
            new InsuranceCompany("СтрахКомпания", "ул. Страховая 1", 100),
            new OilGasCompany("НефтеГаз", "ул. Нефтяников 5", 500, 1000000),
            new Factory("ЗаводПром", "ул. Заводская 10", 300, 1000)
        };

        foreach (var org in organizations)
        {
            Console.WriteLine($"Организация: {org.Name}");
            Console.WriteLine($"Адрес: {org.Address}");
            Console.WriteLine($"Количество сотрудников: {org.EmployeeCount}");

            if (org is IInsurable insurableOrg)
            {
                var premium = insurableOrg.CalculateInsurancePremium();
                Console.WriteLine($"Рассчитанная страховая премия: {premium}");
                insurableOrg.ProcessClaim(premium * 0.1m);
            }
            else if (org is IResourceExtraction extractionOrg)
            {
                var extracted = extractionOrg.ExtractResources(100);
                Console.WriteLine($"Добыто ресурсов: {extracted}");
            }
            else if (org is IManufacturing manufacturingOrg)
            {
                manufacturingOrg.StartProduction();
                Console.WriteLine($"Производственная мощность: {manufacturingOrg.ProductionCapacity}");
            }

            Console.WriteLine($"Выручка: {org.Revenue}");
            Console.WriteLine();
        }
    }
}