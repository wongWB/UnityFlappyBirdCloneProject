using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void onStartClick()
    {
        // start the game
        Debug.Log("Starting game...");
        SceneManager.LoadScene("Scene0");
    }
    public void onExitClick()
    {
        Debug.Log("Quitting game..."); // log a message to the console

        // This will only work in a built version of the game
        Application.Quit();

        // If running in the Unity Editor, stop play mode
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif

    }
}
