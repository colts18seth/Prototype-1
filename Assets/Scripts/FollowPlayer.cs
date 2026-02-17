using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public CameraController cameraController;
    //private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera position to be above and behind the player
        transform.position = player.transform.position + cameraController.offset;

        if (cameraController.firstPersonCamera.enabled) {
            transform.rotation = player.transform.rotation * Quaternion.Euler(18, 0, 0);
        }
    }
}
