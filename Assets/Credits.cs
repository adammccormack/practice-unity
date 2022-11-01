using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit ()
    {
        // Unity will not actually quit when in the game until you export it. 
        //Application.Quit();

        Debug.Log("Quit");
    }
}
