using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyFarm
{
    public class AppStateGameplay : IState
    {
       public bool IsInitialized => _isInitialized;
        private bool _isInitialized;
        private int _currentLandId;
        public void Initialize()
        {
            _isInitialized = true;
            Debug.Log("AppStateGameplay");
            SceneManager.LoadScene("gameplay");
        }

        public void Exit()
        { }
        public void Resume()
        { }
        public void Clear()
        { }
    }

}
