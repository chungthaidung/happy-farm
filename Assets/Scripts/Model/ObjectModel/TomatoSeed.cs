using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class TomatoSeed : Seed
    {
        public TomatoSeed(int amount = 0)
        {
            SeedName = "Tomato Seed";
            CropCycleTime = 60 * 10;
            ProductCycleAmount = 1;
            MaxCrops = 40;
            _amount = amount;

        }
    }

}
