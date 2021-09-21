using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject KazanmaEkrani, KaybetmeEkrani, Menu, Score;
    [SerializeField] public int KazanilanRaundSayisi = 0;
    [SerializeField] Text text, text2, SkorText;
    GameSkor Skor;
    public int Seviye;
    private void Start()
    {
        Skor = GameObject.Find("GameSkor").GetComponent<GameSkor>();
    }
    private void Update()
    {
        SkorText.text = Skor.Skor.ToString();
    }
    public void Win()
    {
        Score.SetActive(false);
        Menu.SetActive(false);
        Time.timeScale = 0;
        KazanmaEkrani.SetActive(true);
        if (KazanilanRaundSayisi < 3)
        {
            KazanilanRaundSayisi += 1;
        }
        else if (KazanilanRaundSayisi >= 3)
        {
            text2.text = "Seviyeyi Geçtin";
            text.text = "MENÜ";
        }
    }
    public void SonrakiSeviye()
    {
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        if (KazanilanRaundSayisi >= 3)
        {
            OpenMenu();
        }
        else if (KazanilanRaundSayisi < 3)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }
    }
    public void Defeat()
    {
        Score.SetActive(false);
        Menu.SetActive(false);
        KaybetmeEkrani.SetActive(true);
        Time.timeScale = 0;
        KazanilanRaundSayisi = 0;
    }
    public void OpenMenu()
    {
        KazanilanRaundSayisi = 0;
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        Time.timeScale = 1;
        KazanilanRaundSayisi = 0;
        SceneManager.LoadScene("Game");
    }
}
