using UnityEngine;
using UnityEngine.UI;

public class SaveSliderOptions : MonoBehaviour
{
    // Reference to your Slider elements
    public Slider[] sliderElements;

    private void Start()
    {
        // Load the saved state when the script starts
        LoadSliderState();
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
            float savedState = PlayerPrefs.GetFloat(sliderElements[i].name, sliderElements[i].minValue);
            sliderElements[i].value = savedState;
        }
    }
}
