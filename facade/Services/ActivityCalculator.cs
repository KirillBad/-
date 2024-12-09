public class ActivityCalculator
{
    public double GetActivityMultiplier(ActivityLevel level)
    {
        return level switch
        {
            ActivityLevel.Low => 1.2,
            ActivityLevel.Medium => 1.55,
            ActivityLevel.High => 1.9,
            _ => throw new ArgumentException("Неверный уровень активности")
        };
    }
} 