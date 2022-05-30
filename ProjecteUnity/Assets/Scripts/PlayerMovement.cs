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
    public int maxhealth=50;
    public Text hpText;
    public Text MovementSpeed;
    public int dmg;
    public float attackspeed;

    private string prefHP;
    
    private Portal userInterface;
    public Text AttackText;
    public Text Monedes;
    private int c;

    public bool OptionsOn;
    public GameObject Options;
    string sceneName;

    [SerializeField]
    private float rotationSpeed; 
    // Start is called before the first frame update

    private void Awake(){
        LoadData();
    }
    void Start()
    {
        RefreshUI();
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        //opcions
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsOn = !OptionsOn;
        }
        if (OptionsOn == true)
        {
            Options.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
            Options.SetActive(false);
        }
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().invetoryEnabled == true && OptionsOn==true) {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().invetoryEnabled = false;
            
        }
        if (sceneName=="Lobby") {
            if (GameObject.FindGameObjectWithTag("Maquina").GetComponent<OpenShop>().obert == true && OptionsOn == true)
            {
                GameObject.FindGameObjectWithTag("Maquina").GetComponent<OpenShop>().canvas.SetActive(false);
                GameObject.FindGameObjectWithTag("Maquina").GetComponent<OpenShop>().abrir = false;
            }
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
           // c++;
        }
        /*if(c==1){
            health=maxhealth;
            c=0;
        }*/
    }
    public void dmgText()
    {
        AttackText.text = "" + dmg;
    }
    public void movementText() 
    {
        MovementSpeed.text = "" + speed;
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
    /*public void SavePlayer() {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data= SaveSystem.LoadPlayer(); 
    }*/
    private void OnDestroy() {
        SaveData();
    }
    private void SaveData()
    {
        PlayerPrefs.SetInt(prefHP,health);
        PlayerPrefs.SetString("monedes",Monedes.text);
        PlayerPrefs.SetInt("MaxHP",maxhealth);
        PlayerPrefs.SetFloat("MoveSpeed", speed);
        PlayerPrefs.SetFloat("BulletSpeed", attackspeed);
        PlayerPrefs.SetInt("Dmg", dmg);
    }
    private void LoadData()
    {
        health = PlayerPrefs.GetInt(prefHP, 50);
        Monedes.text = PlayerPrefs.GetString("monedes");
        maxhealth= PlayerPrefs.GetInt("MaxHP", maxhealth); 
        speed= PlayerPrefs.GetFloat("MoveSpeed", 4);
        attackspeed = PlayerPrefs.GetFloat("BulletSpeed",0.4f);
        dmg = PlayerPrefs.GetInt("Dmg",20);
    }
    void die()
    {
        health = maxhealth;
       
        SceneManager.LoadScene("Lose");
    }
}
