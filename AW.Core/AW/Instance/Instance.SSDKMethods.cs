// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;

namespace AW
{
    partial class Instance
    {
        public Result HudCreate(Hud hud)
        {
            SetInstance();
            hud.ToInstance(this);
            return (Result)NativeMethods.aw_hud_create();
        }
    }
}