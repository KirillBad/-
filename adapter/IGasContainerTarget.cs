public interface IGasContainerTarget
{
    void ModifVolume(double dV);
    double GetDp(int T0, int T1);
    string Passport();
} 