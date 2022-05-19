using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int ID;
    public string type;
    public string desc;
    public Sprite icon;
    [HideInInspector]
    public bool pickedUp;
    [HideInInspector]
    public bool use;
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (use == true)
        {
            //es per 3D, per guardar al inventari per exemple
        }
    }
    public void itemUsage()
    {

        if (type == "Potion")
        {
            if (player.GetComponent<PlayerMovement>().health< player.GetComponent<PlayerMovement>().maxhealth) {
                player.GetComponent<PlayerMovement>().health += 25;
                player.GetComponent<PlayerMovement>().hpText.text = player.GetComponent<PlayerMovement>().health+"";
                //GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().
                if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health > GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().maxhealth) {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().maxhealth;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().hpText.text = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health + "";
                }
            } 
            
        }
        if (type == "BigPotion")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health += 50;

        }
        
    }
}
