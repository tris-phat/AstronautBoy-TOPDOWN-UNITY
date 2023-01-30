using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItemController : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public static InventoryItemController Instance;
    private Item _itemdata;
    public Image itemIcon;
    private bool Display = true;

    private void Awake()
    {
        Instance = this;
    }
    

    public void SetItemData(Item data)
    {
        _itemdata = data;
       
        itemIcon.sprite = data.ItemIcon;
 
    }
    private void RemoveItem()
    {
        InventoryManager.Instance.RemoveItem(_itemdata);
    }

   

    public void OnPointerEnter(PointerEventData eventData)
    {
        DetailItem.Instance.DisplayDetailItem(_itemdata);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        DetailItem.Instance.CloseDetailItem();
    }

}
