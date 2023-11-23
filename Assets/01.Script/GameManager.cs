using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    Vector3 mousPoint;
    bool ExitChack = false;

    public static GameManager instance;
    [SerializeField] GameObject Pedro;
    [SerializeField] GameObject ingameScene;
    [SerializeField] GameObject growScene;
    [SerializeField] List<GameObject> grows;
    [SerializeField] public List<GameObject> Changes;
    [SerializeField] Image Exit;
     public float textDelay = 0;

    private Camera mainCam;
    private void Awake()
    {
        instance = this;

        mainCam = Camera.main;
    }
    private void Update() 
    {

        textDelay += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!ExitChack)
            {
                Exit.gameObject.SetActive(true);
                Exit.gameObject.transform.DOScale(1, 1f);
                ExitChack = true;
            }
            else if(ExitChack)
            {
                Exit.gameObject.transform.DOScale(0, 1f);
                StartCoroutine(waitTime());
                Exit.gameObject.SetActive(false);
                ExitChack = false;

            }

        }


        if (Input.GetKeyDown(KeyCode.DownArrow)) //화면 하단이동
        {
            MapMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //화면 상단 이동
        {
            MapMoveDown();
        }

        mousPoint = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
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

    public void StopIcon(int a, Vector2 seedTransform)
    {
        grows[a].gameObject.transform.position = seedTransform;
    }


    IEnumerator waitTime()
    {
       yield return new WaitForSecondsRealtime(1);
    }
}
