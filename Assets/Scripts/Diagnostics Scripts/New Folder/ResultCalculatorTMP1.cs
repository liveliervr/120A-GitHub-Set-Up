using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultCalculatorTMP1 : MonoBehaviour
{
    public Slider resultSlider;
    public TextMeshProUGUI resultText;

    public static ResultCalculatorTMP1 Instance; // Singleton instance

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateResultDisplay();
    }

    public void UpdateResultDisplay()
    {
        float result = CalculateResult();

        resultSlider.value = result;

        // Determine the text to display based on the result range
        string resultLabelText;
        if (result >= 0 && result <= 4)
        {
            resultLabelText = "Based on your response you're not experiencing MINIMAL symptoms seen in anxiety";
        }
        else if (result >= 5 && result <= 9)
        {
            resultLabelText = "Based on your response you're experiencing MILD symptoms seen in anxiety";
        }
        else if (result >= 10 && result <= 14)
        {
            resultLabelText = "Based on your response you're experiencing MODERATE symptoms seen in anxiety";
        }
        else if (result >= 15 && result <= 24)
        {
            resultLabelText = "Based on your response you're experiencing SEVERE symptoms seen in anxiety";
        }
        else
        {
            resultLabelText = "Result: Unknown";
        }

        string resultScoreText = "Your Anxiety Score is " + result.ToString();

        resultText.text = resultScoreText + "\n" + resultLabelText;
    }

    private float CalculateResult()
    {
        OptionManager1 optionManager = OptionManager1.Instance;
        var selectedOptions = optionManager.GetSelectedOptions();

        float result = 0f;
        foreach (var option in selectedOptions)
        {
            float optionValue = 0f;
            if (float.TryParse(option.Value, out optionValue))
            {
                result += optionValue;
            }
        }

        return result;
    }
}

