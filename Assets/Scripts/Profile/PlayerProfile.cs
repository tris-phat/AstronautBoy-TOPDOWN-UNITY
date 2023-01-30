using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : MonoBehaviour
{

   
    [Header("Heath Bar UI")]
    [SerializeField] private HealthBar HealthBar;
    [SerializeField] private Animator animator;
    
    [Header("Profile Player")]
    public int MaxHP;
    public int HP;
    public int Armor;

    private void Start()
    {
        HP = MaxHP;
        HealthBar.SetMaxHP(MaxHP);
        HealthBar.SetHP(HP);
    }
    public  void TakeDamage(int dmg)
    {
        HP -= (dmg - Armor);
        HealthBar.SetHP(HP);
        
        if(HP <= 0)
        {
            HP = 0;
            animator.SetTrigger("Death");
        
            EventManager.GameOver();
            
        }
      
            
    }

    
   

        
    
}
