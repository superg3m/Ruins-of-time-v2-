using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Defult Object", menuName = "Inventory System/Items/Default")]
public class DefultObject : ItemObject
{
    public void Awake()
    {
        itemType = ItemType.Default;
    }
}
