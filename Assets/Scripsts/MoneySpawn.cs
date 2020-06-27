using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    public bool spawned = false;

    public GameObject prefabCoin;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && !spawned)
        {
            for(int i = 0; i < 10; i++)
            {
                Instantiate(prefabCoin, randomVector3(), Quaternion.identity);
            }
            spawned = true;
        }
    }

    private Vector3 randomVector3()
    {
        float randomX = Random.Range(-7f, 7f);
        float randomz = Random.Range(-7f, 7f);

        return new Vector3(randomX, prefabCoin.transform.position.y, randomz);

    }
}
