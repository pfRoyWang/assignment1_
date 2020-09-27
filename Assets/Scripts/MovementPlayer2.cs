using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : MovementPlayer
{
    public GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.players == 2)
            this.Move(Input.GetAxis("Alt Vertical"));
        else
            this.Move(Mathf.Round(this.Sphere.transform.position.y - transform.position.y));
    }
}
