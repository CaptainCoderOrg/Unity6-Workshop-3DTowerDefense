using UnityEngine;

public class CameraEventMaskController : MonoBehaviour
{
    [field: SerializeField]
    public LayerMask EventMask { get; private set; }

    void Awake()
    {
        Camera camera = GetComponent<Camera>();
        camera.eventMask = EventMask;
    }
}

