using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        Vector3 MousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.x));
        this.transform.position = new Vector3(MousePosition.x, this.transform.position.y, this.transform.position.y);
    }
}
