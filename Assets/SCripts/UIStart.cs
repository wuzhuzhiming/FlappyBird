using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIStart : MonoBehaviour {

    //开始界面
    public GameObject panelStart;
    //说明界面
    public GameObject panelRate;
    //排行榜界面
    public GameObject panelRank;

    //点击打开说明界面
    public void OnPanelStartBtnRateClick()
    {
        if (!panelRate.activeSelf)
        {
            panelRate.SetActive(true);
        }
        if (panelStart.activeSelf)
        {
            panelStart.SetActive(false);
        }
    }

    //点击打开排行榜界面
    public void OnPanelStartBtnRankClick()
    {
        if (!panelRank.activeSelf)
        {
            panelRank.SetActive(true);
        }
        if (panelStart.activeSelf)
        {
            panelStart.SetActive(false);
        }
    }

    //点击排行榜界面的返回按钮
    public void OnPanelRankBtnBackClick()
    {
        if (panelRank.activeSelf)
        {
            panelRank.SetActive(false);
        }
        if (!panelStart.activeSelf)
        {
            panelStart.SetActive(true);
        }
    }

    //点击开始游戏
    public void OnStartGameClick()
    {
        SceneManager.LoadScene("Main");
    }
}
