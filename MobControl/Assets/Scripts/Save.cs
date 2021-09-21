using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    CannonScript cannon;
    GameSkor skor;
    GameManager manager;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void ParaKaydet()
    {
        PlayerPrefs.SetInt("Para", skor.Para);
    }
    public void AtisHiziKaydet()
    {
        PlayerPrefs.SetFloat("AtisHizi", cannon.FireRate);
    }
    public void SeviyeKaydet()
    {
        PlayerPrefs.SetInt("Seviye", manager.Seviye);
    }
}
