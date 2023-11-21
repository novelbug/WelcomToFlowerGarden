using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //Vector2 mousPoint = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.z, Input.mousePosition.y));
    [SerializeField] GameObject Pedro;
    [SerializeField] GameObject ingameScene;
    [SerializeField] GameObject growScene;
    [SerializeField] List<GameObject> grows;
    private void Awake()
    {
        instance = this;
    }

    public void SpawnPadro() //페드로 소환
    {
        Pedro.transform.DOMove(Vector3.up, 1).SetEase(Ease.OutBounce);
    }

    public void MovePadro() //페드로 옆으로 이동
    {
        Pedro.transform.DOScale(0.2f,2);
        Pedro.transform.DOMove(new Vector3(6,2,0), 2);

    }



    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) //화면 하단이동
        {
            MapMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //화면 상단 이동
        {
            MapMoveDown();
        }

    }

    public void MapMoveUp()
    {
        ingameScene.transform.DOMoveY(7, 1);
        growScene.transform.DOMoveY(7, 1);
    }

    public void MapMoveDown()
    {
        ingameScene.transform.DOMoveY(-3, 1);
        growScene.transform.DOMoveY(-3, 1);
    }

    public void MoveIcon(int a)
    {
        grows[a].gameObject.transform.position = new Vector3(0, 0, 0);
    }

    public void StopIcon(int a)
    {

    }

}
