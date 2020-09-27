using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 10.0f;
    private float halfScale = 2.5f / 2;

    private Vector3 vec = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        this.halfScale = transform.localScale.y / 2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void Move(float direction)
    {
        if (direction != 0)
        {
            this.vec.y = (direction > 0 ? 1 : -1) * this.speed * Time.deltaTime;
            transform.Translate(this.vec);
            this.Clip();
        }
    }

    private void Clip()
    {
        Vector3 offset = transform.position, center = transform.position;

        offset.y += (offset.y > 0 ? 1: -1) * this.halfScale;

        offset = Camera.main.WorldToViewportPoint(offset);
        center = Camera.main.WorldToViewportPoint(center);

        float offsety = offset.y;

        offset.y = Mathf.Clamp01(offset.y);

        if (offsety != offset.y)
        {
            center.y -= (offsety - offset.y);
            transform.position = Camera.main.ViewportToWorldPoint(center);
        }
    }
}
