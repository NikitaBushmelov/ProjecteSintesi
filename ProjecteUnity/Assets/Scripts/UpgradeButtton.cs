using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButtton : MonoBehaviour
{
    public int ID;
    //public Text monedes;
    private string quantitatMonedes;
    private int qm;
    //public Text preu;
    private string quantitatPreu;
    private int qp;
    public int preuStandart;
    public Button btn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        /*quantitatMonedes = monedes.text;
        qm = int.Parse(quantitatMonedes);
        quantitatPreu = preu.text;
        qp = int.Parse(quantitatPreu);*/
        //comprobarId();
        btn.onClick.AddListener(comprobarId);
    }
    
    void comprobarId() {
        Debug.Log("clicked");
        /*if (ID == 1)
        {
            int nivell = 0;
            if (nivell==0) {
                if (qm>=qp) { 
                    //li pujes el daño
                }
                qp = preuStandart;
                preu.text = qp+"";
            }
            if (nivell == 1)
            {
                if (qm >= qp)
                {
                    //li pujes el daño
                }
                //preu multiplicat
                qp = preuStandart*2;
                preu.text = qp + "";
            }
            if (nivell == 2)
            {
                if (qm >= qp)
                {
                    //li pujes el daño
                }
                //preu multiplicat
                qp = preuStandart * 2;
                preu.text = qp + "";
            }
            if (nivell == 3)
            {
                if (qm >= qp)
                {
                    //li pujes el daño
                }
                //preu multiplicat
                qp = preuStandart * 2;
                preu.text = qp + "";
            }
        }
        if (ID == 2)
        {
            int nivell = 0;
            if (nivell == 0)
            {

            }
        }
        if (ID == 3)
        {
            int nivell = 0;
            if (nivell == 0)
            {

            }
        }
        if (ID == 4)
        {
            int nivell = 0;
            if (nivell == 0)
            {

            }
        }*/
    }
}
