using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSliderController : MonoBehaviour
{
    public Slider slider;
    public int buttonValue;

   /* private void Start()
    {
        // Assuming the script is attached to the button, we'll subscribe to the button's click event
        Button button = GetComponent<Button>();
        button.onClick.AddListener(AddToSliderValue);
    }*/

    public void AddToSliderValue()
    {
        // Add the button value to the slider's current value
        slider.value += buttonValue;
    }
}
