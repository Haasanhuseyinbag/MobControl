using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGiant : MonoBehaviour
{
    [SerializeField] float Hiz;
    public int Healt = 6;
    GameManager manager;
    void Start()
    {
        StartCoroutine(Yurume());
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        Hiz = 4;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Top")
            manager.Defeat();
    }
}
