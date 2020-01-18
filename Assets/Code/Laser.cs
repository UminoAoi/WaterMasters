using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float timeOfLife = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(transform.localScale.x + Time.deltaTime*10, transform.localScale.y);    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }


}
