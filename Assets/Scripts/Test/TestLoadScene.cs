using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 通过SceneManager获取当前激活的场景
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active scene is '" + scene.name + "'." + scene.buildIndex);

        // 挂载场景更新完成事件
        SceneManager.sceneLoaded += sceneLoadedDone;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene("_02_ModelSelect");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("_03_Battle_01");
        }
        */
    }

    public void LoadScene_02()
    {
        SceneManager.LoadScene("_02_ModelSelect");
    }

    private void sceneLoadedDone(Scene scene, LoadSceneMode sceneMode)
    {
        Debug.Log("进入的新场景名称：" + scene.name);
    }
}
