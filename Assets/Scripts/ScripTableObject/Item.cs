using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScripTableObject/Item")] 
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite ItemIcon;
    public int ItemID;
    public string Desription;

}
