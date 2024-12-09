public class GasContainer
{
    public double Volume { get; set; }
    public double Mass { get; set; }
    public double Molar { get; set; }
    private const double R = 8.31;

    public GasContainer(double volume, double mass, double molar)
    {
        Volume = volume;
        Mass = mass;
        Molar = molar;
    }

    public double GetPressure(int T)
    {
        return (Mass * R * T) / (Molar * Volume);
    }

    public double AmountOfMatter()
    {
        return Mass / Molar;
    }

    public override string ToString()
    {
        return $"Объем: {Volume} м3, Масса: {Mass} кг, Молярная масса: {Molar} кг/моль";
    }
} 