using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @����ʼ�������е�UI
 */
public class StartGamePanel : MonoBehaviour
{
    public Button StartGameBtn;

    // Start is called before the first frame update
    void Start()
    {
        StartGameBtn.onClick.AddListener(StiartGameBtnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StiartGameBtnClick()
    {
        Debug.Log("StiartGameBtnClick");
        GameManager.LoadScene_02();
    }
}
