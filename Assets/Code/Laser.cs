using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float timeOfLife = 1f;
    public float laserSpeed = 5;

    float currentTime = 0;
    bool startedShrink = false;

    public Sprite laserLeft;
    public Sprite laserRight;

    public bool isRight;
    SpriteRenderer sprite;
    Sprite currentLaser;
    Sprite nextLaser;

    public LaserPoint point;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (Player.GetDirection())
        {
            isRight = true;
            currentLaser = laserLeft;
            nextLaser = laserRight;
        }
        else
        {
            isRight = false;
            currentLaser = laserRight;
            nextLaser = laserLeft;
        }
        sprite.sprite = currentLaser;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > timeOfLife || startedShrink)
        {
            Shrink();
        }
        else
        {
            transform.localScale = new Vector2(transform.localScale.x + laserSpeed, transform.localScale.y);
        }

        if(transform.localScale.x < 0){
            Destroy(transform.parent.gameObject);
        }
    }

    public void StartShink()
    {
        startedShrink = true;
        transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
        if (isRight)
            transform.position = new Vector2(transform.position.x + transform.localScale.x, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - transform.localScale.x, transform.position.y);
        sprite.sprite = nextLaser;
    }

    void Shrink()
    {
        if (!startedShrink)
        {
            startedShrink = true;
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
            if(isRight)
                transform.position = new Vector2(transform.position.x + transform.localScale.x, transform.position.y);
            else
                transform.position = new Vector2(transform.position.x - transform.localScale.x, transform.position.y);
            sprite.sprite = nextLaser;
        }
        else
        {
            transform.localScale = new Vector2(transform.localScale.x - laserSpeed, transform.localScale.y);
        }
    }
}
