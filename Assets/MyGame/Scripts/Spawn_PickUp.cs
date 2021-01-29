using UnityEngine;

public class Spawn_PickUp : MonoBehaviour
{

    public GameObject pickUpPrefab;
    public GameObject parentSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;

    void Start()
    {
        SpawnThePickUps();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnThePickUps();
        }
    }

    private void SpawnThePickUps()
    {
        var clones = Instantiate(pickUpPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
