using UnityEngine;

public class GameMonetizeManager : MonoBehaviour
{
    private void Awake()
    {
        GameMonetize.OnResumeGame += ResumeGame;
        GameMonetize.OnPauseGame += PauseGame;
    }

    private void Start()
    {
        ShowAd();
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