using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerHuman : MonoBehaviour
{
    [SerializeField] float Hiz;
    GameManager manager;
    NavMeshAgent agent;
    GameObject DusmanKulesi;
    void Start()
    {
        StartCoroutine(Yurume());
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        DusmanKulesi = GameObject.Find("DusmanKulesi");
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Hiz * Time.deltaTime);
    }
    IEnumerator Yurume()
    {
        Hiz = 10;
        yield return new WaitForSeconds(0.5f);
        Hiz = 4;
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
        if (collision.gameObject.tag == "EnemyGiant")
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
