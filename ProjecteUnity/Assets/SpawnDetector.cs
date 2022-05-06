using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDetector : MonoBehaviour
{
    public bool spawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            //GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<DoorSpawning>();
            spawn = true;
        }
    }
}
