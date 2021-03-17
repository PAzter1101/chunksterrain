using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TrainMoving : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject сhunksPlacer;
    [SerializeField] private List<Chunk> spawnedChunks;

    [SerializeField] private float speed;   
    [SerializeField] private float range;
    [SerializeField] private Vector3 velocity;

    private Transform trainTransform;

    void Start()
    {
        trainTransform = gameObject.GetComponent<Transform>();

        spawnedChunks = сhunksPlacer.GetComponent<ChunksPlacer>().SpawnedChunks;
    }

    void Update()
    {
        if (spawnedChunks.Count > 1)
        {
            if (player.position.z > spawnedChunks[spawnedChunks.Count - 2].End.position.z)
            {
                GoToNextChunk();
            }
        }
    }

    public void GoToNextChunk()
    {
        Chunk currentChunk = сhunksPlacer.GetComponent<ChunksPlacer>().SpawnedChunks[spawnedChunks.Count - 1];
        range = currentChunk.End.position.z - 3;
        StartCoroutine("CorutineGoToNextChunk");
    }

    IEnumerator CorutineGoToNextChunk()
    {
        while(trainTransform.position.z < range)
        {
            Debug.Log(range);

            trainTransform.position += speed * velocity * Time.deltaTime;

            yield return null;
        }
    }   
}
