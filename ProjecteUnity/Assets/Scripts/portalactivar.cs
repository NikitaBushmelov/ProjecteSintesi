using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalactivar : MonoBehaviour
{
 public GameObject porta;


 void Update()
    {
        

        if(GameObject.FindGameObjectsWithTag("enemy").Length == 0) {
        Debug.Log ("portal activada");
     porta.SetActive(true);
 }
       else if(GameObject.FindGameObjectsWithTag("enemy").Length >= 1) {
       Debug.Log ("portal desactivada ");
      porta.SetActive(false);
 }

    }
}
