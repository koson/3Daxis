
Axis X = new Axis();
Console.WriteLine("Enter X distance = 100 mm.");
X.distance = 100; // in mm.
Console.WriteLine("Read X distance = " + X.distance+ " inch"); // in inch

Axis Y = new Axis();
Console.WriteLine("Enter X distance = 500 mm.");
Y.distance = 500; // in mm.
Console.WriteLine("Read X distance = " + X.distance + " inch"); // in inch


class Axis
{
    private double  _distance = 0.0d;
    public double distance {
        get 
        { 
            return _distance/2.54; 
        }
        set 
        {
            if (value > 0 && value < 300.0)
                _distance = value;
            else throw new Exception("Value out of range!");   
        } 
    }
}
