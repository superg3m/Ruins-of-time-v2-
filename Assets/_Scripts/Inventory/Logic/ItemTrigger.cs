using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    public InventoryObject inventory;
    public PlayerInput playerInput;
    public void OnTriggerEnter2D(Collider2D other)
    {
        var item = other.GetComponent<Item>();
        if (item && inventory.Container.Count < 56)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("You are carrying to much!");
        }
    }
    private void OnApplicationQuit()
    {
        //inventory.Container.Clear();
    }
}
