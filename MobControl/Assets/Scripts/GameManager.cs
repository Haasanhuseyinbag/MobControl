using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text text;
    public void Win()
    {
        text.text = "WİN";
        Time.timeScale = 0;
    }
    public void Defeat()
    {
        text.text = "DEFEAT";
        Time.timeScale = 0;
    }
}
