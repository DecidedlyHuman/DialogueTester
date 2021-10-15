using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace DialogueTester
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        private string _commandName = "dh_testdialogue";
        private string _commandDescription = "Test some modded dialogue.";
        private string _commandUsage = "Usage: dh_testdialogue <dialogue_id> <npc_name>";

        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.ConsoleCommands.Add(_commandName,
                $"{_commandDescription}\n\n{_commandUsage}", this.TestDialogue);
        }

        private void TestDialogue(string command, string[] args)
        {
            string dialogueId, npcName;

            if (args.Length < 2 || args.Length > 2)
            {
                this.Monitor.Log("Invalid number of arguments. ", LogLevel.Warn);

                return;
            }

            dialogueId = args[0];
            npcName = args[1];

            this.Monitor.Log($"Args passed: \nDialogue ID: {dialogueId}\nNPC Name: {npcName}", LogLevel.Info);

            if (!Context.IsWorldReady)
                return;
            
            
        }
    }
}