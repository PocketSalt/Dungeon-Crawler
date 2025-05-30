using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipableItem : ScriptableObject, IEquipable
{
    [SerializeField] private string itemName;

    public string ItemName => itemName;
    
    public abstract EquipmentSlot Slot { get; }
}