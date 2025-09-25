using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class InverementPanel : MonoBehaviour
{
    public TMP_Text Title;
    public Image Image;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show(string title, Sprite sprite)
    {
        Title.text = title;
        Image.sprite = sprite;

        gameObject.SetActive(true);
    }

    public void Hide()
    {
        Title.text = null;
        Image.sprite = null;

        gameObject.SetActive(false);
    }
}
