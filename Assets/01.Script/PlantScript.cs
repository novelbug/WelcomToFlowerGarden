using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    Flowerinven inven;
    [SerializeField] Vector3 sellPosition;

    private void Update()
    {
        if(inven.getUpflower == true)
        {
            gameObject.transform.position = sellPosition;
        }
    }
}
