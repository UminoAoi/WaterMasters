﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public WaterState state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeState(WaterState newState)
    {
        Debug.Log("Old state: " + state + ", new state: " + newState);
        state = newState;
    }
}
