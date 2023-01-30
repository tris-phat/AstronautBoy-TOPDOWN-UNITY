using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    [Header("Hit Effet")]
    [SerializeField] private GameObject HitEffect;
    [SerializeField] private float LifeTime;
    public int Damage;


   
    // kiểm tra va chạm với Object có tag Enemy
   public void OnCollisionEnter2D(Collision2D coli)
   {
        
      if (coli.gameObject.CompareTag("Enemy") )
      {
          coli.gameObject.GetComponent<EnemyProfile>().TakeDamage(Damage);
          
      }
        if (coli.gameObject.CompareTag("Boss"))
        {
            coli.gameObject.GetComponent<BossProfile>().TakeDamage(Damage);
        }

       // khi va chạm bất kì Collider sẽ tạo ra HitEffect và tự destroy
       GameObject Effect = Instantiate(HitEffect, transform.position, transform.rotation);
       Destroy(Effect, LifeTime);

        Destroy(gameObject);


   }
}
