using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]


public class Item : ScriptableObject
{
    [Header("Характеристики")]
    public string _name = " ";
    public string _description = "Описание";
    public Sprite _icon = null;
}
