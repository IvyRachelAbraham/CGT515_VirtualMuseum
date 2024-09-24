using UnityEngine;

public class MoneyHeistInteraction : MonoBehaviour
{
    public GameObject imagePlane;   // Reference to the UI panel for the fun fact

    private void Start()
    {
        imagePlane.SetActive(false); // Start with the panel inactive
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            imagePlane.SetActive(true);  // Display the fun fact panel
        }
    }
    
}
