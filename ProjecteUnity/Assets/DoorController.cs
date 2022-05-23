using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
public GameObject porta;
/*
public void OnTriggerEnter2D (Collider2D other)
{
 if (other.CompareTag("Player"))
        {
            porta.SetActive(true);
        }
  
}
public void OnTriggerExit2D (Collider2D other)

{
 if (other.CompareTag("Player"))
        {
            porta.SetActive(false);
        }

}*/
 void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("enemy");

        if (gameObjects.Length == 0 )
        {
            Debug.Log("No game objects are tagged with 'enemy'");
            porta.SetActive(false);

        }if(gameObjects.Length >= 1) {

             Debug.Log("hay enemigos");
            porta.SetActive(true);
        }

    }






}
