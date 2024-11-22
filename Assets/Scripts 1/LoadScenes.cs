//using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public int sceneToLoad;

    public AudioSource buttonClickSound;
    public float delayBeforeLoad = 1.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClickSound()
    {

        buttonClickSound.Play();
        StartCoroutine(LoadSceneWithDelay());
    }

    IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeLoad);

        SceneManager.LoadScene(sceneToLoad);
    }

    public void SelectStoryScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        //AdManager.Instance.ShowInterstitialAd();
    }

    public void OpenStory1()
    {
        SceneManager.LoadScene(sceneToLoad);
        //AdManager.Instance.ShowInterstitialAd();
    }

    public void OpenPhrases()
    {
        SceneManager.LoadScene(sceneToLoad);
        //AdManager.Instance.ShowInterstitialAd();
    }
}
