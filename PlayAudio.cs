using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip audioClip;     // Reference to the AudioClip to play

    private void Start()
    {
        // Ensure the AudioSource is assigned, and disable play on awake if it's enabled
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        audioSource.playOnAwake = false;  // Make sure the clip doesn't play automatically
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            if (audioSource != null && audioClip != null)
            {
                audioSource.clip = audioClip;  // Assign the audio clip
                audioSource.Play();            // Play the audio
            }
        }
    }
}
