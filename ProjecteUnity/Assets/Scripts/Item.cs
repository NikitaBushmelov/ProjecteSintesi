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
            //es per 3D, per guardar al inventari per exemple
            
        }
    }
    public void itemUsage()
    {

        if (type == "Potion")
        {
            Debug.Log("Used");
            
            
        }
        if (type == "BigPotion")
        {

        }
        if (type == "SmallGem")
        {

        }
        if (type == "MediumGem")
        {
            
        }
        if (type == "BigGem")
        {
            
        }
    }
}
