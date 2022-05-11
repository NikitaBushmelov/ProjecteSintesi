using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShop : MonoBehaviour
{
   

    public bool puedeAbrir;
    public bool abrir;
    public GameObject canvas;
    //public GameObject gameObjectToDesactivate;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("e") && puedeAbrir == true && abrir == false)
        {          
            abrir = true;
            //gameObjectToDesactivate.SetActive(false);
            canvas.SetActive(true);
            
        }
        else if (Input.GetButtonDown("e") && puedeAbrir == true && abrir == true)
        {
            abrir = false;
            //gameObjectToDesactivate.SetActive(true);
            canvas.SetActive(false);

        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            puedeAbrir = true;
            //gameObjectToDesactivate.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            puedeAbrir = false;
            canvas.SetActive(false);
        }
    }

}

