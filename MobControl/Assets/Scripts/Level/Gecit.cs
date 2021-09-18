using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gecit : MonoBehaviour
{
    [SerializeField] int KlonSayisi;
    [SerializeField] TextMesh text;
    [SerializeField] GameObject CloneGiant, CloneHuman;
    private void Update()
    {
        text.text = "X" + KlonSayisi;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "PlayerHuman")
        {
            for (int i = 1; i <= KlonSayisi - 1; i++)
            {
                Instantiate(CloneHuman, new Vector3(other.gameObject.transform.position.x + i,
                    other.gameObject.transform.position.y,
                    other.gameObject.transform.position.z), other.transform.rotation);
            }
        }
        else if (other.transform.tag == "PlayerGiant")
        {
            for (int i = 1; i < KlonSayisi; i++)
            {
                Instantiate(CloneGiant, new Vector3(other.gameObject.transform.position.x + 1,
                    other.gameObject.transform.position.y,
                    other.gameObject.transform.position.z), other.transform.rotation);
            }
        }
    }
}
