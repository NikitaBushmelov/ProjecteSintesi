using System.Collections;
using System.Collections.Generic;
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
    public Transform slotIcon;

    private void Start()
    {
        slotIcon = transform.GetChild(0);
    }

    public void updateSlot() {
            slotIcon.GetComponent<Image>().sprite = icon;
    }
    public void useItem() {
        item.GetComponent<Item>().itemUsage();
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        useItem();
    }
}
