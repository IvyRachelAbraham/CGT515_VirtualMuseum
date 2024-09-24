using UnityEngine;

public class CanvasFollowCamera : MonoBehaviour
{
    public Transform cameraTransform;   // Reference to the Camera (Main Camera or VR camera)
    public Vector3 offset = new Vector3(0f, 0f, 2f); // Offset to keep the canvas in front of the camera

    void Update()
    {
        // Make the canvas follow the camera's position
        transform.position = cameraTransform.position + cameraTransform.forward * offset.z + cameraTransform.up * offset.y + cameraTransform.right * offset.x;

        // Make the canvas face the camera
        transform.rotation = Quaternion.LookRotation(transform.position - cameraTransform.position);
    }
}
