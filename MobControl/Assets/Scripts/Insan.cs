using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insan : MonoBehaviour
{
    [SerializeField] float Hiz;
    void Start()
    {
        StartCoroutine(Yurume());
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Hiz * Time.deltaTime);
    }
    IEnumerator Yurume()
    {
        Hiz = 7;
        yield return new WaitForSeconds(0.5f);
        Hiz = 2;
    }
}
