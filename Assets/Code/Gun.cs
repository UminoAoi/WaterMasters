using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    public GameObject iceLaser;
    public GameObject waterLaser;
    public GameObject steamLaser;

    static WaterState gunMode = WaterState.Frozen;
    public TextMeshProUGUI gunStateText;

    void Start()
    {
        gunStateText.text = "Ice";
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            gunStateText.text = "Ice";
            gunMode = WaterState.Frozen;
        }
        if (Input.GetKeyDown("2"))
        {
            gunStateText.text = "Liquid";
            gunMode = WaterState.Liquid;
        }
        if (Input.GetKeyDown("3"))
        {
            gunStateText.text = "Steam";
            gunMode = WaterState.Steam;
        }
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

    public static WaterState GetWaterState() {
        return gunMode;
    }
}
