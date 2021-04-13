using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManagerScript : MonoBehaviour
{
    public TextMeshProUGUI DickonsText;
    public TextMeshProUGUI DevilText;
    public string[] DickonsSentences;
    public string[] DevilSentences;
    private int DickonsIndex;
    private int DevilIndex;
    public float TypingSpeed;

    IEnumerator DickonsSpeaks()
    {
        foreach (var letters in DickonsSentences[DickonsIndex].ToCharArray())
        {
            DickonsText.text += letters;
            yield return new WaitForSeconds(TypingSpeed);
        }
    }


    IEnumerator DevilSpeaks()
    {
        foreach (var letters in DevilSentences[DevilIndex].ToCharArray())
        {
            DevilText.text += letters;
            yield return new WaitForSeconds(TypingSpeed);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(DevilSpeaks());
        //StartCoroutine(DickonsSpeaks());
    }

    // Update is called once per frame
    void Update()
    {
        DickonsNextSentence();
        DevilNextSentence();
    }

    public void DickonsNextSentence()
    {
        if (DickonsIndex <= DickonsSentences.Length - 1 && Input.GetKeyDown(KeyCode.Z))
        {
            DickonsIndex++;
            DickonsText.text = "";
            StartCoroutine(DickonsSpeaks());
        }

    }

    public void DevilNextSentence()
    {
        if (DevilIndex < DevilSentences.Length - 1 && Input.GetKeyDown(KeyCode.X))
        {
            DevilIndex++;
            DevilText.text = "";
            StartCoroutine(DevilSpeaks());
        }

    }
}
