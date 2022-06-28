using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ungravity : MonoBehaviour
{
    private GameObject[] allObj;
    [SerializeField] float Speed;
    private float distance;
    private List<GameObject> ingravityObjs;
    [SerializeField] float influenceRange;

    private void Start()
    {
        allObj = GameObject.FindGameObjectsWithTag("ObjGrav");
        ingravityObjs = new List<GameObject>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponentInChildren<Animator>().SetTrigger("AnimTrig");

        foreach (var obj in allObj)
        {
            distance = Vector3.Distance(obj.transform.position, transform.position);
            if (distance <= influenceRange)
            {
                ingravityObjs.Add(obj);
                obj.GetComponent<Rigidbody>().useGravity = false;
                obj.GetComponent<Rigidbody>().AddRelativeForce(Random.onUnitSphere * Speed);
               
            }
            
        }
        StartCoroutine(DestroyBullet());
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5f);
        foreach (var IngObj in ingravityObjs)
            IngObj.GetComponent<Rigidbody>().useGravity = true;

        Destroy(gameObject);
    }
}
