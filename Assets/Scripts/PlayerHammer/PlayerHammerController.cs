using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHammerController : MonoBehaviour
{
    public LoadingAnimHammer loadingAnimHammer;
    public GameObject Loading;
    public GameObject Player;
    public float TimeLine = 3;
    public float overTime = 0;

    private void Awake()
    {
        Loading.SetActive(false);
    }
    private void Start()
    {
        loadingAnimHammer.SetMaxValue(TimeLine);
        loadingAnimHammer.SetValue(overTime);
    }
    private void Update()
    {
        if(overTime < TimeLine )
        {
            Loading.SetActive(true);
            overTime += Time.deltaTime;
            loadingAnimHammer.SetValue(overTime);
        }
        if(overTime >= TimeLine)
        {
            Loading.SetActive(false);
            Player.SetActive(true);
            gameObject.SetActive(false);
        }
    }


}
