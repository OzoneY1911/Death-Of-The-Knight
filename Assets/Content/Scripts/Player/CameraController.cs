using UnityEngine;

public class CameraController : SingletonMono<CameraController>
{
    private Camera _camera;
    [SerializeField] private Transform target;

    protected override void Awake()
    {
        base.Awake();

        _camera = GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(target.position.x, target.position.y, _camera.transform.position.z);
    }
}