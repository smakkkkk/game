using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public static ItemInfo _instance;
    private Button _exitButton;
    private Image _backGround;
    private Image _icon;
    private Text _title;
    private Text _description;

    private void Start()
    {
        _instance = this;
        _backGround = GetComponent<Image>();
        _title = transform.GetChild(0).GetComponent<Text>();
        _description = transform.GetChild(1).GetComponent<Text>();
        _icon = transform.GetChild(2).GetComponent<Image>();
        _exitButton = transform.GetChild(3).GetComponent<Button>();

        _exitButton.onClick.AddListener(Close);
    }

    public void ChangeInfo(Item item)
    {
        _title.text = item.name;
        _description.text = item._description;
        _icon.sprite = item._icon;
    }

    public void Open(Item item)
    {
        ChangeInfo(item);
        gameObject.transform.localScale = Vector2.one;
    }

    public void Close()
    {
        gameObject.transform.localScale = Vector2.zero;
    }
}
