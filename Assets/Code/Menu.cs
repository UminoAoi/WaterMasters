using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string next;

    public void StartButton()
    {
        SceneManager.LoadScene(next);
    }
}
