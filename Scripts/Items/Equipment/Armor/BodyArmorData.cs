using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BodyGear", menuName = "Items/Armor/Bodygear")]
public class BodyArmorData : WeaponData
{
    public override EquipmentSlot Slot => EquipmentSlot.Body;
}