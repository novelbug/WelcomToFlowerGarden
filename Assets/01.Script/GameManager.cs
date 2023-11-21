using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    Vector3 mousPoint;

    public static GameManager instance;
    [SerializeField] GameObject Pedro;
    [SerializeField] GameObject ingameScene;
    [SerializeField] GameObject growScene;
    [SerializeField] List<GameObject> grows;
    [SerializeField] public List<GameObject> Changes;

    private Camera mainCam;
    private void Awake()
    {
        instance = this;

        mainCam = Camera.main;
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) //ȭ�� �ϴ��̵�
        {
            MapMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //ȭ�� ��� �̵�
        {
            MapMoveDown();
        }

        mousPoint = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void SpawnPadro() //���� ��ȯ
    {
        Pedro.transform.DOMove(Vector3.up, 1).SetEase(Ease.OutBounce);
    }

    public void MovePadro() //���� ������ �̵�
    {
        Pedro.transform.DOScale(0.2f,2);
        Pedro.transform.DOMove(new Vector3(6,2,0), 2);

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
        grows[a].gameObject.transform.position = mousPoint;
    }

    public void StopIcon(int a)
    {
        
    }

}
