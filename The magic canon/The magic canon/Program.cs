// written by Ibrahim Traore
// 02/06/2025

using System;

class Program
{
    static void Main()
    {
        MagicCannon cannon = new MagicCannon();

        for (int i = 1; i <= 100; i++)
        {
            cannon.Turn = i;
            cannon.DisplayBlast();
        }
    }
}