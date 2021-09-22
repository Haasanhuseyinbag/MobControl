using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject KazanmaEkrani, KaybetmeEkrani, Menu, Score;
    [SerializeField] int KazanilanRaundSayisi;
    [SerializeField] Text text, text2, SkorText;
    GameSkor Skor;
    public int Seviye;
    public int OncekiSkor;
    private void Start()
    {
        Skor = GameObject.Find("GameSkor").GetComponent<GameSkor>();
        KazanilanRaundSayisi = PlayerPrefs.GetInt("RaundSayisi");
        OncekiSkor = PlayerPrefs.GetInt("Skor");
    }
    private void Update()
    {
        SkorText.text = (Skor.Skor + PlayerPrefs.GetInt("Skor")).ToString();
    }
    public void Win()
    {
        Score.SetActive(false);
        Menu.SetActive(false);
        Time.timeScale = 0;
        KazanmaEkrani.SetActive(true);
        if (KazanilanRaundSayisi < 3)
        {
            PlayerPrefs.SetInt("Skor", Skor.Skor + OncekiSkor);
            KazanilanRaundSayisi += 1;
            PlayerPrefs.SetInt("RaundSayisi", KazanilanRaundSayisi);
        }
        if (KazanilanRaundSayisi >= 3)
        {
            int Para = PlayerPrefs.GetInt("Para");
            PlayerPrefs.SetInt("Para", PlayerPrefs.GetInt("Skor") + Skor.Skor + Para);
            PlayerPrefs.SetInt("Skor", 0);
            PlayerPrefs.SetInt("RaundSayisi", 0);
            text2.text = "Seviyeyi Geçtin";
            text.text = "MENÜ";
        }
    }
    public void SonrakiSeviye()
    {
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        if (KazanilanRaundSayisi < 3)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }
        if (KazanilanRaundSayisi >= 3)
        {
            Seviye++;
            PlayerPrefs.SetInt("Seviye", Seviye);
            OpenMenu();
        }
    }
    public void Defeat()
    {
        Score.SetActive(false);
        Menu.SetActive(false);
        KaybetmeEkrani.SetActive(true);
        Time.timeScale = 0;
        KazanilanRaundSayisi = 0;
        PlayerPrefs.SetInt("Skor", 0);
        PlayerPrefs.SetInt("RaundSayisi", 0);
    }
    public void OpenMenu()
    {
        KazanilanRaundSayisi = 0;
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        PlayerPrefs.SetInt("Skor", 0);
        PlayerPrefs.SetInt("RaundSayisi", 0);
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Skor", 0);
        PlayerPrefs.SetInt("RaundSayisi", 0);
        SceneManager.LoadScene("Game");
    }
}
