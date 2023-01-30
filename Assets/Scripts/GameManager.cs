using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Event  Mission CountEnemyDestroy")]
    public TMP_Text CountEnemyDestroyText;
    public TMP_Text MaxCountEnemyDestroyText;
    public GameObject StockDoneMission1;

    private int _MaxcountEnemyDestroy = 14;
    private int _countEnemyDestroy;

    [Header("Event Find Hammer")]
    public int FindItemId;
    public GameObject StockDoneMission2;

    [Header("Warning Mision")]
    public GameObject WarningMission;

    [Header("Start Anim Special")]
    public GameObject Player;
    public GameObject PlayerHammer;

    [Header("Win Game")]
    [SerializeField] private GameObject WinUI;

    [Header("Game Over")]
    [SerializeField] private GameObject GameOverUI;

    [Header("Pause Game")]
    [SerializeField] private GameObject PauseGameUI;


    [Header("Boss")]
    [SerializeField] private GameObject Boss;


    private bool DoneMision2 = false;



    private void Awake()
    {
        Instance = this;
        PlayerHammer.SetActive(false);
        WinUI.SetActive(false);
        GameOverUI.SetActive(false);
        PauseGameUI.SetActive(false);
    }

    private void OnEnable()
    {
        EventManager.CountEnemyDestroyEvent += CountEnemyDestroy;
        EventManager.FindHammerEvent += FindHammer;

        EventManager.StartAnimSpecialEvent += StartAnimationSpecial;
        EventManager.DestroyBossEvent += WinGame;
        EventManager.GameOverEvent += GameOver;


    }
    private void OnDisable()
    {

        EventManager.CountEnemyDestroyEvent -= CountEnemyDestroy;
        EventManager.FindHammerEvent -= FindHammer;

        EventManager.StartAnimSpecialEvent -= StartAnimationSpecial;
        EventManager.DestroyBossEvent -= WinGame;
        EventManager.GameOverEvent -= GameOver;

    }
    private void Start()
    {

    }
    private void Update()
    {
        CountEnemyDestroyText.text = _countEnemyDestroy.ToString();
        MaxCountEnemyDestroyText.text = _MaxcountEnemyDestroy.ToString();
        CheckDoneMission();

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        PauseGameUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void Coutinue()
    {
        PauseGameUI.SetActive(false);
        Time.timeScale =1;
    }
    public void ResetGame()
    {

        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }


    public void BackMenuGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    private void CountEnemyDestroy()
    {
        _countEnemyDestroy++;
    }
    private void FindHammer(int ItemID)
    {
        if (ItemID == FindItemId)
        {
            DoneMision2 = true;
        }
    }


    private void CheckDoneMission()
    {

        if (_countEnemyDestroy == _MaxcountEnemyDestroy)
        {
            StockDoneMission1.SetActive(true);
        }

        if (DoneMision2 == true)
        {
            StockDoneMission2.SetActive(true);
        }

        if (_countEnemyDestroy == _MaxcountEnemyDestroy && DoneMision2 == true)
        {
            WarningMission.SetActive(false);
        }
    }

    public void SetAnimSpecial(bool ButtonF)
    {
        if (ButtonF == true && DoneMision2 == true)
        {

                
                EventManager.StartAnimSpecial();

        }

        
    }

    public void StartAnimationSpecial()
    {
        
       PlayerHammer.SetActive(true) ;
       Player.SetActive(false);
       EventManager.DestroyRock();
    }

    public void WinGame()
    {
        WinUI.SetActive(true);
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<WeaponController>().enabled = false;
    }
    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<WeaponController>().enabled = false;
        Boss.GetComponent<BossController>().enabled = false;
    }
}   
