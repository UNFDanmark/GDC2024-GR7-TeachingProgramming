using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyEvil : MonoBehaviour
{
    public int speed = 10;
    public Transform rotation;
    public Transform CamR;
    public Rigidbody Tank;

    // Start is called before the first frame update
    void Start()
    {
        Tank = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        float rotation = Input.GetAxisRaw("Rotation Horizontal");

        Vector3 movement = new Vector3();
        movement.x = horizontal * speed;
        movement.z = vertical * speed;
        Tank.velocity = movement;
        transform.Rotate(0,rotation,0);
        
    }
}