using UnityEngine;

public class SpawanTest : MonoBehaviour
{ 
    public GameObject objectToSpawn;

    public Vector3 spawnPostion;
    void Start()
    {
        Instantiate(objectToSpawn, spawnPostion, transform.rotation);
    }

    void Update()
    {
        
    }
}
