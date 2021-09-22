using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSes : MonoBehaviour
{
    [SerializeField] AudioSource source;
    private void Update()
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
}
