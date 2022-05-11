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

    //inventory
    private bool invetoryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int EnabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;

    public Text AttackText;

    [SerializeField]
    private float rotationSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        allSlots = slotHolder.transform.childCount;
        slot = new GameObject[allSlots];
        for (int i=0;i<allSlots;i++) {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
        }
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
        //inventory
        if (Input.GetKeyDown(KeyCode.I)) {
            invetoryEnabled=!invetoryEnabled;
        }
        if (invetoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else {
            inventory.SetActive(false);
        }
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
        if (collision.CompareTag("Item")) {
            GameObject itemPickedUp = collision.gameObject;
            Item item = itemPickedUp.GetComponent<Item>();
            AddItem(itemPickedUp,item.ID,item.type,item.desc,item.icon);
        }
    }
    void AddItem(GameObject itemObject, int itemID, string itemType, string itemDesc, Sprite itemIcon) {
        for (int i=0;i<allSlots;i++) { 
            
        }

    }

}
