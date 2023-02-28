/*
Write a script that, when attached to a game object, 
allows the player to move the object around the scene using keyboard input. 
The object should move forward, backward, left, and right, and the movement speed 
should be adjustable in the Unity editor. The movement should be smooth and continuous, 
without any sudden stops or jumps. Additionally, the object should be prevented from 
moving outside a specified boundary area in the scene.

Input.GetAxis
Mathf.Clamp
*/

using UnityEngine;

public class MoveKeys : MonoBehaviour
{
   
    // The speed at which the object should move
    // The radius of the boundary area

    void Update()
    {
        // Get the current position of the object

        // The following calculates the new position of the object based on keyboard input
        // Store the input horizontal and vertical inputs into variables



        // calculate the vector based on the input and save in variable


        // calculate what the new position should be and store in variable


        // Keep the object within the boundary area for the x coordinates and y coordinates



        // Move the object to the new position
    }
}
