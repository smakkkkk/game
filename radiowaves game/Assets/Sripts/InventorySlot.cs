using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item _currentItem;
    Image _icon;
    Button _button;
    private void Start()
    {
        _icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SlotClicked);
    }

    public void PutInSlot(Item item)
    {
        _icon.sprite = item._icon;
        _currentItem = item;
        _icon.enabled = true;
    }

    void SlotClicked()
    {
        if(_currentItem != null)
        ItemInfo._instance.Open(_currentItem);
    }
}
