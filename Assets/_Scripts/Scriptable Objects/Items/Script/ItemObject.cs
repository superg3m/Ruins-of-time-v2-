using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable,
    Gear,
    Default,
}
public abstract class ItemObject: ScriptableObject
{
    public GameObject prefab;
    public ItemType itemType;
    [TextArea(15, 20)]
    public string description;
}
