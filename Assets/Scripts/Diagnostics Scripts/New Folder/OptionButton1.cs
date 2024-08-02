using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton1 : MonoBehaviour
{
    public int questionIndex; // Index or identifier of the associated question
    public string optionValue; // Value associated with the selected option

    private Button button;

   /* private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnOptionSelected);
    }*/

    public void OnOptionSelected()
    {
        OptionManager1.Instance.StoreOption(questionIndex, optionValue);
    }
}

