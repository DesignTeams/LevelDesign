using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginScene : MonoBehaviour
{
    public TMPro.TextMeshProUGUI interactionText;
    public TMPro.TextMeshProUGUI otherText;

    public bool showText = false;
    // Start is called before the first frame update
    void Start()
    {
        
            StartCoroutine(ShowBeginText());
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowBeginText()
    {
        otherText.text = "";
        interactionText.text = "Oh... I drank too much. My head...";
        yield return new WaitForSeconds(5);
        interactionText.text = "I want to go home.";
        yield return new WaitForSeconds(5);
        interactionText.text = "";
        StopCoroutine(ShowBeginText());
    }
}
