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
    //public int quantity;

    [HideInInspector]
    public bool pickedUp;
    [HideInInspector]
    public bool equipped;

    private void Update()
    {
        if (equipped == true)
        {
            //if (ID==1) {

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    //Debug.Log("Used");
                }
            //}
        }
    }
    public void itemUsage()
    {

        if (type == "Potion")
        {
            equipped = true;
        }
        if (type == "BigPotion")
        {
            equipped = true;
        }
        if (type == "SmallGem")
        {
            equipped = true;
        }
        if (type == "MediumGem")
        {
            equipped = true;
        }
        if (type == "BigGem")
        {
            equipped = true;
        }
    }
}
