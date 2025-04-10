// Written by Ibrahim Traore
// 04/09/25

public class RobotLogic
{
    public bool JudgeCircle(string moves)
    {
        int x = 0;
        int y = 0;

        for (int i = 0; i < moves.Length; i++)
        {
            if (moves[i] == 'U')
            {
                y++;
            }
            else if (moves[i] == 'D')
            {
                y--;
            }
            else if (moves[i] == 'R')
            {
                x++;
            }
            else if (moves[i] == 'L')
            {
                x--;
            }
        }

        return x == 0 && y == 0;
    }
}
