using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject KazanmaEkrani, KaybetmeEkrani;
    [SerializeField] int RaundSayisi;
    [SerializeField] Text text, text2, SkorText;
    GameSkor Skor;
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
        KazanmaEkrani.SetActive(true);
        Time.timeScale = 0;
        RaundSayisi++;
        if (3 <= RaundSayisi)
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
        KazanmaEkrani.SetActive(false);
        KaybetmeEkrani.SetActive(false);
        SceneManager.LoadScene("Menu");
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
        if (3 <= RaundSayisi)
        {
            Skor.LevelSonu();
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
