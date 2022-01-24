using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    [Header("Item")]
    public string itemType;
    public Sprite itemIcon;

    public abstract Item GetItem();
    public abstract ItemTools GetTool();
    public abstract ItemMiscellaneous GetMisc();
    public abstract ItemConsumables GetConsumable();

}