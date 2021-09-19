using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void Win()
    {
        Time.timeScale = 0;
    }
    public void Defeat()
    {
        Time.timeScale = 0;
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
