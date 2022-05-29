using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AiPlayerAreaDetector : MonoBehaviour
{
    [field: SerializeField]
    public bool PlayerInArea { get; private set; }

    public Transform Player { get; private set; }

    [SerializeField]
    private string detectionTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag))
        {
            gameObject.SetActive(false);
            PlayerInArea = true;
            Player = collision.gameObject.transform;
           
        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag))
        {
            PlayerInArea = false;
            Player = null;

           
        }

    }

}

