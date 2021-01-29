using UnityEngine;

public class Spawn_DamageItem : MonoBehaviour
{

    public GameObject damageItemPrefab;
    public GameObject parentDamageSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;

    void Start()
    {
        SpawnTheDamageItems();
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheDamageItems();
        }
    }

    private void SpawnTheDamageItems()
    {
        var clones = Instantiate(damageItemPrefab);
        clones.GetComponent<Transform>().SetParent(parentDamageSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}