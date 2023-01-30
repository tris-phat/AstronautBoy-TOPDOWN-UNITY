using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProfile : MonoBehaviour
{
    [SerializeField] private HealthBar healthbar;
    
    [SerializeField] private int MaxHP;
    private int _hp;

    private void Start()
    {
        _hp = MaxHP;
        healthbar.SetMaxHP(MaxHP);
        healthbar.SetHP(_hp);
    }
    public void TakeDamage(int Damage)
    {
        _hp -= Damage;
        healthbar.SetHP(_hp);
        if(_hp == 0)
        {
            
            gameObject.GetComponent<BossController>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            Destroy(gameObject, 1f);
            EventManager.DestroyBoss();
        }
    }
}
