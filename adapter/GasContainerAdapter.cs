public class GasContainerAdapter : GasContainer, IGasContainerTarget
{
    public GasContainerAdapter(double volume, double mass, double molar) 
        : base(volume, mass, molar)
    {
    }

    public void ModifVolume(double dV)
    {
        Volume += dV;
    }

    public double GetDp(int T0, int T1)
    {
        return GetPressure(T1) - GetPressure(T0);
    }

    public string Passport()
    {
        return base.ToString();
    }
}