using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace HappyFarm.Utils
{
    public class ObjectPool : MonoBehaviour
    {
        private string _folderPrefabs = "Prefabs";
        public static ObjectPool Instance;
        [SerializeField]
        public List<GameObject> _prefabs = new List<GameObject>();
        private List<GameObject> _pool = new List<GameObject>();
        private void Start() {
            Instance = this;
        }
        public List<GameObject> Pool
        {
            get { return _pool; }
        }

        public GameObject GetFromPool<T>(string prefabName)
        {
            List<GameObject> _listObj = _pool.FindAll(obj => obj!= null && obj.GetComponent<T>() != null && !obj.activeInHierarchy);
            if (_listObj.Count > 0)
            {
               GameObject _target = _pool[_pool.FindIndex(obj => obj.GetComponent<T>() != null && !obj.activeInHierarchy)];
                if (_target != null)
                {
                    return _target;
                }
            }
            else
            {
                // int prefabIndex = _prefabs.FindIndex(obj => obj.GetComponent<T>() != null);
                // GameObject _target = _prefabs[prefabIndex];
                GameObject _prefab = Resources.Load<GameObject>(_folderPrefabs+"/"+prefabName);
                if (_prefab != null)
                {
                    GameObject newObj = Instantiate(_prefab);
                    newObj.SetActive(true);
                    _pool.Add(newObj);
                    return newObj;
                }
            }
            return null;
        }
        public void ReturnToPool(GameObject obj)
        {
            PrefabUtility.ResetToPrefabState(obj);
            obj.SetActive(false);
        }
    }
}

