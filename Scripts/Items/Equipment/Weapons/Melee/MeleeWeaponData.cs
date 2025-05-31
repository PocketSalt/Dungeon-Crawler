using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponData : WeaponData, IWeapon
{
    public override EquipmentSlot Slot => EquipmentSlot.Weapon;

    public void NormalAttack()
    {
        Debug.Log("Normal Attack!");
    }

    public void HeavyAttack()
    {
        Debug.Log("Heavy Attack!");
    }

    public void AoEAttack()
    {
        Debug.Log("AoE Attack!");
    }
}