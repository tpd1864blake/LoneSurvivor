using System.ComponentModel;
using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace LoneSurvivor
{
    class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Should the plugin use Hints instead of Broadcasts?")]
        public bool UseHints { get; set; } = false;
        [Description("How long should the message last?")]
        public ushort BroadcastDuration { get; set; } = 10;
        [Description("Possible messages Class-D can see when they're the last alive")]
        public List<string> ClassDMessages { get; set; } = new List<string>() { "You are the last Class-D alive!"};
        [Description("Possible messages Scientists can see when they're the last alive")]
        public List<string> ScientistMessages { get; set; } = new List<string>() { "You are the last Scientist alive!" };
        [Description("Possible messages MTF can see when they're the last alive")]
        public List<string> MTFMessages { get; set; } = new List<string>() { "You are the last MTF alive!" };
        [Description("Possible messages Chaos Insurgency can see when they're the last alive")]
        public List<string> ChaosMessages { get; set; } = new List<string>() { "You are the last Chaos Insurgent alive!" };
        [Description("Possible messages SCPs can see when they're the last alive")]
        public List<string> ScpMessages { get; set; } = new List<string>() { "You are the last SCP alive!" };
        [Description("Possible messages Tutorials can see when they're the last alive, for plugins like Serpent's Hand")]
        public List<string> TutorialMessages { get; set; } = new List<string>() {  };
        [Description("Possible messages Spectators can see when they're the only one dead. idk maybe you have a use :/")]
        public List<string> SpectatorMessages { get; set; } = new List<string>() {  };
    }
}
