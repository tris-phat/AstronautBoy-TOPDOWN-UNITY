using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    

    [Header("Player Controller")]
    [SerializeField] private float speed;
    [SerializeField] private Animator animator;

    private Rigidbody2D rd;
    private float _horizontal;
    private float _vertical;
    private bool moving;

   
    void Start()
    {

        rd = GetComponent<Rigidbody2D>();
       

    }


    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");



        Flip();
        SetAnimation();
    

    }
    private void FixedUpdate()
    {
        rd.velocity = new Vector2(_horizontal * speed, _vertical * speed);

    }

    // xoay nhân vật
    private void Flip()
    {
        if (_horizontal > 0)
        {
            transform.localScale = new Vector3(-0.4f, 0.4f, 0);
        }
        if (_horizontal < 0)
        {
            transform.localScale = new Vector3(0.4f, 0.4f, 0);
        }

    }
    // set animation
    private void SetAnimation()
    {



        if (_horizontal > 0.1f || _horizontal < -0.1f)
        {
            moving = true;

        }
        else if (_vertical > 0.1f || _vertical < -0.1f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        if (moving)
        {
            animator.SetFloat("Horizontal", _horizontal);
            animator.SetFloat("Vertical", _vertical);

        }
        animator.SetBool("Moving", moving);


    }

    









}