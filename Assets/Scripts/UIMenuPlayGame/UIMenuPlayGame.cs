using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UIMenuPlayGame : MonoBehaviour 
{
    [SerializeField] private GameObject Ask;
    [SerializeField] private GameObject[] LevelMap;

    private int currentMap;

    private void Awake()
    {
        Ask.SetActive(false);
    }
    private void Start()
    {
        currentMap = 0;
        Debug.Log("start" + currentMap);

    }

    private void Update()
    {
    
        if (currentMap == 0)
        {
            LevelMap[0].gameObject.SetActive(true);
        }
        
    }
    public void NextMap()
    {
        currentMap += 1;
        for(int i = 0; i < LevelMap.Length;i++)
        {
            if(currentMap < LevelMap.Length)
            {
                LevelMap[i].gameObject.SetActive(false);
                LevelMap[currentMap].gameObject.SetActive(true);

            }
            else if( currentMap == LevelMap.Length)
            {
                currentMap -= 1;
                LevelMap[currentMap].gameObject.SetActive(true);
            }

            
                
           
        }
        Debug.Log(currentMap);
    }
    public void BackMap()
    {
        currentMap -= 1;
        for (int i = 0; i < LevelMap.Length; i++)
        {
            if (currentMap >= 0)
            {
                LevelMap[i].gameObject.SetActive(false);
                LevelMap[currentMap].gameObject.SetActive(true);
            }

            else if (currentMap < 0)
            {
                currentMap = 0;
                LevelMap[0].gameObject.SetActive(true);
            }
        }
        Debug.Log(currentMap);
    }


    public void BackMenuGame()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
}
