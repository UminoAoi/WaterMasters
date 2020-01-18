using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPoint : MonoBehaviour
{

    public Laser laser;
    public float speed = 4;

    private void Update()
    {
        Vector2 target = Vector2.zero;
        if (laser.isRight)
            target = new Vector2(transform.position.x + speed, transform.position.y);
        else
            target = new Vector2(transform.position.x - speed, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed);

    }

private void OnCollisionEnter2D(Collision2D collision)
    {
        laser.StartShink();
        Destroy(gameObject);
    }

}
