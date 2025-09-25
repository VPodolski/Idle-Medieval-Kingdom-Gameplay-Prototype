using UnityEngine;
using UnityEngine.EventSystems;

public class CloseBtn : MonoBehaviour, IPointerClickHandler
{
    public InverementPanel panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        panel.Hide();
    }
}
