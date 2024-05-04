using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    // Public method to be called when the button is clicked
    public void LoadScene(string sceneName)
    {
        // Load the specified scene
        SceneManager.LoadScene("MainScene");
    }
}
