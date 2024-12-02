using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    [field: SerializeField]
    public UnityEvent OnEnter { get; private set; }
    [field: SerializeField]
    public UnityEvent OnExit { get; private set; }
    [field: SerializeField]
    public UnityEvent OnClick { get; private set; }

    void OnMouseEnter()
    {
        OnEnter.Invoke();
    }

    void OnMouseExit()
    {
        OnExit.Invoke();
    }

    void OnMouseUpAsButton()
    {
        OnClick.Invoke();
    }
}

