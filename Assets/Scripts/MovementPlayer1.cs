using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class MovementPlayer1 : MovementPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Move(Input.GetAxis("Vertical"));
    }
}
