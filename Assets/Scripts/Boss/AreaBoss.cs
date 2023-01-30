using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaBoss : MonoBehaviour
{
    public GameObject HealtBarBoss;
    private void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.CompareTag("Player"))
        {
            GetComponentInChildren<BossController>().enabled = true;
            HealtBarBoss.SetActive(true);
        }
    }
}
