using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    [SerializeField] Text ParaText, LevelText;
    GameSkor Skor;
    private void Start()
    {
        Skor = GameObject.Find("GameSkor").GetComponent<GameSkor>();
    }
    private void Update()
    {
        ParaText.text = PlayerPrefs.GetInt("Para").ToString();
        LevelText.text = "LEVEL - " + PlayerPrefs.GetInt("Seviye").ToString();
    }
    public void Acil()
    {
        PlayerPrefs.SetInt("Skor", 0);
        PlayerPrefs.SetInt("RaundSayisi", 0);
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
}
