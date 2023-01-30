using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public Transform InventoryContent;
    public GameObject InventoryItem;
    public List<Item> Items = new List<Item>();

    private void Awake()
    {
        Instance = this;
    }
    public void AddItem(Item item)
    {
        Items.Add(item);
        DisPlayItemOnInventory();
        EventManager.FindHammer(item.ItemID);
    }
    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public void DisPlayItemOnInventory()
    {

        foreach (Transform Child in InventoryContent)
        {
            Destroy(Child.gameObject);
        }

        foreach (var item in Items)
        {
            
            var i = Instantiate(InventoryItem,InventoryContent);
            
            i.GetComponent<InventoryItemController>().SetItemData(item);

            
        }

    }

    

}


