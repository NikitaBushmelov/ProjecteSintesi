using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{


    public float speed =0.1f;
    public GameObject impactEffect;
    public Rigidbody2D rb;
    
    // Update is called once per frame
    private void Update()
    {
        rb.velocity = transform.right * speed; 
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Paret")
        {
            Destroy(gameObject);
        }
    }
}
