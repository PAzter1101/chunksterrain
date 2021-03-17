using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunksPlacer : MonoBehaviour
{
    public List<Chunk> SpawnedChunks { get => spawnedChunks; }

    [SerializeField] private Transform player;
    [SerializeField] private Chunk firstChunk;
    [SerializeField] private Chunk[] chunkPrefabs;    

    [SerializeField] private List<Chunk> spawnedChunks = new List<Chunk>();


    private void Start()
    {
        spawnedChunks.Add(firstChunk);
    }
    private void Update()
    {
        if (player.position.z > spawnedChunks[spawnedChunks.Count-1].End.position.z)
        {
            SpawnChunk();
        }
    }
    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(chunkPrefabs[Random.Range(0, chunkPrefabs.Length)]);
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;
        spawnedChunks.Add(newChunk);
    }
}
