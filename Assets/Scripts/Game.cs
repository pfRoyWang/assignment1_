using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game
{
    public static bool gameEnd = false;
    public static int players = 1;
    public static Points Player1, Player2;

    public static void Score(int point)
    {
        gameEnd = point == 1 ? Player1.Score() : Player2.Score();
    }

    public static void playAgain()
    {
        gameEnd = false;
        Player1.playAgain();
        Player2.playAgain();
    }
}
