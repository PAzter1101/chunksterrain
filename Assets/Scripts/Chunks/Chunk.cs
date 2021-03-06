using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private Transform begin;
    [SerializeField] private Transform end;

    public Transform Begin => begin;
    public Transform End => end;
}
