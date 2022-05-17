using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float speed;
    public int health;
    public int playerHealth;
    public Text hpText;
    public Text MovementSpeed;
    public int dmg;

    private string healthPrefsName = "helath";
    
    private Portal userInterface;
    

    

    public Text AttackText;

    [SerializeField]
    private float rotationSpeed; 
    // Start is called before the first frame update

    private void Awake(){
        LoadData();
    }
    void Start()
    {
        //playerHealth = health;
        RefreshUI();
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
        AttackText.text = "" + dmg;
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
        if (collision.CompareTag("Test"))
        {
            SceneManager.LoadScene("TestMap");
        }

    }
    private void RefreshUI()
    {
        hpText.text=health+"";
        
    }
    public void SavePlayer() {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data= SaveSystem.LoadPlayer();
        speed = data.speed;
        dmg = data.damage;
        health = data.health;
    }

    private void OnDestroy() {

        SaveData();
        
    }
    private void SaveData()
    {
        PlayerPrefs.SetInt(healthPrefsName,health);


    }
    private void LoadData()
    {
        health = PlayerPrefs.GetInt(healthPrefsName,0);
    }
    

}
