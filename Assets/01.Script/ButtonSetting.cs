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
    [SerializeField] private Color fadeOutcolor;
    [SerializeField] private Color fadeIncolor;



    public void ChageScense()
    {
        StartCoroutine(MoveScene());
    }

    IEnumerator MoveScene()
    {
        FadeOut();
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(sceneNumber);
    }

    public void FadeOut()
    {
        Fade.gameObject.SetActive(true);
        Fade.DOColor(fadeOutcolor, 2);
    }

    public void FadeIn()
    {
        Fade.DOColor(fadeIncolor, 2);
        Fade.gameObject.SetActive(false);
    }
}
