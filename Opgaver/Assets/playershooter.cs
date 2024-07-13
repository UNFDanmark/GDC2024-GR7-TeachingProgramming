using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershooter : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float cooldown =0.2f;
    private float cooldownLeft;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");
    }

    // Update is called once per frame
    void Update()
    {
        
        float rotation = Input.GetAxisRaw("Rotation Horizontal");
        transform.Rotate(0,rotation,0);
        cooldownLeft = cooldownLeft - Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && cooldownLeft <= 0)
        {
            
            print("Space er holdt nede");
             GameObject bullet =  Instantiate(bulletPrefab,transform.position, Quaternion.identity);
             Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
             bulletRb.velocity = transform.forward * bulletSpeed;
            cooldownLeft = cooldown;
            GameObject.Destroy(bullet,5);
        }

    }

    
}
