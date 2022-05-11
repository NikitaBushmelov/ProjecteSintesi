using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ID;
    public string type;
    public string desc;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;
}
