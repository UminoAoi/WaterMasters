﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("asdasd");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("KKKKK");
    }
}
