using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script controls the playback of an audio clip and switches between an image and a video display based on the audio's play state.
public class VoiceOverScript : MonoBehaviour
{
    // AudioSource that will play the voice-over or audio file
    public AudioSource audioToPlay;

    // GameObject references for the image and video that will be shown/hidden during the event
    public GameObject image;
    public GameObject Video;

    // A flag to determine if the event (audio and visual display changes) is currently active
    private bool EventActive = false;

    // Start is called before the first frame update. This method is not doing anything right now but is kept for future initialization if needed.
    void Start()
    {

    }

    // Update is called once per frame. It checks whether the event is active and controls the switching between the image and video based on the audio playback state.
    void Update()
    {
        // If the event is active, check if the audio has finished playing
        if (EventActive)
        {
            // When the audio is no longer playing
            if (!audioToPlay.isPlaying)
            {
                // Disable the image object and activate the video object
                image.SetActive(false);
                Video.SetActive(true);

                // Set the event flag to false since the process has completed
                EventActive = false;
            }
        }
    }

    // Public method to trigger the image display and start the event sequence
    public void EnableImage()
    {
        // Only proceed if the event is not already active
        if (!EventActive)
        {
            // Set the event flag to true, starting the event
            EventActive = true;

            // Activate the image and ensure the video is hidden
            image.SetActive(true);
            Video.SetActive(false);
        }
    }
}
