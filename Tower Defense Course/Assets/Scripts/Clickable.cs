using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [field: SerializeField] public UnityEvent OnClick { get; private set; }
    [field: SerializeField] public UnityEvent OnEnter { get; private set; }
    [field: SerializeField] public UnityEvent OnExit { get; private set; }
    public void OnPointerClick(PointerEventData eventData) => OnClick.Invoke();
    public void OnPointerEnter(PointerEventData eventData) => OnEnter.Invoke();
    public void OnPointerExit(PointerEventData eventData) => OnExit.Invoke();
}

