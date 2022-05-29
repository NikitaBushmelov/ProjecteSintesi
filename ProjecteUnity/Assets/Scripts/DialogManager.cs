using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;

    public Text name;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialog dialog) {
        name.text = dialog.name;
        sentences.Clear();
        foreach (string sentence in dialog.sentences) {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence() {
        if (sentences.Count==0) {
            EndDialogue();
            return;
        }
        string sentence=sentences.Dequeue();
        text.text = sentence;
    }
    public void EndDialogue() {
    }
}
