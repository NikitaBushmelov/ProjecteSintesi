using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButtton : MonoBehaviour
{
    public int ID;
    public Text monedes;
    private string quantitatMonedes;
    private int qm;
    int c = 1;

    public Text preu;
    private string quantitatPreu;
    private int qp;
    public int preuStandart;
    public Button btn;
    

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(comprobarId);
        preu.text = preuStandart+"";
    }

    // Update is called once per frame
    void Update()
    {
        if (!preu.text.Equals("Max")) {

            quantitatMonedes = monedes.text;
            qm = int.Parse(quantitatMonedes);
            quantitatPreu = preu.text;
            qp = int.Parse(quantitatPreu);
        }
        
    }
    
    void comprobarId() {
        if (ID == 1)
        {
            if (qm >= preuStandart)
            {
                
                if (c<4) {
                    c++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * c;
                    preuStandart = cost;
                    preu.text = cost + "";
                    
                    //provan de guardar mes vida
                    PlayerPrefs.SetInt("prefHP", 150);
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health += 50;
                }
                if (c==4) {
                    preu.text ="Max";
                }
            }
        }
        if (ID == 2)
        {
            if (qm >= preuStandart)
            {
                if (c < 4)
                {
                    c++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * c;
                    preuStandart = cost;
                    preu.text = cost + "";
                }
                if (c == 4)
                {
                    preu.text = "Max";
                }
            }
        }
        if (ID == 3)
        {
            if (qm >= preuStandart)
            {
                if (c < 4)
                {
                    c++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * c;
                    preuStandart = cost;
                    preu.text = cost + "";
                }
                if (c == 4)
                {
                    preu.text = "Max";
                }
            }
        }
        if (ID == 4)
        {
            if (qm >= preuStandart)
            {
                if (c < 4)
                {
                    c++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * c;
                    preuStandart = cost;
                    preu.text = cost + "";
                }
                if (c == 4)
                {
                    preu.text = "Max";
                }
            }
        }
    }
}
