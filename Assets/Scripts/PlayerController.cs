using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueSpeed = 40f;
    [SerializeField] float boostSpeed = 60f;
    [SerializeField] float baseSpeed = 40f;

    bool canMove = true;
    SurfaceEffector2D[] surfaceEffector2D;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectsOfType<SurfaceEffector2D>();

    }
    void Update()
    {
        if (canMove){
            RotatePlayer();
            RespondToboost();
        }
        
    }
    public void DisableControls(){
        canMove = false;

    }

    void RespondToboost()
    {
        foreach (var effector in surfaceEffector2D)
    {
        if (Input.GetKey(KeyCode.W))
        {
            effector.speed = boostSpeed;
        }
        else
        {
            effector.speed = baseSpeed;
        }
    }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueSpeed);
        }
    }
}
