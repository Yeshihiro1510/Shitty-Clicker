using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Button clickerButton;
    public TMP_Text clicksText;

    private int Clicks
    {
        get => _clicks;
        set
        {
            if (value == 0) return;
            _clicks = value;
            clicksText.text = _clicks.ToString();
        }
    }
    private int _clicks;

    private void Start()
    {
        clickerButton.onClick.AddListener(() => Clicks++);
    }
}