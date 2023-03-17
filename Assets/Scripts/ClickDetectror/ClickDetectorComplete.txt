
/*
Suppose you have a simple 3D game in Unity, and you want to detect when the player clicks on a specific object in the scene using a raycast. Write a script in C# that accomplishes this task. Assume that the object you want to detect is tagged with the tag "TargetObject".
*/


using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    void Update()
    {
        // when the mousebutton is down
        if (Input.GetMouseButtonDown(0))
        {
            // create a ray that goes from camera to mouseposition
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // create a raycast hit
            RaycastHit hit;

            // check if the raycast hits something and that something has the tag "TargetObject"
            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("TargetObject"))
            {
                // Log out a message that it was hit
                Debug.Log("Target object clicked!");
            }
        }
    }
}

