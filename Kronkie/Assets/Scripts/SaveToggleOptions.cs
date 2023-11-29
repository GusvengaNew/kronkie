using UnityEngine;
using UnityEngine.UI;

public class SaveToggleOptions : MonoBehaviour
{
    // Reference to your Toggle elements
    public Toggle[] toggleElements;

    private void Start()
    {
        // Load the saved state when the script starts
        LoadToggleState();
    }

    // Save the state of Toggle elements
    public void SaveToggleState()
    {
        for (int i = 0; i < toggleElements.Length; i++)
        {
            // Use the toggle element's name as the key for PlayerPrefs
            PlayerPrefs.SetInt(toggleElements[i].name, toggleElements[i].isOn ? 1 : 0);
        }
        PlayerPrefs.Save();
    }

    // Load the state of Toggle elements
    public void LoadToggleState()
    {
        for (int i = 0; i < toggleElements.Length; i++)
        {
            // Use the toggle element's name as the key for PlayerPrefs
            int savedState = PlayerPrefs.GetInt(toggleElements[i].name, 0);
            toggleElements[i].isOn = savedState == 1;
        }
    }
}
