﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State
{
    public interface IPlayerState
    {
        void Execute(Player player);
    }
}
