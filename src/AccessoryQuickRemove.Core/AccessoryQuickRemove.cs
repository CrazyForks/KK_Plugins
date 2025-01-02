﻿using BepInEx;
using BepInEx.Configuration;
using ChaCustom;
using KKAPI;
using KKAPI.Maker;
using UnityEngine;

namespace KK_Plugins
{
    [BepInDependency(KoikatuAPI.GUID, KoikatuAPI.VersionConst)]
    [BepInPlugin(GUID, PluginName, Version)]
    public class AccessoryQuickRemove : BaseUnityPlugin
    {
        public const string GUID = "com.deathweasel.bepinex.accessoryquickremove";
        public const string PluginName = "Accessory Quick Remove";
        public const string PluginNameInternal = Constants.Prefix + "_AccessoryQuickRemove";
        public const string Version = "1.0";

        public static ConfigEntry<KeyboardShortcut> RemoveHotkey { get; private set; }

        private void Awake()
        {
            RemoveHotkey = Config.Bind("Keyboard Shortcuts", "Remove Hotkey", new KeyboardShortcut(KeyCode.Delete), "Key which removes selected accessories when pressed in the character maker");
        }

        private void Update()
        {
            if (RemoveHotkey.Value.IsDown() && MakerAPI.InsideAndLoaded)
            {
                var customChangeMainMenu = FindObjectOfType<CustomChangeMainMenu>();
                if (customChangeMainMenu.items[4].tglItem.isOn) //Accessory tab is selected
                    //Set the Type dropdown to the "None" option which removes the accessory
                    AccessoriesApi.GetMakerAccessoryPageObject(AccessoriesApi.SelectedMakerAccSlot).GetComponent<CvsAccessory>().ddAcsType.value = 0;
            }
        }
    }
}
