using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> spawnedchunks = new List<Chunk>();
    void Start()
    {
        spawnedchunks.Add(FirstChunk);
    }

    void Update()
    {
        if (Player.position.y < spawnedchunks[^1].End.position.y + 15)
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = spawnedchunks[^1].End.position - newChunk.Begin.localPosition;
        spawnedchunks.Add(newChunk);

        if (spawnedchunks.Count >= 3)
        {
            Destroy(spawnedchunks[0].gameObject);
            spawnedchunks.RemoveAt(0);
        }
    }
}
