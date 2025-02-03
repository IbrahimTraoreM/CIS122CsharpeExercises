//written by Ibrahim Traore
//02/02/25

using System;

class TheDefense
{
    private int row, column;

    //constructor to initialize target position
    public TheDefense(int row, int column)
    {
        this.row = row;
        this.column = column;
    }

    //method to compute and display deployment locations
    public void Deploy()
    {
        Console.WriteLine("\nDeployment Locations:");
        Console.WriteLine($"Above:   ({row - 1}, {column})");
        Console.WriteLine($"Below:   ({row + 1}, {column})");
        Console.WriteLine($"Left:    ({row}, {column - 1})");
        Console.WriteLine($"Right:   ({row}, {column + 1})");

        Console.Beep(); //beep to indicate deployment
    }
}
