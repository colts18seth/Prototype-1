using UnityEngine;

public class PropellerSpin : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // spin the propeller by rotating it around the x-axis
        transform.Rotate(Vector3.forward * Time.deltaTime * 1000);
    }
}
