using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour
{
    public Slider slider;
    public Text valueText;
    public InputField inputField;

    void Start()
    {
        // Initialize slider, text, and input field
        slider.onValueChanged.AddListener(UpdateSliderValue);
        inputField.onEndEdit.AddListener(UpdateSliderFromInput);

        // Set initial values
        UpdateSliderValue(slider.value);
    }

    void UpdateSliderValue(float value)
    {
        // Update the text when the slider value changes
        valueText.text = "Value: " + value.ToString("F2");
    }

    void UpdateSliderFromInput(string input)
    {
        // Update the slider value when the input field value changes
        float inputValue;
        if (float.TryParse(input, out inputValue))
        {
            slider.value = Mathf.Clamp(inputValue, slider.minValue, slider.maxValue);
            valueText.text = "Value: " + slider.value.ToString("F2");
        }
        else
        {
            // Handle invalid input
            inputField.text = slider.value.ToString("F2");
        }
    }
}
