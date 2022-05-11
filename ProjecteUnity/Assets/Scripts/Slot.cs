using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject item;
    public int ID;
    public string type;
    public string desc;
    public bool empty;
    public Sprite icon;

    public Transform slotIcon;

    private void Start()
    {
        slotIcon = transform.GetChild(0);
    }

    public void updateSlot() {
        slotIcon.GetComponent<Image>().sprite = icon;
    }
}
