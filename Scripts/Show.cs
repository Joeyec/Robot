using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{
    public GameObject[] Descriptions;
    public GameObject[] DescriptionsFront;
    public GameObject[] DescriptionsBack;
    public GameObject Robot;
    public Text ShowAllText;
    public Text ShowFrontText;
    public Text ShowBackText;
    public Text MoveText;
    private bool isShowAll = false;
    private bool isShowFront = false;
    private bool isShowBack = false;
    private bool isMove = false;

    public void ShowAll()
    {
        isShowAll = !isShowAll;
        if (isShowAll)
            ShowAllText.text = "全部隐藏";
        else
            ShowAllText.text = "全部显示";
        for (int i = 0; i < Descriptions.Length; i++)
        {
            Descriptions[i].SetActive(isShowAll);
        }
    }
    public void ShowFront()
    {
        isShowFront = !isShowFront;
        if (isShowFront)
            ShowFrontText.text = "正面全部隐藏";
        else
            ShowFrontText.text = "正面全部显示";
        for (int i = 0; i < DescriptionsFront.Length; i++)
        {
            DescriptionsFront[i].SetActive(isShowFront);
        }
    }

    public void ShowBack()
    {
        isShowBack = !isShowBack;
        if (isShowBack)
            ShowBackText.text = "背面全部隐藏";
        else
            ShowBackText.text = "背面全部显示";
        for (int i = 0; i < DescriptionsBack.Length; i++)
        {
            DescriptionsBack[i].SetActive(isShowBack);
        }
    }

    public void Move()
    {
        isMove = !isMove;
        if (isMove)
            MoveText.text = "固定机器人";
        else
            MoveText.text = "移动机器人";
        Robot.GetComponent<TwoHandManipulatable>().enabled = isMove;
    }
}
