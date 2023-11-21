using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using DG.Tweening;

public class Flowerinven : MonoBehaviour
{
        GameManager gameManager;
    [SerializeField] int IconNumber;
    [SerializeField] List<GameObject> Changes;
    [SerializeField] GameObject Icons;
    [SerializeField] Image dontHavethis;
    public void Chack()
    {
        gameManager.MoveIcon(IconNumber);
    }
    
    public void ChackOut()
    {
        gameManager.StopIcon(IconNumber);
    }
    public void DontUse()
    {
        dontHavethis.gameObject.transform.DOScale(1, 1f).SetEase(Ease.InOutBounce).SetDelay(1);
        dontHavethis.gameObject.transform.DOScale(0, 1f);
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
