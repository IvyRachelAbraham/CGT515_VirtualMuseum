using UnityEngine;

public class RotateDome : MonoBehaviour
{
    public float rotationSpeed = 10f;  // Speed of rotation
    private Vector3 domeCenter;        // Center of the collider

    private void Start()
    {
        // Get the collider component and calculate the bounds' center
        SphereCollider domeCollider = GetComponent<SphereCollider>();
        if (domeCollider != null)
        {
            domeCenter = domeCollider.bounds.center;
        }
    }

    void Update()
    {
        // Rotate the dome around the Y-axis, using the collider's center as the pivot point
        transform.RotateAround(domeCenter, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
