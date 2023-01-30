using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public Item item;

    private void OnTriggerEnter2D(Collider2D colli)
    {
        if(!colli.gameObject.CompareTag("Player"))
        {
            return;
        }
        Pickupitem();
    }

    private void Pickupitem()
    {
        InventoryManager.Instance.AddItem(item);
        Destroy(gameObject);
    }

}
