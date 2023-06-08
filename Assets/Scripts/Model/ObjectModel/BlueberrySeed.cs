using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class BlueberrySeed : Seed
    {
        public BlueberrySeed(int amount = 0)
        {
            SeedName = "Blueberry Seed";
            CropCycleTime = 60 * 15;
            ProductCycleAmount = 1;
            MaxCrops = 40;
            _amount = amount;
        }
    }

}
