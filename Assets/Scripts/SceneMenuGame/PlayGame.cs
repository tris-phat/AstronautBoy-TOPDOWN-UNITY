using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PlayGame : MonoBehaviour
{
    [SerializeField] private GameObject Manual;

    private void Awake()
    {
        Manual.SetActive(false);
    }

    public void OpenManual()
    {
        Manual.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
