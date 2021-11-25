using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Game()
    {
        SceneManager.LoadScene("FireWorkClicker");
    }
    public void Buttons()
    {
        SceneManager.LoadScene("Buttons");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
