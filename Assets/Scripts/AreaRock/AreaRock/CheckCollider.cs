using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    [SerializeField] private GameObject ButtonF;

    private void Awake()
    {
        ButtonF.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            ButtonF.SetActive(true);
            GameManager.Instance.SetAnimSpecial(ButtonF);
        }

       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ButtonF.SetActive(false);
    }
}
