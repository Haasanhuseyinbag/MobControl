using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject KazanmaEkrani, KaybetmeEkrani;
    [SerializeField] int RaundSayisi;
    [SerializeField] Text text,text2;
    public void Win()
    {
        KazanmaEkrani.SetActive(true);
        Time.timeScale = 0;
        RaundSayisi++;
        if (RaundSayisi >= 3)
        {
            text.text = "Menu";
            text2.text = "Seviyeyi Geçtin";
        }
    }
    public void Defeat()
    {
        KaybetmeEkrani.SetActive(true);
        Time.timeScale = 0;
        RaundSayisi = 0;
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
    }
    public void SonrakiSeviye()
    {
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        if (RaundSayisi < 3)
        {
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
        }
        if (RaundSayisi >= 3)
        {
            OpenMenu();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        Time.timeScale = 1;
    }
}
