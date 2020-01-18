using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject iceLaser;
    public GameObject waterLaser;
    public GameObject steamLaser;

    WaterState gunMode = WaterState.Frozen;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
            gunMode = WaterState.Frozen;
        if (Input.GetKeyDown("2"))
            gunMode = WaterState.Liquid;
        if (Input.GetKeyDown("3"))
            gunMode = WaterState.Steam;
    }

    public void Shoot()
    {
        GameObject laser = null;
        switch (gunMode)
        {
            case WaterState.Frozen:
                laser = iceLaser;
                break;
            case WaterState.Liquid:
                laser = waterLaser;
                break;
            case WaterState.Steam:
                laser = steamLaser;
                break;
        }

        laser.transform.position = gameObject.transform.position;
        Instantiate(laser);
    }
}
