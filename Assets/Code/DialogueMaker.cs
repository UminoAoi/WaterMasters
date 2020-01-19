using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMaker : MonoBehaviour
{
    Dialogue dialogue;
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = FindObjectOfType<Dialogue>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogue.ShowNextDialogue(text);
    }
}
