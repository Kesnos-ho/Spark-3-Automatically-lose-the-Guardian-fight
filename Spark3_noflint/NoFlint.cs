using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using HarmonyLib;

namespace Spark3FlintInstantDeath
{
    public class FlintInstantDeath : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
            if (sceneName == "[STAGE 02 - BOSS FLINT]"|| sceneName == "[STAGE 03 - BOSS FLINT SECOND]")
            {
                HurtControl hurtControl = GameObject.Find("Player_Fark").GetComponent<HurtControl>();
                hurtControl.isDead=true;
            }
            }

    }
}
