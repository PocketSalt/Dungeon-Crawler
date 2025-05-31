using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipableItem : ScriptableObject, IEquipable
{
    [SerializeField] private string item_name;

    public int p_strength_mod;
    public int p_defense_mod;
    public int p_speed_mod;
    public int p_accuracy_mod;

    public int ma_strength_mod;
    public int ma_defense_mod;
    public int ma_speed_mod;
    public int ma_accuracy_mod;

    public string ItemName => item_name;
    public abstract EquipmentSlot Slot { get; }

    public virtual void ApplyStatModifier(EntityAttributes stats)
    {
        stats.pStrength += p_strength_mod;
        stats.pDefense += p_defense_mod;
        stats.pSpeed += p_speed_mod;
        stats.pAccuracy += p_accuracy_mod;

        stats.mStrength += ma_strength_mod;
        stats.mDefense += ma_defense_mod;
        stats.mSpeed += ma_speed_mod;
        stats.mAccuracy += ma_accuracy_mod;
    }

    public virtual void RemoveStatModifier(EntityAttributes stats)
    {
        stats.pStrength -= p_strength_mod;
        stats.pDefense -= p_defense_mod;
        stats.pSpeed -= p_speed_mod;
        stats.pAccuracy -= p_accuracy_mod;

        stats.mStrength -= ma_strength_mod;
        stats.mDefense -= ma_defense_mod;
        stats.mSpeed -= ma_speed_mod;
        stats.mAccuracy -= ma_accuracy_mod;
    }
}