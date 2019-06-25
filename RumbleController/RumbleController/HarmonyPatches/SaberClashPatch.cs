using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using UnityEngine;
using UnityEngine.XR;

namespace RumbleController.HarmonyPatches
{
    class SaberClashPatch
    {
        [HarmonyPatch(typeof(SaberClashEffect))]
        [HarmonyPatch("Update")]
        class saberClashPatch
        {
            static bool Prefix(SaberClashChecker ____saberClashChecker, HapticFeedbackController ____hapticFeedbackController, ref SaberClashEffect __instance, ParticleSystem ____glowParticleSystem, ref ParticleSystem.EmissionModule ____sparkleParticleSystemEmmisionModule, ref ParticleSystem.EmissionModule ____glowParticleSystemEmmisionModule, ref bool ____sabersAreClashing)
            {
                if (PluginConfig.saberClash == false)
                {
                    if (____saberClashChecker.sabersAreClashing)
                    {
                        __instance.transform.position = ____saberClashChecker.clashingPoint;
                       // ____hapticFeedbackController.ContinuousRumble(XRNode.LeftHand);
                       // ____hapticFeedbackController.ContinuousRumble(XRNode.RightHand);
                        if (!____sabersAreClashing)
                        {
                            ____sabersAreClashing = true;
                            ____sparkleParticleSystemEmmisionModule.enabled = true;
                            ____glowParticleSystemEmmisionModule.enabled = true;
                            return true;
                        }
                    }
                    else if (____sabersAreClashing)
                    {
                        ____sabersAreClashing = false;
                        ____sparkleParticleSystemEmmisionModule.enabled = false;
                        ____glowParticleSystemEmmisionModule.enabled = false;
                        ____glowParticleSystem.Clear();
                    }
                    return false;
                }
                else
                    return true;
            }
        }
    }
}
