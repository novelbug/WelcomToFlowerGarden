using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    static public Seed instance;
    [SerializeField] public GameObject groundPrefab;
    [SerializeField] public List<GameObject> groundList;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void getFlower()
    {
           
    }
}
