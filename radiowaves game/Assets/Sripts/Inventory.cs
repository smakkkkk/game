using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory _instance;
    private InventorySlot[] _inventorySlots = new InventorySlot[10];
    public Transform _parentSlot;
    bool _isOpened;

    public void Start()
    {
        _instance = this;
        for(int i = 0; i < _inventorySlots.Length; i++)
        {
            _inventorySlots[i] = _parentSlot.GetChild(i).GetComponent<InventorySlot>();
        }
    }

    public void PutInEmptySlot(Item item)
    {
        for(int i = 0; i < _inventorySlots.Length; i++)
        {
            if (_inventorySlots[i]._currentItem == null)
            {
                _inventorySlots[i].PutInSlot(item);
                return;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        { 
            if (_isOpened)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }

    void Open()
    {
        gameObject.transform.localScale = Vector2.one;
        _isOpened = true;
    }

    void Close()
    {
        gameObject.transform.localScale = Vector2.zero;
        _isOpened = false;
    }
}

