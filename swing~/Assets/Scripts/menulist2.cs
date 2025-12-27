using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menulist2 : MonoBehaviour
{
    public GameObject menuList;
    [SerializeField] private bool menuKeys = true;
    [SerializeField] private AudioSource bgmSound;

    // Start is called before the first frame update
    void Start()
    {
        // 确保初始状态下鼠标锁定并隐藏
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (menuKeys)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                OpenMenu();
            }
        }
        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            CloseMenu();
        }
    }

    public void OpenMenu()
    {
        menuList.SetActive(true);
        menuKeys = false;
        Time.timeScale = 0; // 暂停游戏
        bgmSound.Pause();

        // 解锁鼠标并显示
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseMenu()
    {
        menuList.SetActive(false);
        menuKeys = true;
        Time.timeScale = 1; // 恢复游戏
        bgmSound.Play();

        // 锁定鼠标并隐藏
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Return()
    {
        CloseMenu();
    }

    public void Restart()
    {
        Time.timeScale = 1; // 确保重新加载时游戏恢复正常速度
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
