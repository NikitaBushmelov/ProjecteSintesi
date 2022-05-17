using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
public GameObject porta;

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

}






}
