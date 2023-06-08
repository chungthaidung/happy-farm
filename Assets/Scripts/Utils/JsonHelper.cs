using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json;


namespace HappyFarm.Utils
{
    public class JsonHelper
    {
        public static T[] getJsonArray<T>(string json)
        {
            string newJson = "{ \"array\": " + json + "}";
            Wrapper<T> wrapper = JsonConvert.DeserializeObject<Wrapper<T>>(newJson);
            
            return wrapper.array;
        }

        public static string arrayToJson<T>(T[] array)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.array = array;
            return JsonConvert.SerializeObject(wrapper);
        }

        [System.Serializable]
        private class Wrapper<T>
        {
            public T[] array;
        }
    }

}
