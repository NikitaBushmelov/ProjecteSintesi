using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{
    public Text monedes;
    private string quantitatMonedes;
    private int qm;
    public Button btn;
    int countPreu;
    int cGemes;
    private GameObject[] slot;
    private GameObject inv;
    void Start()
    {
        btn.onClick.AddListener(vendre);
        inv = GameObject.FindGameObjectWithTag("Player");
        slot = inv.GetComponent<Inventory>().slot;
    }

    // Update is called once per frame
    void Update()
    {
            quantitatMonedes = monedes.text;
            qm = int.Parse(quantitatMonedes);
            monedes.text = (qm + countPreu) + "";
        
    }
    void vendre() {
        for (int i=0;i<8;i++) {
            if (slot[i].GetComponent<Slot>().ID == 3)
            {
                cGemes = cGemes+(slot[i].GetComponent<Slot>().quantity * 5);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().gp = 0;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().gp2 = 0;
                slot[i].GetComponent<Slot>().slotText.text = 0+"";
                slot[i].GetComponent<Slot>().item = null;
                slot[i].GetComponent<Slot>().quantity = 0;
                slot[i].GetComponent<Slot>().ple = false;
                slot[i].GetComponent<Slot>().ID = 0;
                slot[i].GetComponent<Slot>().type = null;
                slot[i].GetComponent<Slot>().desc = null;
                slot[i].GetComponent<Slot>().icon = null;
                slot[i].GetComponent<Slot>().empty = false;
                slot[i].GetComponent<Slot>().updateIcon();
                monedes.text = qm + cGemes + "";
            }
            if (slot[i].GetComponent<Slot>().ID == 4)
            {
                cGemes = cGemes + (slot[i].GetComponent<Slot>().quantity * 10);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().gp = 0;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().gp2 = 0;
                slot[i].GetComponent<Slot>().slotText.text = 0 + "";
                slot[i].GetComponent<Slot>().item = null;
                slot[i].GetComponent<Slot>().quantity = 0;
                slot[i].GetComponent<Slot>().ple = false;
                slot[i].GetComponent<Slot>().ID = 0;
                slot[i].GetComponent<Slot>().type = null;
                slot[i].GetComponent<Slot>().desc = null;
                slot[i].GetComponent<Slot>().icon = null;
                slot[i].GetComponent<Slot>().empty = false;
                slot[i].GetComponent<Slot>().updateIcon();
                monedes.text = qm + cGemes + "";
            }
            if (slot[i].GetComponent<Slot>().ID == 5)
            {
                cGemes = cGemes + (slot[i].GetComponent<Slot>().quantity * 25);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().gp = 0;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().gp2 = 0;
                slot[i].GetComponent<Slot>().slotText.text = 0 + "";
                slot[i].GetComponent<Slot>().item = null;
                slot[i].GetComponent<Slot>().quantity = 0;
                slot[i].GetComponent<Slot>().ple = false;
                slot[i].GetComponent<Slot>().ID = 0;
                slot[i].GetComponent<Slot>().type = null;
                slot[i].GetComponent<Slot>().desc = null;
                slot[i].GetComponent<Slot>().icon = null;
                slot[i].GetComponent<Slot>().empty = false;
                slot[i].GetComponent<Slot>().updateIcon();
                monedes.text = qm + cGemes + "";
            }
        }
    }
}
