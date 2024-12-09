public class Mesomorph : BodyType
{
    public Mesomorph(double height, double weight, int age, Gender gender) 
        : base(height, weight, age, gender) { }
        
    public override double CalculateBasalMetabolicRate()
    {
        return gender == Gender.Male
            ? 10 * weight + 6.25 * height - 5 * age + 5
            : 10 * weight + 6.25 * height - 5 * age - 161;
    }
} 