using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterEquipment : MonoBehaviour
{
    const int TotalEquipment = 4;
    public List<EquipableItem> equipment = new List<EquipableItem>(TotalEquipment);
    public GameObject thisGO;

    private EntityAttributes stats;

    private void Start()
    {
        stats = thisGO.GetComponent<EntityAttributes>();

        printAttributes(stats);
        for (int i = 0; i < TotalEquipment; i++)
        {
            Debug.Log($"Equipped: {equipment[i].ItemName} in slot {equipment[i].Slot}");
            equipment[i].ApplyStatModifier(stats);
        }
        printAttributes(stats);
        
    }

    private void printAttributes(EntityAttributes stats)
    {
        Debug.Log($"P Attack: {stats.pStrength}\nP Defense: {stats.pDefense}\nP Speed: {stats.pSpeed}\nP Accuracy: {stats.pAccuracy}");
    }
}
