// written by Ibrahim Traore
// 02/06/2025

using System;

class DiscountCalculator
{
    private string userName;
    private double price;
    private string myName = "Ibrahim"; // Change to your actual name

    // Getters and Setters
    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Method to calculate discounted price
    public double GetFinalPrice()
    {
        if (userName.Equals(myName, StringComparison.OrdinalIgnoreCase))
            return price / 2;
        return price;
    }
}
