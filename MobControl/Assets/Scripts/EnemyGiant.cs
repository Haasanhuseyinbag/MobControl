using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGiant : MonoBehaviour
{
    [SerializeField] float Hiz;
    public int Healt = 6;
    void Start()
    {
        StartCoroutine(Yurume());
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Hiz * Time.deltaTime);
        if (Healt <= 0)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Yurume()
    {
        Hiz = 7;
        yield return new WaitForSeconds(0.5f);
        Hiz = 3;
    }
}
