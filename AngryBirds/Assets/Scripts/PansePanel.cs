using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PansePanel : MonoBehaviour
{

    private Animator anim;
    public GameObject button;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }


    public void Pause()
    {
        //1,播放pause动画
        anim.SetBool("isPause", true);
        button.SetActive(false);
    }


    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }


    /// <summary>
    /// 点击了继续按钮
    /// </summary>
    public void Resume()
    {
        //播放resume动画
        Time.timeScale = 1;
        anim.SetBool("isPause", false);
    }


    /// <summary>
    /// paese动画播放完调用
    /// </summary>
    public void PauseAnimEnd()
    {
        Time.timeScale = 0;
    }
    /// <summary>
    /// resume动画播放完调用
    /// </summary>
    public void ResumeAnimEnd()
    {
        button.SetActive(true);
    }
}
