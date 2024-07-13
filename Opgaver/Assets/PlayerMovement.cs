using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public int speed = 10;
    public Rigidbody tankplayer;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
       

        Vector3 movement = new Vector3();
        movement.x = horizontal * speed;
        movement.z = vertical * speed;
        tankplayer.velocity = movement;
       

    }
}
