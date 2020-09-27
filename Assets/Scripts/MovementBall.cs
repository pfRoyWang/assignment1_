using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBall : MonoBehaviour
{
    public float ogspeed = 2f, speed = 2f;
    private float angle = 0;

    private bool startRound = true;
    public int startThrow = 2;

    private Vector3 vec = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Game.gameEnd)
        {
            this.RandomDirection();
            this.vec.x = this.speed * Time.deltaTime;
            this.transform.Translate(this.vec);
            this.Bounce();
            this.Clip();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if(this.angle > 0)
            this.ChangeDirection(this.angle + 180.0f);
        else if (this.angle < 0)
            this.ChangeDirection(this.angle - 180.0f);

        this.speed += 0.5f;
    }
    private void RandomDirection()
    {
        if (this.startRound)
        {
            this.startRound = false;

            float rand;
            do
            {
                rand = Random.Range(-65.0f, 65.0f);
            }
            while (rand > -25.0f && rand < 25.0f);

            this.ChangeDirection((this.startThrow == 1 ? 180 : 0) + rand);
        }
    }
    private void ChangeDirection(float change)
    {
        this.angle += change;
        this.transform.Rotate(0, 0, change);
    }
    private void Bounce()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(this.transform.position);

        float pos = position.y;

        position.y = Mathf.Clamp01(position.y);

        pos -= position.y;

        if (pos != 0)
        {
            this.transform.position = Camera.main.ViewportToWorldPoint(position);
            this.ChangeDirection(-(this.angle * 2));
        }
    }
    private void Clip()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(this.transform.position);

        float pos = position.x;

        position.x = Mathf.Clamp01(position.x);

        pos -= position.x;

        if (pos > 0)
            this.Score(1);
        else if(pos < 0)
            this.Score(2);
    }
    private void Score(int point)
    {
        Game.Score(point);
        this.speed = this.ogspeed;
        this.startThrow = point;
        this.startRound = true;
        this.vec = this.transform.position = Vector3.zero;
        this.ChangeDirection(-this.angle);
    }
}
