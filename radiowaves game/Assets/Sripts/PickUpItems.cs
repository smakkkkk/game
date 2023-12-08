using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public Item _item;
    private GameObject _itemObject;

    private void Start()
    {
        _itemObject = gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("Player")){
            gameObject.SetActive(false);
            Inventory._instance.PutInEmptySlot(_item);
       }
    }
}

