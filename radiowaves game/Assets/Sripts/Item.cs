using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]


public class Item : ScriptableObject
{
    [Header("��������������")]
    public string _name = " ";
    public string _description = "��������";
    public Sprite _icon = null;
}
