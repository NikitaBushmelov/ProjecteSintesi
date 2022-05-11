using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{


    public float speed =0.1f;
    public Rigidbody2D rb;
    private int damage;
    public GameObject impactEffect;
    // Update is called once per frame
    void Start()
    {
        rb.velocity = transform.right * speed;
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().daño;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
       
        Enemy enemy = col.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
       
    }
}
