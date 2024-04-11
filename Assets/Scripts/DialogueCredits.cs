using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class DialogueCredits: MonoBehaviour
{
    public TextMeshProUGUI textDialogueEnd;
    public string[] finalLines;
    public float speeds;
    public AudioSource bossSad;


    private int finalIndex;

    void Start()
    {
        textDialogueEnd.text = string.Empty;
        StartDialogueEnd();
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))  
        {
            bossSad.Play();
            if (textDialogueEnd.text == finalLines[finalIndex])
            {

                NextLineEnd();

            }
            else
            {

                StopAllCoroutines();
                textDialogueEnd.text = finalLines[finalIndex];


            }

        }
    }

    public void StartDialogueEnd()
    {
        finalIndex = 0;
        StartCoroutine(LastScene());

    }

    IEnumerator LastScene()
    {
        //This lets us type out each line at time 

        foreach (char c in finalLines[finalIndex].ToCharArray())
        {

            textDialogueEnd.text += c;
            yield return new WaitForSeconds(speeds);


        }
    }

    void NextLineEnd()
    {
        if (finalIndex < finalLines.Length - 1)
        {
            finalIndex++;
            textDialogueEnd.text = string.Empty;
            StartCoroutine(LastScene());

        }
        else
        {
            SceneManager.LoadScene("Credits");

        }

    }

}
