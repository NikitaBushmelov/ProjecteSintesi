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
    public void itemUsage(Slot slot)
    {
        if (type == "Potion")
        {
            if (player.GetComponent<PlayerMovement>().health < player.GetComponent<PlayerMovement>().maxhealth)
            {
                player.GetComponent<PlayerMovement>().health += 25;
                player.GetComponent<PlayerMovement>().hpText.text = player.GetComponent<PlayerMovement>().health + "";
                if (player.GetComponent<PlayerMovement>().health > player.GetComponent<PlayerMovement>().maxhealth)
                {
                    player.GetComponent<PlayerMovement>().health = player.GetComponent<PlayerMovement>().maxhealth;
                    player.GetComponent<PlayerMovement>().hpText.text = player.GetComponent<PlayerMovement>().health + "";
                    player.GetComponent<Inventory>().removeItem(slot);
                    return;
                }
                player.GetComponent<Inventory>().removeItem(slot);
            }
        }
        if (type == "BigPotion")
        {
            if (player.GetComponent<PlayerMovement>().health < player.GetComponent<PlayerMovement>().maxhealth)
            {
                player.GetComponent<PlayerMovement>().health += 50;
                player.GetComponent<PlayerMovement>().hpText.text = player.GetComponent<PlayerMovement>().health + "";
                if (player.GetComponent<PlayerMovement>().health > player.GetComponent<PlayerMovement>().maxhealth)
                {
                    player.GetComponent<PlayerMovement>().health = player.GetComponent<PlayerMovement>().maxhealth;
                    player.GetComponent<PlayerMovement>().hpText.text = player.GetComponent<PlayerMovement>().health + "";
                    player.GetComponent<Inventory>().removeItem(slot);
                    return;
                }
                player.GetComponent<Inventory>().removeItem(slot);
            }

        }
    }
}