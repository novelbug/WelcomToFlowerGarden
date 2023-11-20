using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject Pedro;
    [SerializeField] GameObject ingameScene;
    [SerializeField] GameObject growScene;
    private void Awake()
    {
        instance = this;
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
    

}
