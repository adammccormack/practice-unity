using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // We need to set a reference to the player, to set camera position to player.
    // so we create a variable to store this reference.

    // Transform references Transform component in Unity.
    // Then in Unity we drag player into this new slot we created.
    // Now everytime we write player in this script, it will refer to the player
    // object.

    public Transform player;
    public Vector3 offset;
    // Change default camera position around player.
    // Use Vector3 as it takes 3 floats so we can offset camera to x y z position values.
    // We can now edit in Unity.



    // Update is called once per frame
    // We want to have camera snap to player position each frame, so we put the script
    // in the update method.
    // Debug.Log(player.position); to see in the console.

    void Update()

    {   // transform lowercase, refers to transform of current object (camera)
        // when we type transform.position. Then we set it to player position.
        // So now the camera object position will be set to player position every frame.

        transform.position = player.position + offset;

    }
}
