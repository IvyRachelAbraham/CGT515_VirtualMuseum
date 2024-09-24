using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour
{
    public string sceneToLoad; // Refernce to the scene to Load

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null) // Ensure the colliding object is the player
        {
            SceneManager.LoadScene (sceneToLoad); // Load the referenced scene
        }
    }

}
