using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField] GameObject groundPrefab;
    [SerializeField] List<GameObject> groundList;
    [SerializeField] Vector2 Seedposition;

    public void SeedFlower()
    {
            groundPrefab.transform.position = Seedposition;
    }
}
