using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToSlider : MonoBehaviour
{
    public Slider slider; // Reference to the slider in the Inspector

    public void AddButtonValueToSlider(float value)
    {
        slider.value += value; // Add the button value to the slider's current value
    }
}

