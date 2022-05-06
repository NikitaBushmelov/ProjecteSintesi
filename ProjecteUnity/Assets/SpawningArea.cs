using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningArea : MonoBehaviour
{
    
    public int spawnPorta;
    public int enemiesRemaining;
    public GameObject[] enemies;
    private bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            
            if (spawnPorta==1 &&spawned==false) {
                
            }
            spawned = true;
        }
    }
}
