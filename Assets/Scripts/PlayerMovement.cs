using UnityEngine;

// In here we keep track of player position and the forces we want to add when we want him to move.


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardsForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // use FixedUpdate instead of Update
    void FixedUpdate()
    {
        // Constant forward force
        rb.AddForce(0, 0, forwardsForce * Time.deltaTime);

        // Add a forward force
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardsForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        { 
            rb.AddForce(0, 0, -forwardsForce * Time.deltaTime);
        }

        // Fundamental thing for player movement is 'if' statements
        // everything in the code block is executed only when player
        // presses 'd'.



        if (Input.GetKey("d"))
        {
            // Only executed if condition is met


            // the movement left and right feels sluggish as force builds up over time, and then to compensate and change direction it takes time to build up the force.
            // So we use ForceMode.VelocityChange to specify in which way we should add a force. We use VelocityChange, the default is force.
            // Note when in the editor we have to reduce the force because it is more sensitive now. 
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            
            // to make it go the opposite direction on x axis we use '-'
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

// This code could be improved for player input, the better way to handle
// player input for smoother movement and supporting alternative keys or a
// controller unity has better ways so look into it.

// Also we're currently checking for input inside void FixedUpdate ().
// and it's fine for things like movement in this e.g. as its fairly smooth,
// it's definitely not good for stuff like jumping or other one off events.
// The reason is that input is updated in the Update method and if FixedUpdate()
// runs slower you might have a situation where you miss some player input.

// To avoid this, check for input in the update method, then store that in
// a variable near top of class, which could be two booleans that set to true
// if the key is pressed and false if the key is released, and then check if those
// variables are true or false down lower to add a force.   
 