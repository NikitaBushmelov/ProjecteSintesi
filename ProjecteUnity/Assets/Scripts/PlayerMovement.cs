using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public int health;
    public Text hpText;
    public Text MovementSpeed;
    public int daño;

    

    public Text AttackText;

    [SerializeField]
    private float rotationSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);


        }
        //text
        movementText();
        dmgText();
        
    }
    
    public void dmgText()
    {
        AttackText.text = "" + daño;
    }

    public void movementText() 
    {
        float v = speed;
        MovementSpeed.text = "" + v;
    }
    public void TakeDamage() {
        
            health -= GameObject.FindGameObjectWithTag("enemy").GetComponent<Enemy>().dmg;
            hpText.text = "" + health;
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Laser")) {
            TakeDamage();
        }
        
    }
    

}
