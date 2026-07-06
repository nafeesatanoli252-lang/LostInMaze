using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Drag these from Hierarchy into the Inspector
    public GameObject MainMenu;
    public GameObject SettingsPanel;
    public GameObject CreditsPanel;

    // Start Game
    public void StartGame()
    {
        SceneManager.LoadScene("LostInMaze");
    }

    // Open Settings
    public void OpenSettings()
    {
        MainMenu.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    // Close Settings
    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
        MainMenu.SetActive(true);
    }

    // Open Credits
    public void OpenCredits()
    {
        MainMenu.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    // Close Credits
    public void CloseCredits()
    {
        CreditsPanel.SetActive(false);
        MainMenu.SetActive(true);
    }

    // Exit Game
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}