namespace Practice1;

public static class PetFactory
{
    public static Pet GetRandomAnimal()
    {
        Random rand = new Random();
        int choice = rand.Next(0, 3);

        switch (choice)
        {
            case 0:
                Dog myDog = new Dog();
                myDog.Name = "Spot";
                myDog.Age = 1700;
                myDog.Type = "Fluffy Dog";
                return myDog;
            case 1:
                cat myCat = new cat();
                myCat.Name = "Garfield";
                myCat.Age = 300;
                myCat.Type = "Orange Menace";
                return myCat;
            case 2:
                Bird myBird = new Bird();
                myBird.Name = "Ringo";
                myBird.Age = 300;
                myBird.Type = "Angry Bird";
                return myBird;
            default:
                return new cat();
        }

    }
}
