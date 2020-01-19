using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryDialogue : MonoBehaviour
{
    public List<string> dialogues = new List<string>();
    public GameObject bubble;
    public GameObject image;
    public TextMeshProUGUI text;
    int current = 0;
    public Sprite nextSprite;

    public string next;

    private void Start()
    {
        text.text = dialogues[current++];
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (dialogues.Count > current)
                text.text = dialogues[current++];
            else
            {
                bubble.SetActive(false);
                image.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                StartCoroutine(WaitAndGo());
            }
        }
    }

    IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(3);
        image.GetComponent<Image>().sprite = nextSprite;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(next);
    }
}
