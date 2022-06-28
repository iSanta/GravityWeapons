using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shot Data", menuName ="Shot Data")]
public class ShotData : ScriptableObject
{
    [SerializeField] private float ForceIntensity;

    public float GetForceIntensity { get { return ForceIntensity; } }
}
