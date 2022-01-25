using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemConsumables : Item
{
    [Header("ItemConsumables")]
    public float healthAdded;

    public override Item GetItem() { return this; }
    public override ItemTools GetTool() { return null; }
    public override ItemMiscellaneous GetMisc() { return null; }
    public override ItemConsumables GetConsumable() { return this; }
}
