
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerPref: MonoBehaviour
{
    public TMP_Text savedInfo;
    public TMP_InputField nameInputField;
    public GameObject renamePanel;

    private int score;
    private float volume;
    private string playerName;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        volume = PlayerPrefs.GetFloat("Volume", 0.1f);
        playerName = PlayerPrefs.GetString("PlayerName", "Player");

        nameInputField.text = playerName;
        renamePanel.SetActive(false);

        ShowSavedData();
    }

    public void OpenRenamePanel()
    {
        nameInputField.text = playerName;
        renamePanel.SetActive(true);
    }

    public void SavePreferredName()
    {
        string enteredName = nameInputField.text.Trim();

        if (string.IsNullOrWhiteSpace(enteredName))
        {
            return;
        }

        playerName = enteredName;

        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        ShowSavedData();
        renamePanel.SetActive(false);
    }

    public void ClosePanel()
    {
        renamePanel.SetActive(false);
    }

    public void AddScore()
    {
        score += 10;

        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();

        ShowSavedData();
    }
    public void ReduceScore()
    {
        score -= 10;

        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();

        ShowSavedData();
    }

    public void IncreaseVolume()
    {
        volume = Mathf.Clamp01(volume + 0.1f);

        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save();

        ShowSavedData();

        Debug.Log("Volume is now: " + volume);
    }

    public void ShowSavedData()
    {
        savedInfo.text =
            "Player: " + playerName + "\n" +
            "Score: " + score + "\n" +
            "Volume: " + volume.ToString("F1");
    }
}
