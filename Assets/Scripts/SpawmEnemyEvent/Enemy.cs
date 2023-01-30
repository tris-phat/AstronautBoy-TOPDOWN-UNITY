using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject EnemyParent;

    [SerializeField] int EnemyID;
    private bool start = false;

    private void OnEnable()
    {
        EventManager.SpawmEnemyEvent += SpawmEnemy;
    }
    private void OnDisable()
    {
        EventManager.SpawmEnemyEvent -= SpawmEnemy;
    }

    void Update()
    {
        if(start == true)
        {
            EnemyParent.SetActive(true);
        }
    }

    private void SpawmEnemy(int AreaID)
    {
        
        if(AreaID == EnemyID)
        {
            start = true;
        }
      
    }
    
}
