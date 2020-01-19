using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piranha : Fish
{
    public ParticleSystem burst;
    public float waterSpeed = 0.01f;

    Transform current;
    Transform next;

    void Start()
    {
        current = pos1;
        next = pos2;
    }

    private void Update()
    {
        if (Mathf.Abs(transform.position.x - current.position.x) <= 0.2)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            Transform tmp = current;
            current = next;
            next = tmp;
        }

        Vector2 target = new Vector2(current.position.x, transform.position.y + waterSpeed);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;

        if (obj.layer == 10 || obj.layer == 11)
        {
            StartCoroutine(Burst(obj));
        }
    }

    IEnumerator Burst(GameObject obj)
    {
        Destroy(obj);
        burst.Play();
        yield return new WaitForSeconds(1);
        burst.Stop();        
    }
}
