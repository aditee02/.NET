
public readonly struct Marvel
{
    //field
    private readonly string _characterName;

    //public readonly property
    public string CharaterName
    {
        get { return _characterName; }
    }

    //public method
    public void PrintCharaterName()
    {
        System.Console.WriteLine(this.CharaterName);
        
    }

    //constructor
    public Marvel(string charactername)
    {
        _characterName = charactername; 
    }
}