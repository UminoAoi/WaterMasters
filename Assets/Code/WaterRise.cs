using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{
    public float actualSpeed = 0.01f;
    public static float speed = 0.01f;
    public Wave wave;

    // Update is called once per frame
    void Update()
    {
        Vector2 target = new Vector2(transform.localScale.x, transform.localScale.y + 1);
        transform.localScale = Vector2.MoveTowards(transform.localScale, target, speed * Time.deltaTime);
        speed = actualSpeed;
    }

    void AddWater(float number)
    {
        speed = number;
        //wave.AddWater(number);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
        //AddWater(20);
    }
}
