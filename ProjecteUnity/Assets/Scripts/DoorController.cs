using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
public GameObject porta;


 void Update()
    {
        

        if(GameObject.FindGameObjectsWithTag("enemy").Length == 0) {
        Debug.Log ("no hi ha enemics");
     porta.SetActive(false);
 }
 else if(GameObject.FindGameObjectsWithTag("enemy").Length >= 1) {
     Debug.Log ("si enemics");
    porta.SetActive(true);
 }

    }
    
    }





