using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade
{
    public class Home
    {
        private AudioSystem audioSystem = new AudioSystem();
        private HomeSecuritySystem homeSecuritySystem = new HomeSecuritySystem();
        private Lights lights = new Lights();
        private TV tv = new TV();

        public void Leave()
        {
            audioSystem.SwitchOff();
            homeSecuritySystem.Enable();
            lights.SwitchOff();
            tv.SwitchOff();
        }

        public void Arrive()
        {
            audioSystem.SwitchOn();
            homeSecuritySystem.Disable();
            lights.SwitchOn();
            tv.SwitchOn();
        }
    }
}
