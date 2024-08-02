using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Subscript1 : MonoBehaviour
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
        yield return new WaitForSeconds(6);
        textbox.GetComponent<TextMeshProUGUI>().text = "It might not always be able to prevent some phobias, such a fear of flying. You might choose to seek expert assistance and guidance in this situation to learn about available treatments.";
        yield return new WaitForSeconds(11);
        textbox.GetComponent<TextMeshProUGUI>().text = "Although the majority of phobias are treatable, not all phobias will respond to the same treatment. A mix of several treatments may be advised in some circumstances.";
        yield return new WaitForSeconds(13);
        textbox.GetComponent<TextMeshProUGUI>().text = "The main treatment types are: 1.self - help techniques 2.talking treatments 3.medication";
        yield return new WaitForSeconds(9);
        textbox.GetComponent<TextMeshProUGUI>().text = "You can refer yourself directly to a medical professional talking therapies service without a referral from a therapist..THE END";

    }
}
