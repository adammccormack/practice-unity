using UnityEngine;
using UnityEngine.SceneManagement; // Need to use this whenever we need to change to a different scene or reload the scene we're on.


// Game Manager Script is better for stuff like starting and ending game etc.
// This component will be responsible for changing states in our game, it can do stuff like start and stop, restart a game, and display UI on the
// screen if you want a score counter,
// a game over screen, a transition to other menus, like a main menu or level selector.

// For this test game, we're going to make some code for that will restart our game when we hit something or when we fall off the edge.
// So we need to go into PlayerCollision script and make a reference, and search for the game manager when we want it.

// In playerCollision script FindObjectOfType<GameManager>().GameOver();
// make sure to make the GameOver public so it can find it.

// Put all the levels you want to include when you export your game in Build Settings.


public class GameManager : MonoBehaviour
{
    // boolean switch makes sure that function is only called once when ending. 
    bool gameEnded = false;

    // We set the restartDelay to a variable so that it is accessible in the unity editor and we can change it from one place. 
    public float restartDelay = 1f;

    // We need to reference the UI 'Level Complete' to enable it when we complete the level. We name it levelCompleteUI;
    public GameObject levelCompleteUI;


    public void LevelComplete ()
    {   // true or false to enable or disable the levelCompleteUI we are reference, ensure to drag and drop it in Unity.
        levelCompleteUI.SetActive(true);
    }

    public void GameOver ()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", restartDelay);
        }
        
    }

    void RestartGame()
    {
        // We restart the game by reloaind the scene below.
        // SceneManager.LoadScene("Level_01") // Level_01 is name of the scene we asked to load. however if we want to load the scene that is currently active
        // when you have multiple levels.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Loads level with the given .name, .GetActiveScene gets the current level we're in. 
     }
}
