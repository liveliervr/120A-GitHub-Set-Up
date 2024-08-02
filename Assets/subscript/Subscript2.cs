using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Subscript2 : MonoBehaviour
{
    public GameObject textbox;
    //public TextMeshProUGUI

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
        
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "BREATHE OUT";


    }
}
