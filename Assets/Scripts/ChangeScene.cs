using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static void LoadTheLevel(string theLevel)
    {
        SceneManager.LoadScene(theLevel);
    }
    public static void SetThePlayers(int players)
    {
        Game.players = players;
        Game.playAgain();
    }
    public static void PlayAgain()
    {
        Game.playAgain();
    }
}
