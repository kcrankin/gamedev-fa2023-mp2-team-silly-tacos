using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class SceneResetController : MonoBehaviour
{
    // Define a KeyCode for the reset action (e.g., 'R' key).
    public KeyCode resetKey = KeyCode.R;

    // Update is called once per frame
    void Update()
    {
        // Check if the reset key is pressed.
        if (UnityEngine.Input.GetKeyDown(resetKey))
        {
            // Call a method to reset the scene.
            ResetScene();
        }
    }

    void ResetScene()
    {
        // Get the current scene's name.
        string sceneName = SceneManager.GetActiveScene().name;

        // Reload the current scene.
        SceneManager.LoadScene(sceneName);
    }
}




