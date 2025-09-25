using UnityEngine;

public class Forest : MonoBehaviour
{
    private Sprite sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseDown()
    {
        if (!UIManager.Instance.IsInvirenmentPanelActive())
        {
            UIManager.Instance.ShowInvirenmentPanel("Лес", sprite);
        }
        else
        {
            UIManager.Instance.HideInvirenmentPanel();
        }
    }
}
