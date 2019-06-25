using IPA;
using IPA.Config;
using IPA.Utilities;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;
using Harmony;

namespace RumbleController
{
    public class Plugin : IBeatSaberPlugin
    {
        internal static Ref<PluginConfig> config;
        internal static IConfigProvider configProvider;

        static NoteCutHapticEffect noteCutHapticEffect;
        static HapticFeedbackController hapticFeedbackController;
        static SaberClashEffect saberClashEffect;
        static ObstacleSaberSparkleEffectManager ObstacleSaberSparkleEffectManager;
        static NoteCutEffectSpawner NoteCutEffectSpawner;


        public void Init(IPALogger logger, [Config.Prefer("json")] IConfigProvider cfgProvider)
        {
            Logger.log = logger;
            configProvider = cfgProvider;

            config = cfgProvider.MakeLink<PluginConfig>((p, v) =>
            {
                if (v.Value == null || v.Value.RegenerateConfig)
                    p.Store(v.Value = new PluginConfig() { RegenerateConfig = false });
                config = v;
            });
        }

        public void OnApplicationStart()
        {
            Logger.log.Debug("OnApplicationStart");
            var harmony = HarmonyInstance.Create("com.company.project.product");
            harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
        }

        public void OnApplicationQuit()
        {
            Logger.log.Debug("OnApplicationQuit");
        }

        public void OnFixedUpdate()
        {

        }

        public void OnUpdate()
        {

        }

        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {

        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
            if (scene.name == "MenuCore")
                BasicUI.CreateGameplayOptionsUI();
            
        }

        public void OnSceneUnloaded(Scene scene)
        {

        }
    }
}
