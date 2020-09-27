using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private int winpoints = 5;
    protected int points = 0;
    public Text output;
    public bool Score()
    {
        return ++points == winpoints ? true : false;
    }

    public void playAgain()
    {
        points = 0;
    }
}
