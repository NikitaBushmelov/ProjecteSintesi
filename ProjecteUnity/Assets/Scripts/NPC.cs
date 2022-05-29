using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Dialog dialog;
    public GameObject panel;
    public void TriggerDialogue() {
        FindObjectOfType<DialogManager>().StartDialogue(dialog);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TriggerDialogue();
            panel.SetActive(true);
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(false);
        }
    }
}
