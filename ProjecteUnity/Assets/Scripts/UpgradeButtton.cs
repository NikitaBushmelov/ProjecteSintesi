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

    public Text preu;
    private string quantitatPreu;
    private int qp;
    public int preuStandart;
    public Button btn;
    

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        btn.onClick.AddListener(comprobarId);
        //preu.text = preuStandart+"";
        if (ID==1) {
            if (cmh == 4)
            {
                preu.text = "Max";
            }
            else {
                preu.text = preuStandart * cmh + "";
            }
        }
        if (ID == 2)
        {
            if (cmh == 4)
            {
                preu.text = "Max";
            }
            else
            {
                preu.text = preuStandart * cms + "";
            }
        }
        if (ID == 3)
        {
            if (cmh == 4)
            {
                preu.text = "Max";
            }
            else
            {
                preu.text = preuStandart * cdm + "";
            }
            
        }
        if (ID == 4)
        {
            if (cmh == 4)
            {
                preu.text = "Max";
            }
            else
            {
                preu.text = preuStandart * cas + "";
            }
        }
        //Debug.Log("vida " + cmh + " aspeed " + cas + " movespeed " + cms + " dmg " + cdm);
    }
    // Update is called once per frame
    void Update()
    {

        quantitatMonedes = monedes.text;
        qm = int.Parse(quantitatMonedes);
        quantitatPreu = preu.text;
        qp = int.Parse(quantitatPreu);
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
                    int cost = preuStandart * cmh;
                    preu.text = "" +cost;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().maxhealth += 50;
                    SaveData();
                }
            }
        }
        if (ID == 2)
        {
            if (qm >= preuStandart)
            {
                if (cms < 4)
                {
                    cms++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * cms;
                    preu.text = "" + cost;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().speed += 0.25f;
                    SaveData();
                }
            }
        }
        if (ID == 3)
        {
            if (qm >= preuStandart)
            {
                if (cdm < 4)
                {
                    cdm++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * cdm;
                    preu.text = "" + cost;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().dmg += 20;
                    SaveData();
                }
            }
        }
        if (ID == 4)
        {
            if (qm >= preuStandart)
            {
                if (cas < 4)
                {
                    cas++;
                    int resta = qm - preuStandart;
                    monedes.text = resta + "";
                    int cost = preuStandart * cas;
                    preu.text = "" + cost;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().attackspeed -= 0.05f;
                    SaveData();
                }
            }
        }
    }
    private void SaveData() {
        PlayerPrefs.SetInt("vida",cmh);
        PlayerPrefs.SetInt("mspeed", cms);
        PlayerPrefs.SetInt("dmg", cdm);
        PlayerPrefs.SetInt("aspeed", cas);
    }
    private void LoadData() {
        
        cmh = PlayerPrefs.GetInt("vida", 1);
        preu.text = (preuStandart * cmh) + "";
        cms = PlayerPrefs.GetInt("mspeed", 1);
        preu.text = (preuStandart * cms) + "";
        cdm = PlayerPrefs.GetInt("dmg", 1);
        preu.text = (preuStandart * cdm) + "";
        cas = PlayerPrefs.GetInt("aspeed", 1);
        preu.text = (preuStandart * cas) + "";
        
    }
}
