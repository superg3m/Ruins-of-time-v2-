using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTools : Item
{
    [Header("ItemTools")]
    public ToolType toolType;
    public enum ToolType
    {
        weapon,
        pickaxe,
        axe,
        healthPotion,
        sword,

    }

    public override Item GetItem() { return this; }
    public override ItemTools GetTool() { return this; }
    public override ItemMiscellaneous GetMisc() { return null; }
    public override ItemConsumables GetConsumable() { return null; }
}
