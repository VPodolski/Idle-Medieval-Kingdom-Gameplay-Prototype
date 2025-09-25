using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Sprite sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
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
