
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBarrbierManager : MonoBehaviour
{
    [SerializeField] private Animator Animator;
    [SerializeField] private float LifeTime;
    
    private void OnCollisionEnter2D(Collision2D colli)
    {
        if(colli.gameObject.CompareTag("Bullet"))
        {
            Animator.Play("EffectWoodBarrier");
            Destroy(gameObject, LifeTime);
            
        }
        
    }
}
