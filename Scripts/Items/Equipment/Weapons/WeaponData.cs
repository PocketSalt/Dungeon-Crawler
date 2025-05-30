using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponData : EquipableItem, IWeapon
{
    public 

    public virtual void ApplyStatModifiers(EntityAttributes attributes) { }
    public virtual void RemoveStatModifiers(EntityAttributes attributes) { }
}
