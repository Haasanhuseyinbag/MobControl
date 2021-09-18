using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHuman : MonoBehaviour
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
        Hiz = 10;
        yield return new WaitForSeconds(0.5f);
        Hiz = 3;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyHuman")
        {
            int Ihtimal = Random.Range(0, 2);
            if (Ihtimal == 0)
            {
                Destroy(gameObject);
            }
            else if (Ihtimal == 1)
            {
                Destroy(collision.gameObject);
            }
        }
        else if (collision.gameObject.tag == "EnemyGiant")
        {
            collision.gameObject.GetComponent<EnemyGiant>().Healt -= 1;
            Destroy(gameObject);
        }
    }
}
