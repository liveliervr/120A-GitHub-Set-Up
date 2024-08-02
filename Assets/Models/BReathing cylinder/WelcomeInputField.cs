using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WelcomeInputField : MonoBehaviour
{

    public TMP_InputField inputField;
    public TextMeshProUGUI welcomeText;

    // Start is called before the first frame update.
    void Start()
    {
    }

    // Update is called every frame.
    void Update()
    {
        // Get the text typed in the input field.
        string text = inputField.text;

        // Display the text with "Welcome" on the UI.
        welcomeText.text = "Welcome, " + text;
    }
}
