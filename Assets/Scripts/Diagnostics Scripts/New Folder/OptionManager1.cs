using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager1 : MonoBehaviour
{
    public static OptionManager1 Instance; // Singleton instance

    private Dictionary<int, string> selectedOptions; // Dictionary to store selected options

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        selectedOptions = new Dictionary<int, string>();
    }

    public void StoreOption(int questionIndex, string optionValue)
    {
        if (selectedOptions.ContainsKey(questionIndex))
        {
            selectedOptions[questionIndex] = optionValue;
        }
        else
        {
            selectedOptions.Add(questionIndex, optionValue);
        }

        ResultCalculatorTMP1.Instance.UpdateResultDisplay();
    }

    public Dictionary<int, string> GetSelectedOptions()
    {
        return selectedOptions;
    }
}

