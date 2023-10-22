using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;

public class GameMonetizeManager : MonoBehaviour
{
    private void Awake()
    {
        GameMonetize.OnResumeGame += ResumeGame;
        GameMonetize.OnPauseGame += PauseGame;
    }

    private void Start()
    {
        StartCoroutine(ShowAds());
    }

    private IEnumerator ShowAds()
    {
        yield return new WaitForSeconds(15);
        ShowAd();
        StartCoroutine(ShowAds());
    }

    private void OnDestroy()
    {
        GameMonetize.OnResumeGame -= ResumeGame;
        GameMonetize.OnPauseGame -= PauseGame;
    }

    public void ResumeGame()
    {
        // RESUME MY GAME
    }

    public void PauseGame()
    {
        // PAUSE MY GAME
        ShowAd();
    }

    public void ShowAd()
    {
        GameMonetize.Instance.ShowAd();
    }
}