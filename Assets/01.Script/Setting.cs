using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{



    public void SettingOn()
    {
        gameObject.transform.DOScale(0.01f, 0.1f);
        gameObject.transform.DOScaleY(1, 0.5f);
        gameObject.transform.DOScaleX(1, 0.6f).SetDelay(0.6f);
    }
    public void SettingOff()
    {
        gameObject.transform.DOScaleX(0.01f, 0.5f);
        gameObject.transform.DOScaleY(0, 0.5f).SetDelay(0.6f);
        gameObject.transform.DOScale(0, 1).SetDelay(1.2f);
    }


}
