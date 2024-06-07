
public class Person
{
    public string PersonName { get; set; }

    public string Email { get; set; }

    public AgeGroupEnumeration AgeGroup { get; set; }

}

public enum AgeGroupEnumeration
{
    child,//0
    Teenager,//1
    Adult = 100,//100
    Senior//101
}