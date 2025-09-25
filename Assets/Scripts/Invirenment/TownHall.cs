using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
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
            UIManager.Instance.ShowInvirenmentPanel("Ратуша", sprite);
        }
        else
        {
            UIManager.Instance.HideInvirenmentPanel();
        }
    }
}
