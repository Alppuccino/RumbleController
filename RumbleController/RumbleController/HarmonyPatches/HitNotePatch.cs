using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;

namespace RumbleController.HarmonyPatches
{
    class HitNotePatch
    {
        [HarmonyPatch(typeof(NoteCutHapticEffect))]
        [HarmonyPatch("HitNote")]
        class noteCutPatch
        {
            static bool Prefix(Saber.SaberType saberType)
            {
                if (PluginConfig.noteCut == false && PluginConfig.enabled)
                    return false;
                else
                    return true;
            }

        }
    }
}