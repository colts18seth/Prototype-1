using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public string inputID;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey)) { 
            mainCamera.enabled = !mainCamera.enabled; 
            hoodCamera.enabled = !hoodCamera.enabled; 
        }
    }
}
