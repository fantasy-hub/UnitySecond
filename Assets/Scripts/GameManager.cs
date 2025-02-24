using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * @brief ��Ϸ������
 */
public class GameManager : MonoBehaviour
{
    #region ����ģʽ
    // �������� - Unityд���ĵ���ģʽ
    public static GameManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // ת��������
        // ���ڸ��ӳ��������壬�������ų������л�������
        DontDestroyOnLoad(this.gameObject);


        // ͨ��SceneManager��ȡ��ǰ����ĳ���
        //Scene scene = SceneManager.GetActiveScene();
        //Debug.Log("Active scene is '" + scene.name + "'." + scene.buildIndex);

        InitSystem();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // ��ʼ��ϵͳ
    private void InitSystem()
    {
 
        // ���س�����������¼�
        SceneManager.sceneLoaded += sceneLoadedDone;
    }

    #region ��������
    public void LoadScene_01()
    {
        SceneManager.LoadScene("_01_InitialMenu");

    }

    public void LoadScene_02()
    {
        SceneManager.LoadScene("_02_ModelSelect");

    }

    public void LoadScene_03()
    {
        SceneManager.LoadScene("_03_Battle_01");

    }

    private void sceneLoadedDone(Scene scene, LoadSceneMode sceneMode)
    {
        Debug.Log("������³������ƣ�" + scene.name);
    }
    #endregion
}
