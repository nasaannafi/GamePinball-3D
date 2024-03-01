using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Button mainMenuButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(Main_Menu);
    }

    public void Main_Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}