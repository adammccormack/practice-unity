using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    // onCollisionEnter will not work if your collider is marked as triggered, you need to write onTriggerEnter instead. 

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.LevelComplete();
    }

    // Whenever we hit our trigger we need to tell our gameManager to display some UI on the screen, to do that first we need a reference to
    // gameManager, we could use FindObjectOfType, but in this scenario might make more sense to reference it directly.

    // We create a function for winning the game in Game Manager     public void LevelComplete ()

    // Then we can access LevelComplete now in our script, and we have to make the reference in Unity by dragging Game Manager into END.

}
