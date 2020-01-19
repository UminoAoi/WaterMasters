using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public Transform player;
    public float speed = 1;

    public Animator animator;
    bool isRight = true;


    private void Update()
    {
        Vector2 target = new Vector2(player.position.x, transform.position.y);
        if(target.x < transform.position.x && isRight)
        {
            isRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }else if(target.x > transform.position.x && !isRight)
        {
            isRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;

        if (obj.layer == 17)
        {
            Bite();
            Destroy(obj);
        }else if (obj.layer == 19 && obj.transform.position.y > transform.position.y)
        {
            Destroy(gameObject);
        }
    }

    void Bite()
    {
        /////
    }
}
