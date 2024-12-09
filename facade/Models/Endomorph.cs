public class Endomorph : BodyType
{
    public Endomorph(double height, double weight, int age, Gender gender) 
        : base(height, weight, age, gender) { }
        
    public override double CalculateBasalMetabolicRate()
    {
        double bmr = gender == Gender.Male
            ? (10 * weight + 6.25 * height - 5 * age + 5) * 1.1
            : (10 * weight + 6.25 * height - 5 * age - 161) * 1.1;
        return bmr;
    }
} 