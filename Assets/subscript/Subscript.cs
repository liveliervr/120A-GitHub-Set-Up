using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Subscript : MonoBehaviour
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
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "I am so grateful to be alive today.";
        yield return new WaitForSeconds(6);
        textbox.GetComponent<TextMeshProUGUI>().text = "Thank goodness I can breathe in the power of life every wonderful moment of the day.";
        yield return new WaitForSeconds(11);
        textbox.GetComponent<TextMeshProUGUI>().text = "I am grateful to have experiences that help me to grow emotionally and spiritually in my life.";
        yield return new WaitForSeconds(11);
        textbox.GetComponent<TextMeshProUGUI>().text = "Thank you for my inner-strength that always helps me to overcome any challenge I encounter.";
        yield return new WaitForSeconds(11);
        textbox.GetComponent<TextMeshProUGUI>().text = "Thank you so much for my open mind and heart that always guide me in a positive and good direction.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "The best and the highest surrounds me and protects me with powerful and healing energy at every moment.  Thank you for that.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "Thank you for the healthy food that I am blessed with eating at every meal.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "Thank you for the fresh water I drink every day.  Thank you so much.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "These are generous gifts from Mother Nature, and I thank you for your generosity and for taking care of me.  Thank you so much for keeping me healthy.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "How wonderful it is to see, hear, taste, touch and smell all of the beautiful things on this earth.  Thank you for my remarkable senses.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "I appreciate my amazing brain because it allows me to think, to feel, to love and to live every memorable day.  Thank you so much for helping me function perfectly. ";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "All of the different parts of my body are unique and specially created to make me!";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "I am so grateful for my friends who lift me up when I am down.  Thank you for my friends who I love dearly.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "Thank you for the talents and skills that I am allowed to share with the world.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "I always remember that it's okay to be who I am.";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<TextMeshProUGUI>().text = "Conciousness breathing is my power";

    }
}
