using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectCharacter : MonoBehaviour
{
    public float Timer ;
    public float OverTimer;
    public Image scoreCount;
    public Sprite[] numbersprite;
    

    // Update is called once per frame

    private void Start()
    {
        Timer = 0;
    }
    void Update()
    {
        Timer += Time.deltaTime * 10;
        if (Timer < OverTimer)
        {
            for (int i = 0; i <= numbersprite.Length; i++)
            {
                if(Timer >= i)
                {
                    scoreCount.sprite = numbersprite[i];

                }
            
            }

        }
  
        if(Timer >= OverTimer)
        {
            Timer = 0;
        }

    }
    
}
