using UnityEngine;

// Game Manager Script is better for stuff like starting and ending game etc.
// This component will be responsible for changing states in our game, it can do stuff like start and stop, restart a game, and display UI on the
// screen if you want a score counter,
// a game over screen, a transition to other menus, like a main menu or level selector.

// For this test game, we're going to make some code for that will restart our game when we hit something or when we fall off the edge.
// So we need to go into PlayerCollision script and make a reference, and search for the game manager when we want it.

// In playerCollision script FindObjectOfType<GameManager>().GameOver();
// make sure to make the GameOver public so it can find it.


public class GameManager : MonoBehaviour
{
    public void GameOver ()
    {
        Debug.Log("GAME OVER");
    }
}
