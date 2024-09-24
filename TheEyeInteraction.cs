using UnityEngine;

public class TheEyeInteraction : MonoBehaviour
{
    public GameObject videoPlane;   // Reference to the UI panel for the fun fact

    private void Start()
    {
        videoPlane.SetActive(false); // Start with the panel inactive
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            videoPlane.SetActive(true);  // Display the fun fact panel
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            videoPlane.SetActive(false);  // Hide the fun fact panel
        }
    }
}
