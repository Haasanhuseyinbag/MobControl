using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject Menu, Score, LevelSpawnPoint;
    [SerializeField] GameObject[] Levels;
    int SelectedLevel;
    private void Start()
    {
        SelectedLevel = Random.Range(0, 3);
        Instantiate(Levels[SelectedLevel], LevelSpawnPoint.transform.position, Quaternion.identity);
    }
}
