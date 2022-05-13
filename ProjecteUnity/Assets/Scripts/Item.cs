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
    public bool equipped;

    private void Update()
    {
        if (equipped == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1)) { 
            
            }
        }
    }
    public void itemUsage()
    {

        if (type == "Potion")
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
