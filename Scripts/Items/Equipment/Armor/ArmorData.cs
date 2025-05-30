using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmorData : EquipableItem, IArmor
{
    [SerializeField] protected int defense;

    public virtual int Defense => defense;
}

