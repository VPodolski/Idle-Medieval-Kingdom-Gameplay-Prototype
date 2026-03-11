using System;
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
            invirenment.ParentTerrainItem = terrainItem;
            GameObject property = Instantiate(InvirenmentPropertyPrefab, PropertyPanelContent);

            property.GetComponentInChildren<TMP_Text>().text = invirenment.Title;
            property.transform.Find("ActionBtn").GetComponent<Button>().onClick.AddListener(invirenment.Build);

            Sprite invirenmentSprite = Resources.Load<Sprite>(invirenment.PathToSprite);
            property.transform.Find("Sprite").GetComponent<Image>().sprite = invirenmentSprite;
        }

        InvirenmentPropertyPanel.GetComponentInChildren<Scrollbar>().value = 1.35f;

        gameObject.SetActive(true);
    }

    public void Hide()
    {
        Title.text = null;
        Image.sprite = null;

        foreach (Transform child in PropertyPanelContent)
        {
            Destroy(child.gameObject);
        }

        gameObject.SetActive(false);
    }
}
