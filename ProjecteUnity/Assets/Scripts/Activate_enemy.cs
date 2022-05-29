using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_enemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;



 void OnTriggerEnter2D(Collider2D other) {

    if (other.CompareTag("Player"))
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
            enemy5.SetActive(true);
        }
}
public void OnTriggerExit2D (Collider2D other)
{
 if (other.CompareTag("Player"))
        {
            enemy1.SetActive(false);
            enemy2.SetActive(false);
            enemy3.SetActive(false);
            enemy4.SetActive(false);
            enemy5.SetActive(false);
            //GameObject.FindGameObjectWithTag("Porta").GetComponent<DoorController>().porta.SetActive(true);
        }
}

}
