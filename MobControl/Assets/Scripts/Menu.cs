using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    [SerializeField] Text ParaText;
    GameSkor Skor;
    private void Start()
    {
        Skor = GameObject.Find("GameSkor").GetComponent<GameSkor>();
    }
    private void Update()
    {
        ParaText.text = Skor.Para.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }
    }
}
