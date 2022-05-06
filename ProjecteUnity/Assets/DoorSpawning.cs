using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawning : MonoBehaviour
{
    public GameObject porta;
    private bool spawned;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnDetector>().spawn == true && spawned==false) {
            Instantiate(porta, this.GetComponentInChildren<Transform>().position, Quaternion.identity);
            spawned = true;
        }
    }

}
