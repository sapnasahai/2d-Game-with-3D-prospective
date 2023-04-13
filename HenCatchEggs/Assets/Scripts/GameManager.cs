using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject egg_prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnpoint", 2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnpoint()
    {
        float tempPos = Random.Range(-7f, 7f);
        Instantiate(egg_prefab, new Vector3(tempPos, 4.0f, 0), Quaternion.identity);
    }


}
