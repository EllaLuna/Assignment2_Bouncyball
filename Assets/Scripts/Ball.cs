﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //[SerializeField] private RampController ramp;
    [SerializeField] private float randomNumber = 0f;
    [SerializeField] private float initialSpeedX = 0f;
    [SerializeField] private float initialSpeedY = 0f;

    private Rigidbody2D rigidBody;

    private bool gameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is a change");
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
           if (transform.position.y < -4)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameStarted)
        {
            rigidBody.velocity = new Vector2(initialSpeedX, initialSpeedY);
            Physics2D.gravity = Vector2.zero;
            gameStarted = true;
        }

        else
        {
            Vector2 randomVelocity = new Vector2(Random.Range(0f, randomNumber), Random.Range(0f, randomNumber));
            rigidBody.velocity += randomVelocity;
        }
    }


}