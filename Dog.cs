namespace Practice1;

internal class Dog : Pet
{
    public override string Speak()
    {
        return "Woof woof!";
    }

    private int _loyalty;

    public int Loyalty
    {
        get { return _loyalty; }
        set 
        { 
            if (value < 0)
            {
                _loyalty = 1;
            }
            else
            {
                _loyalty = value;
            }
        }
    }

    public Dog()
    {
        Random rand = new Random();
        Loyalty = rand.Next(-50, 1000);
        
    }

}

// TO DO //
// - Add custom static class
// - Make our save work
// - Make exit without saving work
// - Fix our form 2 parameters