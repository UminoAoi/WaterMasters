using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    HumanState state = HumanState.Ice;

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum HumanState
{
    Ice,
    Normal
}
