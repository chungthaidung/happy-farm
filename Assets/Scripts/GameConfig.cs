using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HappyFarm.Config
{
    static class GameConfig
    {
        public const int EMPTY_LAND = 0;
        public const int PLANT_TYPE = 1;
        public const int FEED_TYPE = 2;
        public const int LOCKED_PLOT = 10;
        public const int EMPTY_PLOT = 11;
        public const int PLANTED_PLOT = 12;
        public const int UNHARVEST_PLOT = 13;
        public const int HARVEST_TIME = 60*60;
        public const int MAX_PLOT = 5;
    }
    static class TomatoConfig 
    {
        public const int CROP_CYCLE_TIME = 60 * 10;
        public const int PRODUCT_CYCLE_AMOUNT = 1;
        public const int MAX_CROPS = 40;
        public const int PRODUCT_VALUE = 5;
    }
    static class BlueberryConfig 
    {
        public const int CROP_CYCLE_TIME = 60 * 15;
        public const int PRODUCT_CYCLE_AMOUNT = 1;
        public const int MAX_CROPS = 40;
        public const int PRODUCT_VALUE = 8;

    }
    static class StrawberryConfig 
    {
        public const int CROP_CYCLE_TIME = 60 * 5;
        public const int PRODUCT_CYCLE_AMOUNT = 1;
        public const int MAX_CROPS = 20;
        public const int PRODUCT_VALUE = 2;
    }
}


