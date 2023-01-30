using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProfile : MonoBehaviour
{
    
    public int HP;
    public int Armor;

   
    public void TakeDamage(int Damage)
    {
        HP -= (Damage - Armor);
       
        if(HP<=0)
        {
            HP = 0;
            Destroy(gameObject);
            EventManager.CountEnemyDestroy();
        }
   

    }


    
}
