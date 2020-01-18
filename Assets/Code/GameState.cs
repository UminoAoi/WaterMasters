using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public Rain rain;
    public Button changeStateButton;
    
    void Start()
    {
        changeStateButton.onClick.AddListener(ChangeCloudState);
    }
    
    void Update()
    {    

    }

    void ChangeCloudState(WaterState newState)
    {      
        rain.state = newState;

    }

    void ChangeCloudState() {
        if (rain.state == WaterState.Liquid)
        {
            rain.state = WaterState.Frozen;
        }
         else if (rain.state == WaterState.Frozen)
        {
            rain.state = WaterState.Steam;
        }
        else
        {
            rain.state = WaterState.Liquid;
        }
    
    }
}

public enum WaterState
{
    Frozen,
    Liquid,
    Steam
}
