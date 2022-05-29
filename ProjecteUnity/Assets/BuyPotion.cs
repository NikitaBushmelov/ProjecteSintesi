using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyPotion : MonoBehaviour
{
    public int ID;
    public Text monedes;
    private string quantitatMonedes;
    private int qm;
    public int preu;
    public GameObject item;

    public Button btn;

    private void Start()
    {
        btn.onClick.AddListener(EnviarId);
    }
    private void Update()
    {
        quantitatMonedes = monedes.text;
        qm = int.Parse(quantitatMonedes);
    }
    void EnviarId() {
        if (ID==1) {
            if (qm >= preu)
            {
                qm = qm - preu;
                monedes.text = qm + "";
                Instantiate(item,new Vector3((-0.2f),(-0.25f),0),Quaternion.identity);
            }
        }
        if (ID == 2)
        {
            if (qm >= preu)
            {
                qm = qm - preu;
                monedes.text = qm + "";
                Instantiate(item, new Vector3( 0,( -0.25f), 0), Quaternion.identity);
            }
        }

    }
}
