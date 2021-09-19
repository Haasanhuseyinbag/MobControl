using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHuman : MonoBehaviour
{
    [SerializeField] float Hiz;
    GameManager manager;
    void Start()
    {
        StartCoroutine(Yurume());
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        if (collision.gameObject.tag == "Top")
            manager.Defeat();
    }
}
