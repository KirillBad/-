public class CalorieCalculatorFacade
{
    private readonly ActivityCalculator activityCalculator;

    public CalorieCalculatorFacade()
    {
        activityCalculator = new ActivityCalculator();
    }

    public double CalculateDailyCalories(
        double height, 
        double weight, 
        int age, 
        Gender gender, 
        ActivityLevel activityLevel, 
        string bodyType)
    {
        BodyType type = bodyType.ToLower() switch
        {
            "астеник" => new Ectomorph(height, weight, age, gender),
            "нормостеник" => new Mesomorph(height, weight, age, gender),
            "гиперстеник" => new Endomorph(height, weight, age, gender),
            _ => throw new ArgumentException("Неверный тип телосложения")
        };

        double bmr = type.CalculateBasalMetabolicRate();
        double activityMultiplier = activityCalculator.GetActivityMultiplier(activityLevel);
        
        return Math.Round(bmr * activityMultiplier, 2);
    }
} 