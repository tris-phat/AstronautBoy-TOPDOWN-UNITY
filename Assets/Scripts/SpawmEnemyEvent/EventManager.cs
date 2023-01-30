using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    // event kiểm tra player tới khu vực nào thì active enemy khu vực đó ra
    public static event Action<int> SpawmEnemyEvent;
 
    //Event Mission

    //Event Mission CountEnemyDestroy
    public static event Action CountEnemyDestroyEvent;

    // Event Mission FindHammer

    public static event Action<int> FindHammerEvent;

    // Event AnimationSpecial;

    public static event Action StartAnimSpecialEvent;

    // Event Destroy Rock

    public static event Action DestroyRockEvent;

    // Event Destroy Boss;

    public static event Action DestroyBossEvent;

    // Event Game Over;
    public static event Action GameOverEvent;


    public static void StartSpawmEnemyEvent(int ID)
    {
        SpawmEnemyEvent?.Invoke(ID);
  
    }

   public static void CountEnemyDestroy()
   {
        CountEnemyDestroyEvent?.Invoke();
   }

   public static void FindHammer(int ItemID)
   {
        FindHammerEvent?.Invoke(ItemID);
   }

    public static void StartAnimSpecial()
    {
        
        
        StartAnimSpecialEvent?.Invoke();
 
    }
    public static void DestroyRock()
    {
        DestroyRockEvent?.Invoke();
    }

    public static void DestroyBoss()
    {
        DestroyBossEvent?.Invoke();
    }

    public static void GameOver()
    {
        GameOverEvent?.Invoke();
    }

}
   









   

    
