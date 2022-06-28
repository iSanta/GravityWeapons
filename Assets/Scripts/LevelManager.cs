using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject CornerChar;
    // Start is called before the first frame update
    void Start()
    {
        CornerChar.GetComponent<Animator>().SetInteger("AnimState", PlayerPrefs.GetInt("Anim"));
    }


}
