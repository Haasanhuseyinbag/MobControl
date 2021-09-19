using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CloneGiant : MonoBehaviour
{
    float Hiz = 4;
    public int Healt = 6;
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
        if (Healt <= 0)
        {
            Destroy(gameObject);
        }
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
            int Ihtimal = Random.Range(0, 2);
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
        if (collision.gameObject.tag == "DusmanKulesi")
        {
            collision.gameObject.GetComponent<DusmanKulesi>().Healt -= 5;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "FinalCember")
        {
            agent.SetDestination(DusmanKulesi.transform.position);
        }
    }
}
