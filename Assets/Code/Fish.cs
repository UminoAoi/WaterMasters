using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public float speed = 1f;

    Transform current;
    Transform next;

    void Start()
    {
        current = pos1;
        next = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x - current.position.x) <= 0.2)
        {
            Transform tmp = current;
            current = next;
            next = tmp;
        }

        Vector2 target = new Vector2(current.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
