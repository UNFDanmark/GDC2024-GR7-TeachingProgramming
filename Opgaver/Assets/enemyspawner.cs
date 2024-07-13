using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public float inspawn = 7f;
    public float spawncooldown = 7f;
    public GameObject enemyprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawncooldown = spawncooldown - Time.deltaTime;
        if (spawncooldown <= 0)
        {
            Instantiate(enemyprefab, transform.position, Quaternion.identity);
            
            spawncooldown = inspawn;
        }
    }
}
