using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemContainer;
    private Transform itemSlot;
    
    private void Awake()
    {
        itemContainer = transform.Find("ItemContainer");
        itemSlot = itemContainer.Find("ItemSlot");
    }
    public void SetInventory(Inventory inventroy)
    {
        this.inventory = inventroy;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        float x = -1.9f;
        float y = 1.9f;
        float itemSlotCellSize = 20f;
        foreach (Item item in inventory.GetItemList())
        {
            Debug.Log("Item container: " + itemContainer);
            Debug.Log("Item Slot: " + itemSlot);
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, itemContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x+=1.26f;
            if (x > 2.5)
            {
                x = -1.9f;
                y-= 1.25f;
            }
        }
    }
}
