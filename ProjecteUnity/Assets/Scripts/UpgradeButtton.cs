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
    int cmh = 1,cas=1,cms=1,cdm=1;
    int cost1;

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
        LoadData();
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
                
                if (cmh<4) {
                    cmh++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    cost1 = preuStandart * cmh;
                    preuStandart = cost1;
                    preu.text = cost1 + "";
                    SaveData();
                }
                if (cmh == 4) {
                    preu.text ="Max";
                }
            }
        }
        if (ID == 2)
        {
            if (qm >= preuStandart)
            {
                if (cas < 4)
                {
                    cas++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * cas;
                    preuStandart = cost;
                    preu.text = cost + "";
                }
                if (cas == 4)
                {
                    preu.text = "Max";
                }
            }
        }
        if (ID == 3)
        {
            if (qm >= preuStandart)
            {
                if (cms < 4)
                {
                    cms++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * cms;
                    preuStandart = cost;
                    preu.text = cost + "";
                }
                if (cms == 4)
                {
                    preu.text = "Max";
                }
            }
        }
        if (ID == 4)
        {
            if (qm >= preuStandart)
            {
                if (cdm < 4)
                {
                    cdm++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * cdm;
                    preuStandart = cost;
                    preu.text = cost + "";
                }
                if (cdm == 4)
                {
                    preu.text = "Max";
                }
            }
        }
    }
    private void SaveData() {
        PlayerPrefs.SetInt("vida",cmh);
    }
    private void LoadData() { 
        cmh= PlayerPrefs.GetInt("vida", 0); 
    }
}
