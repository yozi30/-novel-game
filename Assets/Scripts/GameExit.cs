using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameExit : MonoBehaviour
{
    public void ClickExitButton()
    {
        #if UNITY_EDITOR
        // Unityエディターでの動作
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // 実際のゲーム終了処理
        Application.Quit();
        #endif
    }
}