using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Talk : MonoBehaviour
{
    //������ ����
    public float delay;
    public float Skip_delay;
    public int cnt;

    //Ÿ����ȿ�� ����
    public string[] fulltext;
    public int dialog_cnt;
    string currentText;

    //Ÿ����Ȯ�� ����
    public bool text_exit;
    public bool text_full;
    public bool text_cut;
    public bool inSkip = true;

    public GameObject ButtonUI;


    //���۰� ���ÿ� Ÿ���ν���
    void Awake()
    {
        Get_Typing(dialog_cnt, fulltext);
    }
    private void OnEnable()
    {
        inSkip = true;
    }
    private void OnDisable()
    {
        inSkip = false;
    }

    //��� �ؽ�Ʈ ȣ��Ϸ�� Ż��
    void Update()
    {
        if (text_full == true)
        {
            ButtonUI.SetActive(true);
        }
        else if (text_full == false)
        {
            ButtonUI.SetActive(false);
        }

        if (text_exit == true)
        {
            transform.parent.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.T) && inSkip == true)
        {
            End_Typing();
        }

    }

    //������ư�Լ�
    public void End_Typing()
    {
        //���� �ؽ�Ʈ ȣ��
        if (text_full == true)
        {
            cnt++;
            text_full = false;
            text_cut = false;
            StartCoroutine(ShowText(fulltext));
        }
        //�ؽ�Ʈ Ÿ���� ����
        else
        {
            text_cut = true;
        }
    }




    //�ؽ�Ʈ ����ȣ��
    public void Get_Typing(int _dialog_cnt, string[] _fullText)
    {
        //������ ���� �����ʱ�ȭ
        text_exit = false;
        text_full = false;
        text_cut = false;
        cnt = 0;

        //���� �ҷ�����
        dialog_cnt = _dialog_cnt;
        fulltext = new string[dialog_cnt];
        fulltext = _fullText;

        //Ÿ���� �ڷ�ƾ����
        StartCoroutine(ShowText(fulltext));
    }

    IEnumerator ShowText(string[] _fullText)
    {
        //����ؽ�Ʈ ����
        if (cnt >= dialog_cnt)
        {
            text_exit = true;
            StopCoroutine("showText");
        }
        else
        {
            //��������clear
            currentText = "";
            //Ÿ���� ����
            for (int i = 0; i < _fullText[cnt].Length; i++)
            {
                //Ÿ�����ߵ�Ż��
                if (text_cut == true)
                {
                    break;
                }
                //�ܾ��ϳ������
                currentText = _fullText[cnt].Substring(0, i + 1);
                this.GetComponentInChildren<TextMeshPro>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
            //Ż��� ��� �������
            Debug.Log("Typing ����");
            this.GetComponentInChildren<TextMeshPro>().text = _fullText[cnt];
            yield return new WaitForSeconds(Skip_delay);

            //��ŵ_������ ����
            Debug.Log("Enter ���");
            text_full = true;
        }
    }
}

