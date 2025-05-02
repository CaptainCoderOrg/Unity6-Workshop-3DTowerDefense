using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler
{
    [field: SerializeField] public UnityEvent OnClick { get; private set; }
    public void OnPointerClick(PointerEventData eventData) => OnClick.Invoke();
}

