using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    // This is a Unity function that deals with collisions

    // We can now add this collission script to any object we want as long
    // as it has a rigidBody and Collider.
    // confirming that the object is hitting, in this case the player is hitting the ground so it should log.

    // To make player stop moving when colliding, we can go in through this script and turn of the PlayerMovement.cs script, we do this buy having a reference to the
    // player movement script.

    public PlayerMovement movement;

    // first Collission parameter lets Unity know we want to gather info about the collison, and then we need to give that info a name 'collisionInfo'
     
    public void OnCollisionEnter(Collision collisionInfo)
    {
        // Then we print to the console the collisionInfo and use . notation to access each available info at each level, in this case the name of the collider, so we'll see
        // ground first when it starts then Obstacle
        // This debug gives us info about the collider we hit, then we can choose what to show, in this case name of whatever we hit will show.
        //Debug.Log(collisionInfo.collider.name);

        // If we want it to only display when it hits the object we name, i.e. "Obstacle". Although this is not the best way to go about it as if you have lots of objects
        // the computer will slow down looking for them, and also if you rename the object your code won't work, a better way is to use TAGS.

        //if (collisionInfo.collider.name == "Obstacle")
        //{
        //    Debug.Log("We hit it!");
        //}

        //TAGS
        // Used to group objects together, click on object then Add Tag and click on the + and name it.  Then select the obstacle object and change the tag to the one we
        // just made. Now we can rewrite code above.
        // This is much better as we can create a bunch of different objects, and as long as they have the same tag we can configure them how we want.


        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Mother Fucking HIT");
        }
    }

}
