using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGiant : MonoBehaviour
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyHuman")
        {
            Destroy(collision.gameObject);
            Healt -= 1;
        }
        else if (collision.gameObject.tag == "EnemyGiant")
        {
            int Ihtimal = Random.Range(0, 1);
            if (Ihtimal == 0)
            {
                collision.gameObject.GetComponent<EnemyGiant>().Healt -= 3;
                Destroy(gameObject);
            }
            else if (Ihtimal == 1)
            {
                Destroy(collision.gameObject);
                Healt -= 3;
            }
        }
    }
}
