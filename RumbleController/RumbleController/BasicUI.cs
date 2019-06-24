using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomUI.GameplaySettings;

namespace RumbleController
{
    class BasicUI
    {
        public static void CreateGameplayOptionsUI()
        {
            var pluginSubmenu = GameplaySettingsUI.CreateSubmenuOption(GameplaySettingsPanels.ModifiersLeft, "RumbleController", "MainMenu", "RumbleController");

            var enabled = GameplaySettingsUI.CreateToggleOption(GameplaySettingsPanels.ModifiersLeft, "Enable Plugin", "RumbleController", "Toggles the plugin");
          //  enabled.GetValue = PluginConfig.enabled;
          //  enabled.OnToggle += (value) => { PluginConfig.enabled = value; };

            var noteCut = GameplaySettingsUI.CreateToggleOption(GameplaySettingsPanels.ModifiersLeft, "Note Cut Rumble", "RumbleController", "Toggles rumble on note cut");
           // noteCut.GetValue = PluginConfig.noteCut;
          //  noteCut.OnToggle += (value) => { PluginConfig.noteCut = value; };

            var saberClash = GameplaySettingsUI.CreateToggleOption(GameplaySettingsPanels.ModifiersLeft, "Saber Clash Rumble", "RumbleController", "Toggles rumble on sabers clashing");
            //saberClash.GetValue = PluginConfig.saberClash;
           // saberClash.OnToggle += (value) => { PluginConfig.saberClash = value; };

            var obstacleRumble = GameplaySettingsUI.CreateToggleOption(GameplaySettingsPanels.ModifiersLeft, "Wall Rumble", "RumbleController", "Toggles rumble on sabers in walls");
            //obstacleRumble.GetValue = PluginConfig.obstacleRumble;
            //obstacleRumble.OnToggle += (value) => { PluginConfig.obstacleRumble = value; };
        }
    }
}
