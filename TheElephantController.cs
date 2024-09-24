using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheElephantController : MonoBehaviour
{
    // Assign these in the Inspector
    public GameObject elephantL;     // GameObject for the left elephant
    public GameObject elephantR;     // GameObject for the right elephant

    public float moveSpeed = 1f;        // Controls how fast the elephants move up and down.
    public float moveHeight = 0.5f;     // Specifies the maximum height for the up-and-down movement.

    private Vector3 initialPosL;        // Store initial position of Elephant_L
    private Vector3 initialPosR;        // Store initial position of Elephant_R

    void Start()
    {
        // Store the initial positions of the moving objects to ensure the movement is relative to where they start in the scene.
        initialPosL = elephantL.transform.position; // Elephant_L
        initialPosR = elephantR.transform.position; // Elephant_R
    }

    void Update()
    {
        MoveElephants(); // Called every frame to handle continuous movement
    }

    void MoveElephants()
    {
        // Move elephantL and elephantR up and down
        // Uses a sine wave (Mathf.Sin) to calculate a smooth oscillating vertical motion.
        // Time.time ensures the movement changes over time, and multiplying it by moveSpeed controls the speed of the oscillation.
        // The new Y positions for both elephants are calculated by adding the sine wave value to their initial Y positions. This makes the elephants move up and down smoothly.
        float newY = Mathf.Sin(Time.time * moveSpeed) * moveHeight;

        // Update positions based on the sine wave
        elephantL.transform.position = new Vector3(initialPosL.x, initialPosL.y + newY, initialPosL.z);
        elephantR.transform.position = new Vector3(initialPosR.x, initialPosR.y + newY, initialPosR.z);
    }
}
