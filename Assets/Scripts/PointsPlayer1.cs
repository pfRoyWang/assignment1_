using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPlayer1 : Points
{
    // Start is called before the first frame update
    void Start()
    {
        Game.Player1 = this;
    }

    // Update is called once per frame
    void Update()
    {
        output.text = "P1:" + points;
    }
}
