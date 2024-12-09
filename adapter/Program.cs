class Program
{
    static void Main(string[] args)
    {
        IGasContainerTarget adapter = new GasContainerAdapter(0.5, 0.1, 0.002016);

        Console.WriteLine("Исходные данные баллона:");
        Console.WriteLine(adapter.Passport());

        adapter.ModifVolume(0.1);
        Console.WriteLine("\nПосле изменения объема:");
        Console.WriteLine(adapter.Passport());

        int T0 = 273; // 0°C
        int T1 = 293; // 20°C
        double dp = adapter.GetDp(T0, T1);
        Console.WriteLine($"\nИзменение давления при нагреве с {T0}K до {T1}K:");
        Console.WriteLine($"ΔP = {dp:F2} Па");
    }
}