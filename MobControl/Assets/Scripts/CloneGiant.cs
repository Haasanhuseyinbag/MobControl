using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneGiant : MonoBehaviour
{
    float Hiz = 3;
    public int Healt = 6;
    void Update()
    {
        transform.Translate(Vector3.forward * Hiz * Time.deltaTime);
        if (Healt <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
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
