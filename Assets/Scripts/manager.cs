using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    private int AnimSelected;
    [SerializeField] GameObject Character;
    public void ChangeAnim(int n)
    {
        Character.GetComponent<Animator>().SetInteger("AnimState", n);
        AnimSelected = n;
    }

    public void ChangeScene()
    {
        PlayerPrefs.SetInt("Anim", AnimSelected);
        SceneManager.LoadScene(1);
    }
}
