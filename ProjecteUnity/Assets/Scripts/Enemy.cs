using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    [SerializeField]
    private float rotationSpeed;
    public int health = 100;

    public GameObject deathEffect;
    public float speed;
    public int dmg;
    public float stoppingDistance;
    public float retreatDistance;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public GameObject projectile;
    public Transform Player;
    public bool shoots;
    public bool isFlipped = false;


    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();
        LookPlayer();
        if (Vector2.Distance(transform.position, Player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);

        }

        else if (Vector2.Distance(transform.position, Player.position) < stoppingDistance && Vector2.Distance(transform.position, Player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);

        }

        else if (Vector2.Distance(transform.position, Player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, -speed * Time.deltaTime);

            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
        }

        //only enemy is shooting enables time between shots
        if (shoots == true)
        {
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;

            }

            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }

        //boom boom effect
        if (health <= 0 && !IsInvoking("DestroySpawnPoint"))
        {

            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Invoke("DestroySpawnPoint", 0.0f);
        }
    }


    public void LookPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;
        if (transform.position.x > Player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < Player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
public void OnCollisionEnter2D(Collision2D col)
{
    if (col.gameObject.tag == "Player")
    {
        Debug.Log("Is hurt");

        
    }

}


}
