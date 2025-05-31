using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Armor", menuName = "Items/Gear/Armor")]
public class ArmorData : EquipableItem
{
    public override EquipmentSlot Slot => EquipmentSlot.Head;

    public ArmorType type;
}

