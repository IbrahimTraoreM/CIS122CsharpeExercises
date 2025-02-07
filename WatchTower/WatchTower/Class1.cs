// written by Ibrahim Traore
// 02/06/2025

using System;

class Watchtower
{
    private int x, y;

    // Getters and Setters
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    // Method to determine enemy direction
    public string GetDirection()
    {
        if (x == 0 && y == 0) return "The enemy is here!";
        if (y > 0)
        {
            if (x > 0) return "The enemy is to the Northeast!";
            if (x < 0) return "The enemy is to the Northwest!";
            return "The enemy is to the North!";
        }
        if (y < 0)
        {
            if (x > 0) return "The enemy is to the Southeast!";
            if (x < 0) return "The enemy is to the Southwest!";
            return "The enemy is to the South!";
        }
        if (x > 0) return "The enemy is to the East!";
        return "The enemy is to the West!";
    }
}

