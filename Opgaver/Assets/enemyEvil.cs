using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class enemyEvil : MonoBehaviour
{
    public NavMeshAgent enemy;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }

    private void Update()
    {
        enemy.SetDestination(player.transform.position);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Debug.Log(other.gameObject.name);
            Destroy(gameObject);
        }
    }
}