using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip audioClip;     // Reference to the AudioClip to play


    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            if (audioSource != null && audioClip != null)
            {
                audioSource.clip = audioClip;  // Assign the audio clip
                audioSource.Pause();            // Play the audio
            }
        }
    }
}
