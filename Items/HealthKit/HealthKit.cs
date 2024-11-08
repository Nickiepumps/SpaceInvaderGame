using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKit : MonoBehaviour
{
    public Item itemData; // Item Data Scriptable Object
    public PlayerManager player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship")) // If item hit player, Add item to the itemSlot with itemdata from it's scriptable object
        {
            if(InventoryManager.Instance.items.Count < InventoryManager.Instance.itemSlots.Length)
            {
                InventoryManager.Instance.AddItem(itemData);                    
                Destroy(gameObject); // destroy GameObject when player hit
            }
            else
            {
                Debug.Log("Inventory Full");
            }
        }
    }
}
