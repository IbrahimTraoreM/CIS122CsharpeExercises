// written by Ibrahim
// 02/13/25
using System;

public class Arrow
{
    private string head;
    private string feathers;
    private float length;

    public string Head { get { return head; } }
    public string Feathers { get { return feathers; } }
    public float Length { get { return length; } }

    public Arrow(string head, string feathers, float length)
    {
        this.head = head;
        this.feathers = feathers;
        this.length = length;
    }

    public float GetCost()
    {
        float cost = 0;
        if (head == "Steel") cost += 10;
        else if (head == "Wood") cost += 3;
        else if (head == "Obsidian") cost += 5;

        if (feathers == "Plastic") cost += 10;
        else if (feathers == "Turkey Feathers") cost += 5;
        else if (feathers == "Goose Feathers") cost += 3;

        cost += length * 0.05f;
        return cost;
    }
}
