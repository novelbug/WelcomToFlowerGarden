using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Flowerinven : MonoBehaviour
{
        GameManager gameManager;
    [SerializeField] int IconNumber;
    [SerializeField] List<GameObject> Changes;
    [SerializeField] GameObject Icons;
    public void Chack()
    {
        gameManager.MoveIcon(IconNumber);
    }
    
    public void ChackOut()
    {
        gameManager.StopIcon(IconNumber);
    }


    public void ChangeFlower()
    {

    }
    public void ChangeSun()
    {

    }

    public void ChangeBug()
    {

    }

}
