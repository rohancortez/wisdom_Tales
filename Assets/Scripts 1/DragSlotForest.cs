using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DragSlotForest : MonoBehaviour
{
    public TMP_Text answer;
    public GameObject nextButton;
    public GameObject correctIcon;
    public GameObject rightAnswer;
    public GameObject wrongAnswer;
    public float durationTime = 1f;



    public void ActivateAnswer()
    {
        answer.gameObject.SetActive(true);
    }

    public void ActivateNextButton() 
    {
        nextButton.gameObject.SetActive(true);
    }

    public void DissapearRightMark()
    {
        rightAnswer.gameObject.SetActive(false);
    }

    public void DissappearWrongMark() 
    {
        wrongAnswer.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Forest"))
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
