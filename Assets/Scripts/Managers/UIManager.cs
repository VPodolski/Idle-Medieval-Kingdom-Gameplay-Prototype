using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public InverementPanel inverementPanel;
    public ResourcesPanel resourcesPanel;

    private void Awake()
    {
        Instance = this;
        inverementPanel.gameObject.SetActive(false);
    }

    public bool IsInvirenmentPanelActive()
    {
        return inverementPanel.isActiveAndEnabled;
    }

    public void ShowInvirenmentPanel(ITerrainItem terrainItem, Sprite sprite)
    {
        inverementPanel.Show(terrainItem, sprite);
    }

    public void ShowInvirenmentPanel(IInvirenment invirenment, Sprite sprite)
    {
        inverementPanel.Show(invirenment, sprite);
    }

    public void HideInvirenmentPanel()
    {
        inverementPanel.Hide();
    }

    public void UpdateResources(decimal wood, decimal food, decimal rock, decimal peasants)
    {
        resourcesPanel.UpdateResources(wood.ToString(), food.ToString(), rock.ToString(), peasants.ToString());
    }


}
