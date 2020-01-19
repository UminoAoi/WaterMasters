using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    public GameObject iceLaser;
    public GameObject waterLaser;
    public GameObject steamLaser;

    static WaterState gunMode = WaterState.None;
    public TextMeshProUGUI gunStateText;

    void Start()
    {
        gunStateText.text = "Aby zmienić rodzaj broni wybierz - 1, 2 lub 3 ";
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            gunStateText.text = "(1)Ice";
            gunMode = WaterState.Frozen;
        }
        if (Input.GetKeyDown("2"))
        {
            gunStateText.text = "(2)Liquid";
            gunMode = WaterState.Liquid;
        }
        if (Input.GetKeyDown("3"))
        {
            gunStateText.text = "(3)Steam";
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

        Vector2 target = gameObject.transform.position;
        laser.transform.position = new Vector2(target.x + 0.5f, target.y + 0.6f );
        Instantiate(laser);
    }

    public static WaterState GetWaterState() {
        return gunMode;
    }
}
