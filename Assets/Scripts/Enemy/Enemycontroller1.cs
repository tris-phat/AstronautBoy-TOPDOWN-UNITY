using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller1 : MonoBehaviour
{
    [Header("Animation")]
    [SerializeField] private Animator Animator;

    [SerializeField] private float SpeedMove;

    [Header("Attack")]
    [SerializeField] private int Damage;

    [SerializeField] private float AttackRange;
    [SerializeField] private Transform AttackPoint;
    [SerializeField] private LayerMask LayerMask;


   

    private GameObject Player;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        
    
        
            Animator.SetBool("Moving", true);
            FindPlayer();
            LookAtPlayer();
            AttackAnim();


    }

    void FindPlayer()
    {
        Vector2 dir = Player.transform.position - gameObject.transform.position;
        dir = dir.normalized;
        _rb.velocity = dir * SpeedMove * Time.deltaTime;


    }
    void LookAtPlayer()
    {
        if (Player.transform.position.x < transform.position.x)
        {
            transform.localScale = Vector3.one;
        }
        if (Player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void AttackAnim()
    {



        if (Vector3.Distance(Player.transform.position, transform.position) <= AttackRange)
        {

            Animator.SetBool("attack", true);

        }
        else

        {
            Animator.SetBool("attack", false);
        }

    }
    void Attack()
    {
        Collider2D Colli = Physics2D.OverlapCircle(AttackPoint.transform.position, AttackRange, LayerMask);
        if (Colli != null)
        {
            Colli.GetComponent<PlayerProfile>().TakeDamage(Damage);
            
            
        }
        
       
           

    }
    private void OnDrawGizmosSelected()
    {


        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}
