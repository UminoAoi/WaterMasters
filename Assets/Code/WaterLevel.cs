using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour
{
    public float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        Vector2 target = new Vector2(transform.localScale.x, transform.localScale.y + 1);
        transform.localScale = Vector2.Lerp(transform.localScale, target, speed);
    }
}
