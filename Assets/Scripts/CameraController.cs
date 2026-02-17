using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;
    public Vector3 offset;

    public void ThirdPersonView() {
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = true;
        offset = new Vector3(0, 5, -7);
    }

    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
        offset = new Vector3(0, 2.5f, 0.5f);
    }

    void Start()
    {
        ThirdPersonView();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.V)) {
            if (firstPersonCamera.enabled) {
                ThirdPersonView();
            } else {
                ShowFirstPersonView();
            }
        }
    }
}
