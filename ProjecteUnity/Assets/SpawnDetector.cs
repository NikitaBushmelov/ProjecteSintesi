using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDetector : MonoBehaviour
{
    public bool spawn;
    public bool spawned;
    Transform[] allChildren;
    bool clear;
    private void Start()
    {
        allChildren = this.transform.GetComponentsInChildren<Transform>();
        for (int i = 0; i < allChildren.Length; i++)
        {
            Debug.Log(allChildren[i].name);
        }
    }
    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&spawned==false) {
            //GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<DoorSpawning>();
            spawn = true;
            spawned = true;
        }
        if (collision.CompareTag("Enemy")) { 
            
        }
    }
}
