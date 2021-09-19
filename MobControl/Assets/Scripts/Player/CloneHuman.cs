using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CloneHuman : MonoBehaviour
{
    float Hiz = 4;
    GameManager manager;
    NavMeshAgent agent;
    GameObject DusmanKulesi;
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        DusmanKulesi = GameObject.Find("DusmanKulesi");
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Hiz * Time.deltaTime);
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
        if (collision.gameObject.tag == "DusmanKulesi")
        {
            collision.gameObject.GetComponent<DusmanKulesi>().Healt--;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "FinalCember")
        {
            agent.SetDestination(DusmanKulesi.transform.position);
        }
    }
}
