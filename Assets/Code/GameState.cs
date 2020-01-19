using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public Rain rain;
    
    void Start()
    {
    }
    
    void Update()
    {    

    }
}

public enum WaterState
{
    Frozen,
    Liquid,
    Steam,
    None
}
