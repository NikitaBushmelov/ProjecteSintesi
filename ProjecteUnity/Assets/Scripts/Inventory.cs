using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //inventory
    private bool invetoryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int EnabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;
    public void Start()
    {
        allSlots = slotHolder.transform.childCount;
        slot = new GameObject[allSlots];
        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
            if (slot[i].GetComponent<Slot>().item == true)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }
    public void Update()
    {
        //inventory
        if (Input.GetKeyDown(KeyCode.I))
        {
            invetoryEnabled = !invetoryEnabled;
        }
        if (invetoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            GameObject itemPickedUp = other.gameObject;
            Item item = itemPickedUp.GetComponent<Item>();
            AddItem(itemPickedUp, item.ID, item.type, item.desc, item.icon);
        }
    }
    void AddItem(GameObject itemObject, int itemID, string itemType, string itemDesc, Sprite itemIcon)
    {
        for (int c = 0; c < allSlots; c++)
        {
            if (slot[c].GetComponent<Slot>().empty)
            {

                itemObject.GetComponent<Item>().pickedUp = true;
                slot[c].GetComponent<Slot>().item = itemObject;
                slot[c].GetComponent<Slot>().ID = itemID;
                slot[c].GetComponent<Slot>().type = itemType;
                slot[c].GetComponent<Slot>().desc = itemDesc;
                slot[c].GetComponent<Slot>().icon = itemIcon;

                itemObject.transform.parent = slot[c].transform;
                itemObject.SetActive(false);

                slot[c].GetComponent<Slot>().updateSlot();

                slot[c].GetComponent<Slot>().empty = false;
            }
            return;
        }

    }
}
