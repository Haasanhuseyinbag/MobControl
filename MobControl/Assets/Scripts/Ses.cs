using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Ses : MonoBehaviour
{
    [SerializeField] Sprite SesAcik, SesKapali;
    [SerializeField] AudioMixer mixer;
    [SerializeField] AudioSource source;
    [SerializeField] GameObject Image;
    public void AcKapa()
    {
        source.enabled = !source.enabled;
    }
    private void Start()
    {
        if (PlayerPrefs.GetString("Ses") == "Acik")
        {
            source.enabled = true;
        }
        else if (PlayerPrefs.GetString("Ses") == "Kapali")
        {
            source.enabled = false;
        }
    }
    private void Update()
    {
        if (source.enabled)
        {
            Image.GetComponent<Image>().sprite = SesAcik;
            PlayerPrefs.SetString("Ses", "Acik");
        }
        else if (!source.enabled)
        {
            Image.GetComponent<Image>().sprite = SesKapali;
            PlayerPrefs.SetString("Ses", "Kapali");
        }
    }
}
