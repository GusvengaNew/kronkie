using UnityEngine;
using UnityEngine.UI;

public class SaveOptions : MonoBehaviour
{
    // Reference to your Toggle elements
    public Toggle[] toggleElements;

    // Reference to your Slider elements
    public Slider[] sliderElements;

    private void Start()
    {
        // Load the saved state when the script starts
        LoadToggleState();
        LoadSliderState();
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

    // Save the state of Slider elements
    public void SaveSliderState()
    {
        for (int i = 0; i < sliderElements.Length; i++)
        {
            // Use the slider element's name as the key for PlayerPrefs
            PlayerPrefs.SetFloat(sliderElements[i].name, sliderElements[i].value);
        }
        PlayerPrefs.Save();
    }

    // Load the state of Slider elements
    public void LoadSliderState()
    {
        for (int i = 0; i < sliderElements.Length; i++)
        {
            // Use the slider element's name as the key for PlayerPrefs
            float savedValue = PlayerPrefs.GetFloat(sliderElements[i].name, sliderElements[i].minValue);
            sliderElements[i].value = savedValue;
        }
    }
}
