using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class ButtonSetting : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    [SerializeField] private Image Fade;
    [SerializeField] private Color targetcolor;



    public void ChageScense()
    {
        StartCoroutine(MoveScene());
    }

    IEnumerator MoveScene()
    {
        FadOut();
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(sceneNumber);
    }

    public void FadOut()
    {
        Fade.gameObject.SetActive(true);
        Fade.DOColor(targetcolor, 2);
    }
}
