public class Ectomorph : BodyType
{
    public Ectomorph(double height, double weight, int age, Gender gender) 
        : base(height, weight, age, gender) { }
        
    public override double CalculateBasalMetabolicRate()
    {
        double bmr = gender == Gender.Male
            ? (10 * weight + 6.25 * height - 5 * age + 5) * 0.9
            : (10 * weight + 6.25 * height - 5 * age - 161) * 0.9;
        return bmr;
    }
} 