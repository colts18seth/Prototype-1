using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera position to be above and behind the player
        transform.position = player.transform.position + offset;
    }
}
