using UnityEngine;

/// <summary>
/// Item Type List:
/// 0 - Weapon
/// 1 - Armor
/// 2 - Consumable
/// 3 - Material
/// 4 - Quest Item
/// 
/// Equipment Part List:
/// 0 - Head
/// 1 - Body
/// 2 - Legs
/// 3 - Feet
/// 4 - Hand
/// </summary>

public enum ItemType
{
    Weapon = 0,
    Armor = 1,
    Consumable = 2,
    Material = 3,
    QuestItem = 4,
}

public enum EquipmentPart
{
    Head = 0,
    Body = 1,
    Legs = 2,
    Feet = 3,
    Hand = 4
}

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObject/Create New Item")]
public class ScriptableItems : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public string itemId;
    public Sprite icon;
    public ItemType type;
}

[CreateAssetMenu(fileName = "new Equipment", menuName = "ScriptableObject/Create New Equipment")]
public class ScriptableEquipment : ScriptableItems
{
    public float value;
    public float attackSpeed;
    public float knockbackAttack;
    public float knockbackDefense;
    public EquipmentPart part;
    public string DisplayStat => type switch
    {
        ItemType.Weapon => $"공격력 : {value}",
        ItemType.Armor => $"방어력 : {value}",
        _ => null
    };
}