class Program
{
    static void Main(string[] args)
    {
        var calculator = new CalorieCalculatorFacade();

        Console.WriteLine("Калькулятор ежедневной нормы калорий");
        
        double calories = calculator.CalculateDailyCalories(
            height: 175,
            weight: 70,
            age: 30,
            gender: Gender.Male,
            activityLevel: ActivityLevel.Medium,
            bodyType: "нормостеник"
        );

        Console.WriteLine($"Ваша дневная норма калорий: {calories} ккал");
    }
}
