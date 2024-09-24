using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobsterInteraction : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component that will play the audio clip

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider has a Rigidbody, or you can change this check to whatever is relevant
        if (other.attachedRigidbody != null)
        {
            // Check if the audioSource is not null and the audio is not already playing
            if (audioSource != null && !audioSource.isPlaying)
            {
                // Play the audio clip
                audioSource.Play();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the AudioSource is attached to the object, if not, get it
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
