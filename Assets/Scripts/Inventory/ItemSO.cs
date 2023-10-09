using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu (fileName = "New Item", menuName = "Survival Game/Inventory/New Item")]
public class ItemSO : ScriptableObject
{
    public enum ItemType { Generic, Consumable, Weapon, MeleeWeapon}

    [Header("General")]
    public ItemType itemType;
    public Sprite icon;
    public string itemName;
    public string description = "New Item Description";

    public bool isStackable;
    public int maxStack = 1;

    [Header("Weapon")]
    public float damage = 20f;
    public float range = 200f;
    public int magSize = 30;
    public float fireRate = 0.1f;

    [Header("Food")]
    public float nutrition;

    [Space]
    public float horizontalRecoil;
    public float minVerticalRecoil;
    public float maxVerticalRecoil;

    [Space]
    [Space]
    [Space]
    public AudioClip shootSound;
    public AudioClip reloadSound;
    public AudioClip takeoutSound;
    public AudioClip emptySound;

    [Header("Consumable")]
    public float healthChange = 0f;
    public float hungerChange = 0f;
    public float thirstChange = 0f;
}


