using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    public int ID;
    public string type;
    public string desc;
    public int quantity;
    public bool empty;
    public Sprite icon;
    public Transform slotIcon, slotIcon2;
    public Text slotText;
    public bool ple;
    

    public event Action<Slot> OnItemClicked;

    private void Start()
    {
        slotIcon = transform.GetChild(0);
        slotIcon2 = transform.GetChild(1);
        Debug.Log(slotIcon.GetComponent<Image>().sprite);
    }

    public void updateSlot() {
            slotIcon.GetComponent<Image>().sprite = icon;
    }
    public void updateIcon() {
        slotIcon.GetComponent<Image>().sprite = slotIcon2.GetComponent<Image>().sprite;
    
    }
    public void useItem() {
        if (item == null)
        {
            return;
        }
        else {
            item.GetComponent<Item>().itemUsage(this);
        }
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
            useItem();
        
    }
}

