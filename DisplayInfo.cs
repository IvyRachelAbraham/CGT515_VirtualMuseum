using UnityEngine;

public class FunFactDisplay : MonoBehaviour
{
    public GameObject funFactPanel;   // Reference to the UI panel for the fun fact

    private void Start()
    {
        funFactPanel.SetActive(false); // Start with the panel inactive
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            funFactPanel.SetActive(true);  // Display the fun fact panel
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            funFactPanel.SetActive(false);  // Hide the fun fact panel
        }
    }
}
