using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueSpeed = 40f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
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
