//written by Ibrahim Traore
//02//02//25

using System;

class Kingdom
{
    private int estates, duchies, provinces;

    //constructor to initialize kingdom holdings
    public Kingdom(int estates, int duchies, int provinces)
    {
        this.estates = estates;
        this.duchies = duchies;
        this.provinces = provinces;
    }

    //method to calculate total score
    public int CalculateScore()
    {
        return (estates * 1) + (duchies * 3) + (provinces * 6);
    }

    //method to display the score
    public void DisplayScore()
    {
        Console.WriteLine($"\nTotal Kingdom Score: {CalculateScore()}");
    }
}
