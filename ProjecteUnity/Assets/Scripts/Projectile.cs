using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
   
    public GameObject destroyEffect;
    public int dmg = 20;
    private Vector2 target;
    public Rigidbody2D rb;

   

    private void Start()
    {
        
        targetPlayer();
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            DestroyBullet();
        }
        if (other.CompareTag("Paret"))
        {
            
            DestroyBullet();
        }
        
         if (other.CompareTag("Porta"))
        {

            DestroyBullet();
        }
    }
    void targetPlayer()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 direction = target - (Vector2)transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    void DestroyBullet()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}