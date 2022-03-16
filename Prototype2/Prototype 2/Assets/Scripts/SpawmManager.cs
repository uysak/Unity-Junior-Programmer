using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawmManager : MonoBehaviour
{
    [SerializeField] GameObject[] AnimalPrefabs;


    Vector3 randomAnimalPosition;

    private int spawmRangeX = 22;
    private int spawmPositionZ = 20;
    private int indexRandomAnimal;
    private float spawmDelay = 2f;
    private float spawmInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawmRandomAnimal", spawmDelay, spawmInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawmRandomAnimal()
    {
        indexRandomAnimal = Random.RandomRange(0,AnimalPrefabs.Length);
        randomAnimalPosition = new Vector3(Random.RandomRange(-spawmRangeX, spawmRangeX), 0, spawmPositionZ);

        Instantiate(AnimalPrefabs[indexRandomAnimal], randomAnimalPosition, AnimalPrefabs[indexRandomAnimal].transform.rotation);
        Debug.LogError(Time.deltaTime);
    }
}
