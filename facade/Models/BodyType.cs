public abstract class BodyType
{
    protected double height;
    protected double weight;
    protected int age;
    protected Gender gender;
    
    public BodyType(double height, double weight, int age, Gender gender)
    {
        this.height = height;
        this.weight = weight;
        this.age = age;
        this.gender = gender;
    }
    
    public abstract double CalculateBasalMetabolicRate();
} 