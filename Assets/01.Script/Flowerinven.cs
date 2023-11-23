using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Flowerinven : MonoBehaviour
{
    bool DropIcorn = false;
    Vector2 SeedTransform;
    [SerializeField] int IconNumber;
    [SerializeField] GameObject Icons;
    [SerializeField] Image dontHavethis;
    [SerializeField] List<GameObject> Growed;
    [SerializeField] GameObject GrowTransform;


    private void Start()
    {
        SeedTransform = gameObject.transform.position;
    }

    private void Update()
    {
        
    }
    public void Chack()
    {
        GameManager.instance.MoveIcon(IconNumber);
    }
    
    public void ChackOut()
    {
        DropIcorn = true;
    }
    public void DontUse()
    {
        dontHavethis.gameObject.SetActive(true);
        dontHavethis.gameObject.transform.DOScale(1, 1f).SetEase(Ease.InBounce);
        dontHavethis.gameObject.transform.DOScale(0, 1f).SetDelay(2);
    }


    public void ChangeFlower()
    {
        GameManager.instance.Changes[0].gameObject.layer = 2;
        GameManager.instance.Changes[1].gameObject.layer = 0;
        GameManager.instance.Changes[2].gameObject.layer = 0;

    }
    public void ChangeSun()
    {
        GameManager.instance.Changes[0].gameObject.layer = 0;
        GameManager.instance.Changes[1].gameObject.layer = 2;
        GameManager.instance.Changes[2].gameObject.layer = 0;
    }

    public void ChangeBug()
    {
        GameManager.instance.Changes[0].gameObject.layer = 0;
        GameManager.instance.Changes[1].gameObject.layer = 0;
        GameManager.instance.Changes[2].gameObject.layer = 2;
    }
    public void Onstay(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pot") && DropIcorn)
        {
            Destroy(gameObject);
            DropIcorn = false;
        }
        else if (DropIcorn && collision)
        {
            Debug.Log("adf");
            GameManager.instance.StopIcon(IconNumber,SeedTransform);
            DropIcorn = false;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Onstay(collision);
    }





}
