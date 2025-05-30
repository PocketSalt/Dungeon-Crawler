using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEquipment : MonoBehaviour
{
    public EquipableItem equippedItem;

    private void Start()
    {
        Debug.Log($"Equipped: {equippedItem.ItemName} in slot {equippedItem.Slot}");
    }
}
