/*
Write a script that, when attached to a game object, allows the player to move the object 
around the scene using keyboard input. The object should move forward, backward, left, 
and right, and the movement speed should be adjustable in the Unity editor. The movement 
should be smooth and continuous, without any sudden stops or jumps. Additionally, 
the object should be prevented from moving outside a specified boundary area in the scene.
*/

using UnityEngine;
// reference Text Mesh Pro

public class SpawnObject : MonoBehaviour
{

    // store the time between spawns
  
    // store the maximum height they can reach

    // store which prefab we'll be spawning

    // store a reference to the TMP text


    // store the score in a variable

    
    void Start()
    {
        // start repeatedly calling the method that will do the spawning
        // at the rate specified between spawns

    }

    void Update(){

        // update the text of the score

    }
    
    // a method that does all the spawning


        // store the position to spawn at wich will be at random range for x and z
        
        // instantiate the object and store a reference to it
        
        // store reference to the Renderer of the new object
        

        // make the the renderer is not null
        
        
            // set the renderer material color to a new random color
            
        

        // add a rigidbody to the component and store a reference to it
        

        // add force to the rigidbody, up and using ForceMode Impulse
        

        // invoke the method that increses score when maxheight is reached
        
        // destroy the object when maxheight is reached
        
    

    // short method that increments the score
    
    
        
    

}
