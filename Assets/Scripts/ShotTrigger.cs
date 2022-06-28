using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTrigger : MonoBehaviour
{
    [SerializeField] GameObject Canon;
    [SerializeField] GameObject Bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            Instantiate(Bullet, Canon.transform.position, Canon.transform.rotation);
        }


    }
}
