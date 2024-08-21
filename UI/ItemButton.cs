using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public int buttonID; // Button ID Number
    private Item thisItem; // Item Object
    private Item GetThisItem() // Get scriptable object data
    {
        for (int i = 0; i < InventoryManager.Instance.items.Count; i++)
        {
            if (buttonID == i)
            {
                thisItem = InventoryManager.Instance.items[i];      
            }
        }
        return thisItem;
    }
    public void ClickItem() // Call Inventory Manager to use "UseItem" function and use "GetThisItem" function
                            // from this script as an input
    {
        InventoryManager.Instance.UseItem(GetThisItem());
    }
}
