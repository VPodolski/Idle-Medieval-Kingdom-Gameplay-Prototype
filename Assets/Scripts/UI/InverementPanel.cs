using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InverementPanel : MonoBehaviour
{
    public TMP_Text Title;
    public Image Image;

    public UnityEngine.UIElements.ScrollView InvirenmentPropertyPanel;
    public GameObject InvirenmentPropertyPrefab;

    public void Show(IInvirenment invirenment, Sprite sprite)
    {
        Title.text = invirenment.Title;
        Image.sprite = sprite;

        gameObject.SetActive(true);
    }

    public void Show(ITerrainItem terrainItem, Sprite sprite)
    {
        Title.text = terrainItem.Title;
        Image.sprite = sprite;

        

        foreach (var invirenment in terrainItem.AvailableInvirenments)
        {
            //invirenment.Build();
        }

        gameObject.SetActive(true);
    }

    public void Hide()
    {
        Title.text = null;
        Image.sprite = null;

        gameObject.SetActive(false);
    }
}
