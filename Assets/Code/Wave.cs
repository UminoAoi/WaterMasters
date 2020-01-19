using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float actualSpeed = 0.1f;

    public static float speed = 0.01f;
    public float waveSpeed = 1f;

    static float waterLevel;

    public Transform pos1;
    public Transform pos2;

    Transform next;
    Transform current;

    private void Start()
    {
        current = pos1;
        next = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.localPosition.x - current.position.x) <= 0.2)
        {
            Transform tmp = current;
            current = next;
            next = tmp;
        }
        
        Vector2 target = new Vector2(current.position.x, transform.position.y + speed * 2);
        transform.position = Vector2.MoveTowards(transform.position, target, waveSpeed * Time.deltaTime);
        speed = actualSpeed;
    }

    public void AddWater(float number)
    {
        Vector2 target = new Vector2(transform.position.x, transform.position.y + 1);
        transform.position = Vector2.MoveTowards(transform.position, target, number * Time.deltaTime);
    }

    }
