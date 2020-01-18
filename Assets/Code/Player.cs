﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 200;
    public float jumpSpeed = 200;

    Rigidbody2D rb;
    bool onGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        onGround = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && onGround)
        {
            onGround = false;
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
        }
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(move, rb.velocity.y);
    }

    void Shoot()
    {

    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;

        if (collision.gameObject.layer == 8)
            Die();
    }
}
