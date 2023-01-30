using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    
   
    public GameObject[] Rock;
    private void OnEnable()
    {
        EventManager.DestroyRockEvent += DestroyRock;
    }
    private void OnDisable()
    {
        EventManager.DestroyRockEvent -= DestroyRock;
    }
    



    public void DestroyRock()
    {
        
        for(int i = 0; i < Rock.Length ; i ++)
        {
            Destroy(Rock[i], 3f);
            
        }
        
        
        
        
    }
    
}
