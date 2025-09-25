using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public InverementPanel inverementPanel;

    private void Awake()
    {
        Instance = this;
        inverementPanel.gameObject.SetActive(false);
    }

    public bool IsInvirenmentPanelActive()
    {
        return inverementPanel.isActiveAndEnabled;
    }

    public void ShowInvirenmentPanel(string title, Sprite sprite)
    {
        inverementPanel.Show(title, sprite);
    }

    public void HideInvirenmentPanel()
    {
        inverementPanel.Hide();
    }

}
