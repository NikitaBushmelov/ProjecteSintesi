using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [SerializeField]
    private float rotationSpeed;
    public int Health = 100;
    public GameObject item;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
   

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
    private Vector2 target;
    public bool isFlipped;

    public bool camicaze;

    [SerializeField] public AudioSource controldisparo;
    public AudioClip sonidodisparo;


    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
            drop();

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
    void drop()
    {
        int rand = Random.Range(0, 25);
        if (rand == 24)
        {
            Instantiate(item, transform.position, Quaternion.identity); 
        }if (rand ==2){
               Instantiate(item1, transform.position, Quaternion.identity);
        }if (rand ==12){
               Instantiate(item2, transform.position, Quaternion.identity);
        }if (rand ==18){
               Instantiate(item3, transform.position, Quaternion.identity);
        }if (rand ==6){
               Instantiate(item4, transform.position, Quaternion.identity);
        }
        Debug.Log("el randm " + rand);

    }




    void Update()
    {
        /* enemic espejo
         * float horizontalInput = Input.GetAxis("Horizontal");
         float verticalInput = Input.GetAxis("Vertical");

         Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
         float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
         movementDirection.Normalize();

         transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);
        */

        if (this.GetComponent<AiPlayerDetector>().detect==true)
        {
            LookPlayer();
            if (Vector2.Distance(transform.position, Player.position) > stoppingDistance)
            {

                transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);

            }

            else if (Vector2.Distance(transform.position, Player.position) < stoppingDistance && Vector2.Distance(transform.position, Player.position) > retreatDistance)
            {
                transform.position = this.transform.position;

            }

            else if (Vector2.Distance(transform.position, Player.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.position, -speed * Time.deltaTime);

            }



            //only enemy is shooting enables time between shots
            if (shoots == true)
            {
                if (timeBtwShots <= 0)
                {
                    Instantiate(projectile, transform.position, Quaternion.identity);
                    timeBtwShots = startTimeBtwShots;
                    controldisparo.PlayOneShot(sonidodisparo);

                }

                else
                {
                    timeBtwShots -= Time.deltaTime;
                }
            }
        }
        //boom boom effect

    }


    public void LookPlayer()
    {


        target = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 direction = target - (Vector2)transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        /* Vector3 flipped = transform.localScale;
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
        } */
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(camicaze==true){

        if (col.gameObject.tag == "Player")
        {
            
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().TakeDamage();
            Debug.Log("Is hurt");
            Die();


        }
        }
        

    }


}
