using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject bubble;
    public TextMeshProUGUI dialogue;

    bool isShowing = false;
    public float showingTime = 3;
    float currentTime = 0;

    private void Start()
    {
        bubble.SetActive(false);
    }

    private void Update()
    {
        if (isShowing)
        {
            if (currentTime > showingTime)
            {
                bubble.SetActive(false);
                currentTime = 0;
                isShowing = false;
            }
            else
                currentTime += Time.deltaTime;
        }
    }

    public void ShowNextDialogue(string newDialogue)
    {
        dialogue.text = newDialogue;
        bubble.SetActive(true);
        isShowing = true;
    }
}
