using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitational : MonoBehaviour
{
    private GameObject[] allObj;
    private Transform SingleObj;
    private Rigidbody SingleOnjRB;
    [SerializeField] float influenceRange;
    [SerializeField] float intensity;
    private float distance;
    private Vector3 pullForce;

    private void Start()
    {
        allObj = GameObject.FindGameObjectsWithTag("ObjGrav");
    }

    private void Update()
    {
        foreach (var obj in allObj)
        {
            distance = Vector3.Distance(obj.transform.position, transform.position);
            if (distance <= influenceRange)
            {
                pullForce = (transform.position - obj.transform.position).normalized / distance * intensity;
                obj.GetComponent<Rigidbody>().AddForce(pullForce, ForceMode.Force);
            }
        }
    }
}
