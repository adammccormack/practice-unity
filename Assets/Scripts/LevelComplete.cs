using UnityEngine;
using UnityEngine.SceneManagement; // we import this because the animation event will load the next level, so we use SceneManagement.

// This is an animation event.

public class LevelComplete : MonoBehaviour
{
    // Just creating this is as a empty function is enough for it to show when you click on the animation event icon. 
    public void LoadNextLevel()
    {
        // we use the SceneManager and pass in the scene we want to load. Remember to use the build index instead of
        // the name in File > Build Settings, then see what build index number on the right you want for each scene.
        // GetActiveScene gets scene we're currently on, and .buildIndex is the index we're currently on, then + 1 to set it to the next level.
        // In Unity we need to make sure there's always a next scene, when player beats the last level, make sure you create a level/scene that
        // congratulates the player. 
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
                                 
    }
}
