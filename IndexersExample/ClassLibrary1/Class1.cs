
public class Car
{
    //public field
    private string[] _brands = new string[] { "bmw", "skoda", "honda" };

    //public indexer
    public string this[int index]
    {
        set
        {
            this._brands[index] = value;
        }

        get
        {
            return _brands[index];
        }
    }
}