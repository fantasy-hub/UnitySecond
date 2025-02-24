using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGamePanel : MonoBehaviour
{
    public Button StartGameBtn;

    // Start is called before the first frame update
    void Start()
    {
        StartGameBtn.onClick.AddListener(handleStartGameBtnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void handleStartGameBtnClick()
    {
        GameManager.Instance.LoadScene_02();
    }
}
