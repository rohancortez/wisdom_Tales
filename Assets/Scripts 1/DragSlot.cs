using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragSlot : MonoBehaviour
{
    public TMP_Text answer;
    public GameObject nextButton;
    public GameObject correctIcon;
    public GameObject rightAnswer;
    public GameObject wrongAnswer;
    public float durationTime = 1f;
    public void ActivateNextButton()
    {
        nextButton.gameObject.SetActive(true);
        Invoke("nextButton", 5f);
    }

    public void DissapearRightMark()
    {
        rightAnswer.gameObject.SetActive(false);
    }

    public void DissappearWrongMark()
    {
        wrongAnswer.gameObject.SetActive(false);
    }

    public void ActivateAnswer()
    {
        answer.gameObject.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Elephant"))
        {

            Debug.Log("Correct");
            Destroy(correctIcon);
            ActivateAnswer();
            ActivateNextButton();
            rightAnswer.gameObject.SetActive(true);
            Invoke("DissapearRightMark", durationTime);

        }
        else 
        {
            Debug.Log("Incorrect");
            wrongAnswer.gameObject.SetActive(true);
            Invoke("DissappearWrongMark", durationTime);
        }
    }
}

