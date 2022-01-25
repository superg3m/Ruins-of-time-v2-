using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMiscellaneous : Item
{
    //[Header("ItemMiscellaneous")] // Data specific to miscellaneous items

    public override Item GetItem() { return this; }
    public override ItemTools GetTool() { return null; }
    public override ItemMiscellaneous GetMisc() { return this; }
    public override ItemConsumables GetConsumable() { return null; }
}
