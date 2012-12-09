using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AW
{
    public class Hud
    {
        public const int AllUsers = 0;

        public HudType Type;

        /// <summary>
        /// For text element types, sets the string. For image element types, sets the
        /// texture and mask in the following format:
        /// texture.jpg|texture1m.bmp
        /// </summary>
        public string Text;

        public int Id;

        /// <summary>
        /// Who the HUD element is targeted to; use 0 for all users
        /// </summary>
        public int Session;

        public HudOrigin Origin;
        public float Opacity;
        public int X;
        public int Y;
        public int SizeX;
        public int SizeY;
        public int TexOffsetX;
        public int TexOffsetY;
        public int ZOrder;

        public HudFlag Flags;
        public Color Color;

        public void ToInstance(Instance i)
        {
            i.Attributes.HudElementText = Text;
            i.Attributes.HudElementType = Type;
            i.Attributes.HudElementId = Id;
            i.Attributes.HudElementSession = Session;
            i.Attributes.HudElementOrigin = Origin;
            i.Attributes.HudElementOpacity = Opacity;

            i.Attributes.HudElementX = X;
            i.Attributes.HudElementY = Y;
            i.Attributes.HudElementSizeX = SizeX;
            i.Attributes.HudElementSizeY = SizeY;
            i.Attributes.HudElementTextureOffsetX = TexOffsetX;
            i.Attributes.HudElementTextureOffsetY = TexOffsetY;
            i.Attributes.HudElementZ = ZOrder;

            i.Attributes.HudElementFlags = Flags;
            i.Attributes.HudElementColor = Color;
        }
    }
}
