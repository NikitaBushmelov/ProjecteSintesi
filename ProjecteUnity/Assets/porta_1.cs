using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta_1 : MonoBehaviour
{
  public  GameObject porta;
public void OnTriggerEnter2D (Collider2D other)
{
 if (other.CompareTag("Player"))
        {
            porta.SetActive(false);
        }
  
}
public void OnTriggerExit2D (Collider2D other)

{
 if (other.CompareTag("Player"))
        {
            porta.SetActive(true);
        }
}
}

