using static CitizenFX.Core.Native.API;
using CitizenFX.Core;
using System;
using CitizenFX.Core.Native;
using System.Collections.Generic;

namespace BaseS.Client
{
    public class ClientScript : BaseScript
    {

        public ClientScript()
        {
            // Regitser Commands Like This
            API.RegisterCommand("test", new Action<int, List<object>, string>(testCommand), false);
        }

        // Command Methods will be like this
        private void testCommand(int source, List<object> arguments, string content)
        {
            string message = "";
            foreach (var arg in arguments)
            {
                message += (string)arg + " ";
            }
        }

    }
}
