using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpanw = 0;
    public float tileLength = 38f;
    public int numberOfTiles = 10;
    public Transform playerTransform;
    private List<GameObject> activeTiles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < numberOfTiles; i++)
        {
            SpawnTile(Random.Range(0,tilePrefabs.Length));
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z -32 > zSpanw - (numberOfTiles * tileLength) )
        {

            SpawnTile(Random.Range(0, tilePrefabs.Length));
            
                DeleteTile();
            
        }
        
    }
    public void SpawnTile(int tileIndex)
    {

        GameObject tile= Instantiate(tilePrefabs[tileIndex], transform.forward * zSpanw, transform.rotation);
        activeTiles.Add(tile);
        zSpanw += tileLength;

    }
    private void DeleteTile()
    {

        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
