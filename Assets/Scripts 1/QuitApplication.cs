using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public AudioSource quitSound;

    public void PlayQuitSound()
    {
        quitSound.Play();
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
