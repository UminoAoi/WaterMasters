using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public WaterState state = WaterState.None;

    // Start is called before the first frame update
    void Start()
    {
        if (state == WaterState.None)
            state = WaterState.Liquid;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeState(WaterState newState)
    {
        Debug.Log("Old state: " + state + ", new state: " + newState);
        state = newState;
    }
}
