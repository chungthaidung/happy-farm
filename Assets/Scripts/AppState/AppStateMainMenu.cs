using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace HappyFarm
{
    public class AppStateMainMenu : IState
    {
        public bool IsInitialized => _isInitialized;
        private bool _isInitialized;
        public void Initialize()
        {
            _isInitialized = true;
            Debug.Log("AppStateMainMenu");
            SceneManager.LoadScene("mainmenu");
        }

        public void Exit()
        { }
        public void Resume()
        { }
        public void Clear()
        { }
    }

}
