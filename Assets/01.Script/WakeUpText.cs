using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class WakeUpText : MonoBehaviour
{
    [SerializeField] Image talkBox;
    [SerializeField] TextMeshProUGUI _talkBox;
    [SerializeField] TextMeshProUGUI _nameBox;
    [SerializeField] List<string> _talk;
    [SerializeField] List<string> _name;
    [SerializeField] Image TextBar;
    ButtonSetting fadesystem;
    int _talkCount = 0;
    int _nameCount = 0;
    float textDelayTime = 0;
    


    private void Awake()
    {
        fadesystem = GetComponentInParent<ButtonSetting>();
        
    }

    public void TalkStart()
    {
        if(GameManager.instance.textDelay > textDelayTime)
        {
            
            _talkBox.DOText(" ",0);
            _talkBox.DOText(_talk[_talkCount], 2);
            _nameBox.text = _name[_nameCount];
            _talkCount++;
            if( _talkCount == 2)
            {
                fadesystem.FadeIn();
                GameManager.instance.SpawnPadro();
            }
            if( _talkCount == 5) 
            {
                talkBox.transform.DOScale(0,1).SetDelay(3).SetEase(Ease.InBounce);
                GameManager.instance.MovePadro();
            }
            GameManager.instance.textDelay = 0;
            textDelayTime = 2;
        }
        
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2);
    }


    public void HelpPedro()
    {
            talkBox.transform.DOScale(1,1).SetEase(Ease.InBounce);

    }
}
