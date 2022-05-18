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
    public int maxhealth=100;
    public Text hpText;
    public Text MovementSpeed;
    public int dmg;
    public float attackspeed;

    private string prefHP;
    
    private Portal userInterface;
    public Text AttackText;
    private int c;

    private bool OptionsOn;
    public GameObject Options;
    

    [SerializeField]
    private float rotationSpeed; 
    // Start is called before the first frame update

    private void Awake(){
      
        LoadData();
        
        
    }
    void Start()
    {
        RefreshUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsOn = !OptionsOn;
        }
        if (OptionsOn == true)
        {
            Options.SetActive(true);
        }
        else
        {
            Options.SetActive(false);
        }





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
        if (health<=0) {
            die();
            c++;
        }
        if(c==1){
            health=maxhealth;
            c=0;
        
        }
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
    }

    private void OnDestroy() {

        SaveData();
        
    }
    private void SaveData()
    {
        PlayerPrefs.SetInt(prefHP,health);

    }
    private void LoadData()
    {
        
        health = PlayerPrefs.GetInt(prefHP, 0);
         PlayerPrefs.SetInt(prefHP, health);
    }
    void die()
    {
     
        health=maxhealth;
        //health = 100;
        //PlayerPrefs.SetInt(prefHP, health);
        SceneManager.LoadScene("Lose");
    }

}
