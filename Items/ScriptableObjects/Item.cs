using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName = "New Item")]
public class Item : ScriptableObject
{
    public string itemName; // Health kit Name
    public string itemDes; // Health Kit Description
    public int healAmount; // Healing Amount
    public Sprite itemSprite; // Health kit Sprite
}
