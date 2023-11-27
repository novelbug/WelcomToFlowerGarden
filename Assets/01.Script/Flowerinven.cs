using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Flowerinven : MonoBehaviour
{
    Seed seed;

    private bool _isAttached = false;
    public bool getUpflower = false;
    Vector3 SeedTransform;
    [SerializeField] int IconNumber;
    [SerializeField] GameObject Icons;
    [SerializeField] Image dontHavethis;
    [SerializeField] List<GameObject> Growed;
    [SerializeField] GameObject GrowTransform;
    [SerializeField] GameObject ground;


    private void Start()
    {
        SeedTransform = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+9.8f,0);
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
        Onstay();
    }
    public void DontUse()
    {
        dontHavethis.gameObject.SetActive(true);
        dontHavethis.gameObject.transform.DOScale(1, 1f).SetEase(Ease.InBounce);
        dontHavethis.gameObject.transform.DOScale(0, 1f).SetDelay(2);
    }


    
    

    
    public void Onstay()
    {
       GameManager.instance.StopIcon(IconNumber,SeedTransform);

        if( _isAttached)
        {
            Seed.instance.groundPrefab.gameObject.SetActive(true);
            Seed.instance.groundList[IconNumber].gameObject.SetActive(true);
           
            GrowFlower();
        }
        else
        {
            GameManager.instance.grows[IconNumber].gameObject.transform.position = SeedTransform;
        }    
        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pot"))
        {
            _isAttached = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Pot"))
        {
            _isAttached = false;
        }
    }


    private void GrowFlower()
    {
       
        Seed.instance.groundList[IconNumber].gameObject.transform.DOScale(0.3f,0.5f).SetDelay(10).SetEase(Ease.InBounce);
        Seed.instance.groundList[IconNumber].gameObject.transform.DOScale(0.6f,0.5f).SetDelay(20).SetEase(Ease.InBounce);
        Seed.instance.groundList[IconNumber].gameObject.transform.DOScale(1,0.5f).SetDelay(30).SetEase(Ease.InBounce);
        getUpflower = true;
    }



}
