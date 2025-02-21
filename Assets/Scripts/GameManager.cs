using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * @brief 游戏管理器
 */
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 转场不销毁
        // 属于附加场景的物体，不会随着场景的切换而销毁
        DontDestroyOnLoad(this.gameObject);


        // 通过SceneManager获取当前激活的场景
        //Scene scene = SceneManager.GetActiveScene();
        //Debug.Log("Active scene is '" + scene.name + "'." + scene.buildIndex);

        InitSystem();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 初始化系统
    private void InitSystem()
    {
 
        // 挂载场景更新完成事件
        SceneManager.sceneLoaded += sceneLoadedDone;
    }

    #region 场景加载
    public static void LoadScene_01()
    {
        SceneManager.LoadScene("_01_InitialMenu");

    }

    public static void LoadScene_02()
    {
        SceneManager.LoadScene("_02_ModelSelect");

    }

    public static void LoadScene_03()
    {
        SceneManager.LoadScene("_03_Battle_01");

    }

    private void sceneLoadedDone(Scene scene, LoadSceneMode sceneMode)
    {
        Debug.Log("进入的新场景名称：" + scene.name);
    }
    #endregion
}
