using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Text HighScore;
    // Start is called before the first frame update
    private void Start()
    {
        HighScore.text = "Text";
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScore.text = "Average Reaction Time: " + PlayerPrefs.GetString("HighScore") + " seconds!"; ;
        }
        else
        {
            HighScore.text = "Average Reaction Time: No Record Yet";
        }
        
    }
    public void PlayGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        
    }

    public void PracticeGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit();
    }
}
