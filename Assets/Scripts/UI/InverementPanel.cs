using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InverementPanel : MonoBehaviour
{
    public TMP_Text Title;
    public Image Image;

    public Transform InvirenmentPropertyPanel;
    public GameObject InvirenmentPropertyPrefab;
    public Transform PropertyPanelContent;

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

        foreach (Transform child in PropertyPanelContent)
        {
            Destroy(child.gameObject);
        }

        foreach (IInvirenment invirenment in terrainItem.AvailableInvirenments)
        {
            GameObject property = Instantiate(InvirenmentPropertyPrefab, PropertyPanelContent);

            property.GetComponentInChildren<TMP_Text>().text = invirenment.Title;
        }

        InvirenmentPropertyPanel.GetComponentInChildren<Scrollbar>().value = 1.35f;

        gameObject.SetActive(true);
    }

    public void Hide()
    {
        Title.text = null;
        Image.sprite = null;

        gameObject.SetActive(false);
    }
}
