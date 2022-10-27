using UnityEngine;
using UnityEngine.UI;

// need to use UnityEngine.UI when writing code for UI. 

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // this is how many units our player has moved on the z-axis
        //Debug.Log(player.position.z);

        // now we can access all the different parts of our text with dot notation including font size etc.
        // we need to convert the player position to string to have it work in text, and we set it to 0 to show only whole numbers. 
        scoreText.text = player.position.z.ToString("0");
    }
}
