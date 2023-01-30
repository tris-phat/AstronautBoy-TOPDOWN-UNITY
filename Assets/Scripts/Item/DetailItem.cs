using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class DetailItem : MonoBehaviour
{
    public static DetailItem Instance;

    public Image itemIcon;
    public TMP_Text itemName;
    public TMP_Text id;
    public TMP_Text Desription;

    private void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }
    public void DisplayDetailItem(Item item)
    {
        itemIcon.sprite = item.ItemIcon;
        itemName.text = item.ItemName;
        id.text = item.ItemID.ToString("ID:" + item.ItemID);
        Desription.text = item.Desription;
        gameObject.SetActive(true);
    }
    public void CloseDetailItem()
    {
        gameObject.SetActive(false);
    }

}
