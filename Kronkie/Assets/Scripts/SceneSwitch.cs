using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public float timeToSwitchScene = 5f; // Adjust this to the desired time before switching scenes
    public string sceneToLoad; // Variable to store the name of the scene to switch to

    private float timer = 0f;

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if the timer has reached the desired time
        if (timer >= timeToSwitchScene)
        {
            // Reset the timer
            timer = 0f;

            // Call a method to switch scenes
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // Check if the sceneToLoad variable is not empty
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("SceneToLoad is not set in the inspector!");
        }
    }
}
