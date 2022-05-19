using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool invetoryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int EnabledSlots;
    private GameObject[] slot;
    public int size;
    public GameObject slotHolder;
    [HideInInspector]
    public int pp, pg, gp, gm, gg,pp2,pg2,gp2,gm2,gg2;
    private bool ple;
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
            if (slot[c].GetComponent<Slot>().ID == itemID && slot[c].GetComponent<Slot>().ple == false)
            {
                //comparar id
                if (itemID==1) {
                    if (pp < 3)
                    {
                        pp++;
                        itemObject.GetComponent<Item>().pickedUp = true;
                        itemObject.transform.parent = slot[c].transform;
                        itemObject.SetActive(false);
                        slot[c].GetComponent<Slot>().slotText.text = pp+"";
                        return;
                    }
                    else
                    {
                        pp++;
                        if (pp == 4)
                        {
                            slot[c].GetComponent<Slot>().ple = true;
                            pp = pp - 4;
                            pp2 = 0;
                        }
                    }
                }
            }
            if (slot[c].GetComponent<Slot>().ID == itemID && slot[c].GetComponent<Slot>().ple == false)
            {
                //comparar id
                if (itemID == 2)
                {
                    if (pg < 3)
                    {
                        pg++;
                        itemObject.GetComponent<Item>().pickedUp = true;
                        itemObject.transform.parent = slot[c].transform;
                        itemObject.SetActive(false);
                        slot[c].GetComponent<Slot>().slotText.text = pg + "";
                        return;
                    }
                    else
                    {
                        pg++;
                        if (pg == 4)
                        {
                            slot[c].GetComponent<Slot>().ple = true;
                            pg = pg - 4;
                            pg2 = 0;
                        }
                    }
                }

            }
            if (slot[c].GetComponent<Slot>().ID == itemID && slot[c].GetComponent<Slot>().ple == false)
            {
                //comparar id
                if (itemID == 3)
                {
                    if (gp < 30)
                    {
                        gp++;
                        itemObject.GetComponent<Item>().pickedUp = true;
                        itemObject.transform.parent = slot[c].transform;
                        itemObject.SetActive(false);
                        slot[c].GetComponent<Slot>().slotText.text = gp + "";
                        return;
                    }
                    else
                    {
                        gp++;
                        if (gp == 31)
                        {
                            slot[c].GetComponent<Slot>().ple = true;
                            gp = gp - 31;
                            gp2 = 0;
                        }
                    }
                }

            }
            if (slot[c].GetComponent<Slot>().ID == itemID && slot[c].GetComponent<Slot>().ple == false)
            {
                //comparar id
                if (itemID == 4)
                {
                    if (gm < 15)
                    {
                        gm++;
                        itemObject.GetComponent<Item>().pickedUp = true;
                        itemObject.transform.parent = slot[c].transform;
                        itemObject.SetActive(false);
                        slot[c].GetComponent<Slot>().slotText.text = gm + "";
                        return;
                    }
                    else
                    {
                        gm++;
                        if (gm == 16)
                        {
                            slot[c].GetComponent<Slot>().ple = true;
                            gm = gm - 16;
                            gm2 = 0;
                        }
                    }
                }

            }
            if (slot[c].GetComponent<Slot>().ID == itemID && slot[c].GetComponent<Slot>().ple == false)
            {
                //comparar id
                if (itemID == 5)
                {
                    if (gg < 5)
                    {
                        gg++;
                        itemObject.GetComponent<Item>().pickedUp = true;
                        itemObject.transform.parent = slot[c].transform;
                        itemObject.SetActive(false);
                        slot[c].GetComponent<Slot>().slotText.text = gg + "";
                        return;
                    }
                    else
                    {
                        gg++;
                        if (gg == 6)
                        {
                            slot[c].GetComponent<Slot>().ple = true;
                            gg = gg - 6;
                            gg2 = 0;
                        }
                    }
                }

            }
            if (slot[c].GetComponent<Slot>().empty == false)
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

                if (itemID == 1 && pp2==0)
                {
                    slot[c].GetComponent<Slot>().slotText.text = 1 + "";
                    pp++;
                    pp2 = 1;
                }
                if (itemID == 2 && pg2 == 0)
                {
                    slot[c].GetComponent<Slot>().slotText.text = 1 + "";
                    pg++;
                    pg2 = 1;
                }
                if (itemID == 3 && gp2 == 0)
                {
                    slot[c].GetComponent<Slot>().slotText.text = 1 + "";
                    gp++;
                    gp2 = 1;
                }
                if (itemID == 4 && gm2 == 0)
                {
                    slot[c].GetComponent<Slot>().slotText.text = 1 + "";
                    gm++;
                    gm2 = 1;
                }
                if (itemID == 5 && gg2 == 0)
                {
                    slot[c].GetComponent<Slot>().slotText.text = 1 + "";
                    gg++;
                    gg2 = 1;
                }
                slot[c].GetComponent<Slot>().empty = true;
                return;

            }            
        }

    }
}
