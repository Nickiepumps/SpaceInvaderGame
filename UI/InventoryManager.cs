using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public PlayerManager playerManager; // Player HP Data
    public List<Item> items; // Item Health kit Data
    public GameObject[] itemSlots; // Item Slots

    public static InventoryManager Instance;

    #region Singleton
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    private void Start()
    {
        DisplayItem();
    }
    public void DisplayItem() // Display Item Sprite image in each element of the Item list
    {
        for(int i = 0; i < items.Count; i++)
        {
            itemSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            itemSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;
        }
        for(int i = 0; i < itemSlots.Length; i++)
        {
            if(i < items.Count)
            {
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;
            }
            else
            {
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
            }
        }
    }
    public void AddItem(Item item)
    {
        if(items.Count < itemSlots.Length) // If there is an empty slot or not full, Add Item and Assign Slot ID Number to that Item
        {
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }
        DisplayItem();
    }
    public void DeleteItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            Debug.Log("No Item");
        }
        DisplayItem();
    }
    public void UseItem(Item item)
    {
        for (int i = 0; i < items.Count; i++) // Loop each element to see if item in that element is same type as input item
        {
            if (items[i] == item) // if item in that element is same type as input item
            {
                if (playerManager.playerCurrentHP < playerManager.playerMaxHP) // Heal Player when current HP < Max HP
                {
                    playerManager.playerCurrentHP += items[i].healAmount;
                    DeleteItem(items[i]);
                }
                else // Do not delete the clicked Item when Player HP is full
                {
                    Debug.Log("HP Full");
                }
            }            
        }
    }
}
