using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneHuman : MonoBehaviour
{
    float Hiz = 3;
    void Update()
    {
        transform.Translate(Vector3.forward * Hiz * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
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
