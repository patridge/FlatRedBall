using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Color = Microsoft.Xna.Framework.Color;
namespace FlatRedBall.Content
{
    static class DefaultFontDataColors
    {
        public static Color[] GetColorArray()
        {
			Color a = new Color(){PackedValue = 0};
			Color b = new Color(){PackedValue = 4279966491};
			
			Color[] colors = new Color[]
			{
			a
			,a,a,b,a,a,a,a,a,a,a,a,b,b,a,a,a,a,a,a,a,a,a,a,b,b,b,b,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,b,a
			,a,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,a,a,b,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,b,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a
			,a,b,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,b,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a
			,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,b,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a
			,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,b,b,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a
			,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a
			,b,b,a,b,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,b,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b
			,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b
			,a,a,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a
			,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,b,b,b,b,a,a,a,a,a,b,a,a,a,a,b,a,b,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,b,a,a,b
			,a,a,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,b,b,b,b,b,b,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a
			,b,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,b,a,a,b
			,a,a,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a
			,b,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,b,a,a,b
			,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,b,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a
			,b,a,b,a,a,a,b,b,b,b,a,b,a,a,a,b,b,b,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b
			,a,a,b,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,a,b,b,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a
			,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a
			,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a
			,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a
			,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b
			,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b
			,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a
			,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,b,b,a,a,a,a,a
			,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,b,b,b,b,b,b,a,a,a,b,a,a,b,a,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,b,b,b,b,b,b,a,a,a,b,a,a,b,a,a,a,a
			,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,b,b,b,b,b,a,a,a,a,b,a,a,b,a,a,b,b,b,b,b,b,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,a,a,b,b,b,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,b,a,a,a,b,a,a
			,a,a,b,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,b,a,a,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,b,a,a,a,a,a
			,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,b,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,b,a,a
			,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a
			,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,a,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,a,a,a
			,b,b,b,b,b,a,a,a,b,b,b,b,b,a,a,b,a,a,a,a,a,a,a,a,b,b,b,b,b,a,a,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,b,b,b,b,b,a,a,b,b,b,b,b,b,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,b,a,a,a,a,b,a,b,a,a,b,a,a,b,a,b,b,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,b,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,b,a,b,a,a,b,a,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,a,a,b,a,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,b
			,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,b,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a
			,b,b,b,a,a,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,b,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,b,a,a,b,a,b,a,a,a,a,b,b,a,b,a,a,b,a,a,b,a,b,b,b,b,b,b,a,a,b,a,a,a,a,b,a,a,b,b,b,b,b,b,a,a,a
			,a,a,a,b,b,a,a,a,a,a,a,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,b,b,a,b,a,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a
			,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,b,b,b,b,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,b
			,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,b
			,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,b,b,a,a,a,a,b,b,a,a,a,b,a,a,a,a,b,b,a,b,a,a,a,a,b,a,a,a,a,a,b,b,a,a,a,b,a,a,a,a,b,a,a,b
			,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a
			,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,a,a,a,a,b,b,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a
			,b,b,b,b,b,a,a,a,b,b,b,b,b,a,a,a,a,b,b,b,a,a,a,a,b,b,b,b,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a
			,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,a,b,a,a,b,b,a,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,a
			,a,a,a,a,b,b,b,a,a,a,a,a,a,a,b,b,b,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,b,a,a,a,a,b,b,b,b,b,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a
			,a,b,b,a,a,a,a,a,b,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,a,a,b,b,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,b,b,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a
			,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a
			,a,a,a,a,b,b,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,b,b,b,b,a,b,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,b,b,b,b,b,a,a,b,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,b,b,a,a,a,a,b,b,a,b,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a
			,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,b,b,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,b,a,a,a,a,a
			,b,b,a,b,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,b,a,a,b,a,a,b,b,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a
			,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,b,b,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,b,b,a,a,b
			,a,a,b,b,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a
			,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,b,a,b
			,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,b,b,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a
			,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,b,b,a,a,a,b,a,b
			,a,a,a,b,a,a,b,a,b,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a
			,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,b,b,b,b,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,b,a,b,b,a,b
			,a,a,a,b,a,a,b,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,b,a,a,b,b,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,b,b,b,b,b,b,b,a
			,a,a,b,b,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b
			,a,a,b,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,b,b,a,b,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a
			,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a
			,b,b,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,b,a,a,a,a,a,a,a,b
			,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a
			,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,b,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,b,a,a,a,a,a,a,a,b
			,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,b,b,b,b,a,a,a,a,a,a,b,a,b,a,a,b,b,b,b,b,b,b,a,a,a,b,b,b,a,a,a,a,a,b,b,b,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,a,a,b,b,b,a,a,a,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,a,b,b,b,a,a,a,b
			,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,b,a,a,a,a,b,b,b,b,b,b,a,a,a,a,a,b,a,a,a,b,b,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,b,a,a,a,a,b,a,b,a,a,a,b,b,a,a,a,a,b,a,b,a,a,a,a,b,a,a,b,b,b,a,a,a,b,a,b,b,a,b,b,a,a,b,a,b,a,a,b,b,a,b,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,b,b,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,b
			,b,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,a,a,a,b,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,b,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,b,b,b,b,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,a,b,b,b,a,b,b,b,b,b,a,a,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a
			,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,b,a,a,a,a,a,b,a,a,a,b,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,b,a,a,a,a,a,b,b,a,b,b,b,b,b,b,b,b,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a
			,b,a,b,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,b,a,b,a,a,b,a,b,a,a,a,b,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,b,a,a,b,b,b,b
			,a,a,b,a,b,a,a,b,b,b,b,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,b,b,b,a,b,a,b,a,b,a,b,a,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a
			,b,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,b,b,b,b,b,b,b,b,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,b
			,a,a,a,b,a,a,b,b,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a
			,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,b,b,b,b,b,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,b
			,a,a,a,b,a,b,a,a,b,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,b,b,a,a,a,a,b,b,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,b,b,b,b,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,b,b,b,a,a,b,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a
			,a,a,b,a,b,a,a,b,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,b,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,b,a,b,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a
			,b,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,b,b,a,a,b,a,b,a,a,a,a
			,b,a,b,a,b,a,a,b,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,b,b,b,b,b,b,b,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,b,a,a,b,b,b,b,b,b,b,b,a,b,a,a,b,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a
			,b,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,b,a,a,b,b,b,b
			,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a
			,b,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,a,b,a,b,a,a,b,b,b,b,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,b,a,a,b,a,a,b,a,a,a,a,a
			,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,b,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a
			,a,b,a,a,a,b,a,a,b,b,a,a,b,a,a,a,a,b,a,a,a,b,b,a,b,a,b,a,b,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,b,a,a,a,b,b,a,a,a,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,b,b,b,b
			,b,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,b,b,b,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,b,b,a,a,b,b,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,a
			,a,b,a,a,a,a,b,b,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,b,b,b,a,a,b,a,a,b,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,b,b,a,b,b,b,b,b,a,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,b,a,a,a,b,a,a,a,a,b,b,a,b,a,a,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a
			,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,b,b,a,a,a,b,b,b,b,b,b,b,a,a,b,b,b,b,a,a,a,b,b,b,b,a,a,a,b,b,b,b,a,a,a,b,b,b,a,a,a
			,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,a,a,a,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,a,a,b,b,b,b,b,b,a,a,a,b,b,b,b,b,a,a,b,b,b,b,b,b,b,a,b,a,a,a
			,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,b,a,b
			,b,a,a,a,a,a,b,b,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,b,b,b,b,b,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,b,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a
			,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,b,b,b,b,b,b,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,a,b,a,a,b,b,b,b,b,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a
			,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,b,a,b,a,a,a,b,a,a,a,a,b,b,b,b,a,a,a,a,b,b,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a
			,a,b,b,b,b,a,a,a,a,b,b,b,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a
			,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,b,a,a,a,a,b,b,a,a,a,a,a,a,a,b,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,a,b,a,a,a
			,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,b,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a
			,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,b,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,b,b,b,b,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b
			,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,b,b,b,b,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,b,a,a,b,a,b,b,b,b,b,b,a,a,b,b,b,b,b,b,a,a,a,a,a,a,b,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a
			,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,b,a,b,a,a,a,a,b,a,a,a,b,b,a,b,a,a,a,b,a,a,a,b,a,a,a,b,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b
			,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,b,b,b,b,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a
			,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b
			,a,a,a,a,a,a,b,a,b,b,b,b,b,a,a,b,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a
			,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b
			,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,b,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,b
			,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,b,b,a,a,a,a,a,a,a,b,b,a,a,b,b,b,b,a,a,a,a,b,b,b,b,b,b,a,a,a,b,a,a,a,b,a,b,a,a,b,b,a,a,a,a,a,a,b,a,a,a,a,a,b,b,b,b,a,a,b,b,b,b,b,b,a,a,b,b,b,b,a,a,a,b,a,a,a,a,b
			,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,b,b,a,a,a,b,b,b,b,b,a,a,a,b,b,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,b,b,b,b,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,b,a,b,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,b,b,a,a,b,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,b,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,a,b,b,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,b,b,a,a,a,b,b,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a
			,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,b,b,b,b,a,a,a,a,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,a,a,a,b,a,b,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,a,a,b,a,a,b,a,a,a,a,b
			,b,b,b,a,a,a,b,b,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,a,a,a,a,b,b,a,a,a,a,a,b,b,a,a,a,a,b,a,a,b,a,a,a,a,b,b,a,a,a,b,a,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,b,a,a,b,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,a,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a
			,a,b,b,b,b,a,b,a,a,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,b,b,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,b,a,a,a,a,a,a
			,a,b,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,a,b,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,b,b,a,a,b,b,b,b,a,a,a,b,b,b,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b
			,a,b,a,a,a,b,b,b,a,a,a,a,b,a,b,b,a,a,b,a,a,a,a,a,a,b,a,b,b,a,a,a,a,b,a,b,a,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,b,a,a,a,b,a,a,b,b,b,b,b,a,a,a,a,a,a,b,a,b,a,b,b,a,a,a,b,b,a,b,a,b,a,a,a,b,a,b,a,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,a,b,a,a
			,a,a,a,b,a,a,a,b,b,b,b,b,a,a,b,b,b,b,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,a,a,a,b,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,b,a,a
			,b,b,a,a,b,a,a,a,b,a,a,a,b,b,a,a,b,a,b,a,a,b,a,a,a,b,b,a,a,b,a,a,a,b,b,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,b,a,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,b,a,a,b,a,b,a,a,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,b,a,a,a,b,a,a
			,a,a,b,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,b,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a
			,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,b,a,a,a,b,b,a,a,b,a,b,a,a,b,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a
			,a,a,b,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,b,b,b,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a
			,a,b,a,a,b,b,b,b,b,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,a,b,b,b,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,a,b,a,b,a,a,a,b,a,b,b,b,a,a,a,b,a,b,b,a,a,a,b,b,a,b,a,a,a,b,a,a,a,b,b,b,b,b,a,a
			,a,b,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,b,b,b,a,a,b,a,a,a,b,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b,b,b,b,a,a,b,b,b,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a
			,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a
			,a,b,a,b,a,a,b,b,b,b,b,a,a,b,a,b,b,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,b,b,b,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a
			,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a
			,b,a,a,b,a,a,b,a,a,a,a,b,a,b,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,b,b,a,a,a,b,a,a,a,a,b,a,b,a,a,b,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,b
			,b,b,a,a,a,b,b,b,a,a,a,a,b,a,a,a,b,a,b,b,b,b,b,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,a,a,a,a,b,b,a,b,b,b,b,b,a,a,a,b,b,b,a,a,b,b,b,b,a,a,a,b,b,b,b,a,a,b,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,b,b,a,a,a,a,b,a,a,a,a,a,a
			,b,a,a,b,a,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,b,a,a,b,b,b,b,a,a,a,b,b,a,b,a,a,a,b,b,b,a,a,a,a,a,b,a,a,a,a,a,a,b,b,a,a,a,a,b,b,b,a,a,a,a,b,b,b,b,a,a,a,b,b,b,a,a,a,a,b,b,b,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,b,b,b,b,b,a,a,a,a,a,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,b,a,a,a,a,b,a,a,a,b,b,b,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,b,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,b,a,a,b,a,b,a,a,a,b,a,b,a,b,a,b,a,b,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,b,a,b,a,b,a,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a
			,a,a,a,b,a,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,b,b,b,b,a,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,b,b,a,a,b,a,a,b,a,a,a,a,a,b,a,a,b,a,b,b,a,a,b,a,b,b,a,a,a,b,a,b,a,a,a,b,a
			,b,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,b,a,a,b,a,b,a,a,a,b,b,b,a,a,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,b,a,b,b,b,a,b,a,b,a,b,a,a,a,a,b,a,a,a,b,a,a,b,b,a,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,b,a,a,a,b,b,b,b,a,a,a,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,b,b,a,a,a,a,b,a,a,a,a,b,b,b,a,a,b,a,a,a,b,a,b,a,a,b,a,a,a,a,b,a,a,a,b,b,a,a,b,a,b,b,a,a,b,a,a,b,b,b,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,a,a,a,b,b
			,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,b,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,b,b,b,b,a,a,b,a,a,a,b,b,b,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,b,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,b,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a
			,a,b,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,b,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,b,b,b,b,a,b,a,a,a,a,a,b,a,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,a,a,b,a,a
			,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,b,a,b,b,a,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a
			,a,a,b,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a
			,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,b,a,b,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,b,a,b,a,b,a,a,b,b,b,b,a,b,b,b,b,b,a,b,a,a,a,b,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a
			,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,b,a,b,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a
			,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,b,a,b,a,a,a,a,a,b,b,b,b,b,a,a,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a
			,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,b,a,b,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b
			,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a
			,a,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,b,b,a,b,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,b,a,b,a,a,b,b,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,a
			,a,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,b,b,b,b,a,b,b,b,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,a,a,b,b,a,a,a,a,a,a,b,a,b,a,a,a,b,a,a,b,b
			,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,a,a,a,a,b,b,b,b,a,a,b,b,b,b,a,a,b,b,b,b,a,b,b,b,b,b,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,b,a,b,a,a,b,a,b,a,b,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,b,b,b,b,a,a,b,b,b,b,a,a,b,b,b,b,a,a,b,b,b,a,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,b,a,a,b,b,b,b,a,a,b,b,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,a,a,b,b,a,b,b,b,b,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,b,b,a,a,b,b,b,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,a,b,a,a,b
			,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,b,b,b,b,a,a,b,b,a,b,a,b,a,b,a,b,a,b,a,a,a,b,a,b,a,b,a,b,a,a,a,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,b,a,a,b,b,a,a,b
			,a,a,b,b,a,b,a,a,b,b,a,b,a,a,b,b,a,a,a,a,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,b,b,b,b,a,b,b,b,a,a,a,b,b,b,a,b,b,b,b,a,a,b,a,b,b,a,a,b,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,a
			,a,b,a,a,b,b,a,a,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,b,a,a,b,b,a,a,a,a,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a
			,b,b,a,b,a,a,b,b,a,b,a,a,b,b,a,b,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,b,b,b,a,a,b,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,b,b,a,a,b,b,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,a,a,a,b
			,b,a,a,a,a,a,b,b,a,a,b,a,b,a,a,a,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,a,b,b,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,b,b,b,b,b,b,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,b,b,b,a,a,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,a,a,b,a,a,a,a,a,a,b,b,b,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,a
			,a,a,a,a,a,a,a,a,b,a,b,b,b,a,a,a,a,a,b,b,b,b,a,b,a,a,a,a,a,b,b,b,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,a,a,b,a,a,a,b,a,a,b,a,b,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,b,a,a,b,a,a,a
			,b,a,b,a,a,a,b,b,b,b,a,a,a,b,a,a,a,a,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,b,a,a,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,a,a,a,b,b,b,b,b,b,b,a,a,b,a,a,b,b,b,b,b,b,a,b,a,a,a,b,b,b,b,b,b,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,a,b,a,a,b,b,b,b,b,b,b,a,b,a,a,a
			,a,a,a,a,a,a,b,b,a,a,b,a,a,b,a,a,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,b,a,a,b,a,b,a,a,a,a,a,b,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,b,a
			,a,a,a,a,b,b,a,a,a,a,b,a,a,a,b,a,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,a,a,a,b,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,b,b,b,a,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,b,a,a,a,b,a,b,a,a,a,b,a,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,b
			,b,a,a,b,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,b,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,b,a,a,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,b,a,a,a,b,a,a,a,b,a,a,a,b,a,b,b,b,b,b,a,b,a,b,b,a,a,b,a,a,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,a,b,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,a,a,a,b,a,a,a,a,a,b,b,b,a,a,b,b,b,a,a,a,b,b,b,a,b,b,b,b,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,b,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a
			,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,a,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,b,b,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,b,b,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,a,b,b,b,b,a,b,a,a,a,a,a,b,b,b,b,b,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,a,a,a,a,a,b,a,a,a,a,b,a,a,a,b,a,a,a,b,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,b,b,a,b,a,b,a,b,b,b,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,a,a,b,a,a,a,a,a,b,a,a,a,b,a,b,a,a,a,b,a,b,a,a,a,b,a,b,b,b,b,b,a,a,b,a,a,a,a,b,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,b,a,a,b,b,a,b,a,a,a,b,a,b,a,a,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,b,a,a,b,b,b,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,b,b,b,b,a,a,b,b,a,b,a,a,b,b,b,a,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,a,b,b,a,a,b,a,b,a,a,b,a,a,b,a,b,a,b,a,a,b,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,b,b,b,b,b,b,a,b,b,b,b,b,b,b,a,b,b,b,b,b,a,b,a,a,b,a,b,a,b,a,a,a,b,a,b,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,b,b,b,a,a,b,a,a,a,b,a,a,b,b,b,a,a,b,b,b,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,a,b,a,a,a,b,a,a,b,a,b,a,b,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,a,b,b,b,a,a,b,a,a,b,a,b,a,a,b,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b,a,a,b,a,b,a,a,a,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,a,a,b,a,a,a,a,b,b,b,a,a,a,b,a,a,a,a,b,a,a,b,b,b,b,b,b,b,a,a,a,a,a,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,b
			,a,a,a,b,a,a,b,b,b,a,a,b,a,a,b,a,a,b,a,a,a,b,a,a,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,b,b,b,a,a,b,a,a,a,b,a,b,b,b,b,a,b,b,b,b,a,a,b,b,b,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a
			,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a};

			return colors;

        }
    
	
		public static string GetFontPattern()
		{
			string toReturn = "info face=\"Arial\" size=16 bold=0 italic=0 charset=\"\" unicode=1 stretchH=100 smooth=1 aa=1 padding=0,0,0,0 spacing=1,1\n";
			toReturn += "common lineHeight=16 base=13 scaleW=256 scaleH=256 pages=1 packed=0\npage id=0 file=\"defaultFont_00.tga\"";
toReturn += @"chars count=319
char id=32   x=0     y=0     width=1     height=0     xoffset=0     yoffset=16    xadvance=4     page=0  chnl=0 
char id=33   x=227   y=74    width=1     height=10    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=34   x=54    y=97    width=3     height=3     xoffset=1     yoffset=3     xadvance=5     page=0  chnl=0 
char id=35   x=206   y=41    width=8     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=36   x=29    y=42    width=5     height=11    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=37   x=111   y=42    width=10    height=10    xoffset=1     yoffset=3     xadvance=12    page=0  chnl=0 
char id=38   x=215   y=41    width=8     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=39   x=62    y=96    width=1     height=3     xoffset=1     yoffset=3     xadvance=2     page=0  chnl=0 
char id=40   x=70    y=28    width=3     height=13    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=41   x=74    y=28    width=3     height=13    xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=42   x=43    y=97    width=5     height=4     xoffset=0     yoffset=3     xadvance=5     page=0  chnl=0 
char id=43   x=117   y=86    width=7     height=7     xoffset=1     yoffset=5     xadvance=8     page=0  chnl=0 
char id=44   x=64    y=96    width=1     height=3     xoffset=2     yoffset=12    xadvance=4     page=0  chnl=0 
char id=45   x=96    y=94    width=3     height=1     xoffset=0     yoffset=9     xadvance=4     page=0  chnl=0 
char id=46   x=108   y=94    width=1     height=1     xoffset=1     yoffset=12    xadvance=4     page=0  chnl=0 
char id=47   x=251   y=41    width=4     height=10    xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=48   x=229   y=52    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=49   x=189   y=74    width=3     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=50   x=236   y=52    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=51   x=243   y=52    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=52   x=0     y=67    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=53   x=7     y=67    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=54   x=14    y=67    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=55   x=21    y=66    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=56   x=28    y=66    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=57   x=35    y=66    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=58   x=216   y=85    width=1     height=7     xoffset=1     yoffset=6     xadvance=4     page=0  chnl=0 
char id=59   x=65    y=86    width=1     height=9     xoffset=1     yoffset=6     xadvance=4     page=0  chnl=0 
char id=60   x=125   y=86    width=6     height=7     xoffset=1     yoffset=5     xadvance=8     page=0  chnl=0 
char id=61   x=27    y=98    width=7     height=4     xoffset=0     yoffset=6     xadvance=8     page=0  chnl=0 
char id=62   x=132   y=85    width=6     height=7     xoffset=1     yoffset=5     xadvance=8     page=0  chnl=0 
char id=63   x=250   y=52    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=64   x=20    y=0     width=12    height=13    xoffset=0     yoffset=3     xadvance=13    page=0  chnl=0 
char id=65   x=166   y=41    width=9     height=10    xoffset=0     yoffset=3     xadvance=9     page=0  chnl=0 
char id=66   x=45    y=54    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=67   x=53    y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=68   x=61    y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=69   x=69    y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=70   x=42    y=65    width=6     height=10    xoffset=1     yoffset=3     xadvance=8     page=0  chnl=0 
char id=71   x=224   y=41    width=8     height=10    xoffset=1     yoffset=3     xadvance=10    page=0  chnl=0 
char id=72   x=77    y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=73   x=229   y=74    width=1     height=10    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=74   x=196   y=63    width=5     height=10    xoffset=0     yoffset=3     xadvance=6     page=0  chnl=0 
char id=75   x=233   y=41    width=8     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=76   x=49    y=65    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=77   x=176   y=41    width=9     height=10    xoffset=1     yoffset=3     xadvance=11    page=0  chnl=0 
char id=78   x=85    y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=79   x=242   y=41    width=8     height=10    xoffset=1     yoffset=3     xadvance=10    page=0  chnl=0 
char id=80   x=93    y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=81   x=0     y=56    width=8     height=10    xoffset=1     yoffset=3     xadvance=10    page=0  chnl=0 
char id=82   x=101   y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=83   x=109   y=53    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=84   x=117   y=53    width=7     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=85   x=125   y=52    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=86   x=75    y=42    width=11    height=10    xoffset=-1    yoffset=3     xadvance=9     page=0  chnl=0 
char id=87   x=47    y=42    width=13    height=10    xoffset=0     yoffset=3     xadvance=13    page=0  chnl=0 
char id=88   x=133   y=52    width=7     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=89   x=141   y=52    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=90   x=149   y=52    width=7     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=91   x=102   y=28    width=2     height=13    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=92   x=174   y=74    width=4     height=10    xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=93   x=105   y=28    width=2     height=13    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=94   x=240   y=84    width=5     height=5     xoffset=0     yoffset=4     xadvance=5     page=0  chnl=0 
char id=95   x=80    y=94    width=7     height=1     xoffset=0     yoffset=15    xadvance=7     page=0  chnl=0 
char id=96   x=74    y=95    width=2     height=2     xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=97   x=146   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=98   x=202   y=63    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=99   x=152   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=100  x=208   y=63    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=101  x=158   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=102  x=179   y=74    width=4     height=10    xoffset=0     yoffset=3     xadvance=3     page=0  chnl=0 
char id=103  x=214   y=63    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=104  x=220   y=63    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=105  x=231   y=74    width=1     height=10    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=106  x=78    y=28    width=3     height=13    xoffset=-1    yoffset=3     xadvance=3     page=0  chnl=0 
char id=107  x=226   y=63    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=108  x=233   y=74    width=1     height=10    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=109  x=97    y=86    width=9     height=7     xoffset=1     yoffset=6     xadvance=11    page=0  chnl=0 
char id=110  x=164   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=111  x=170   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=112  x=232   y=63    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=113  x=238   y=63    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=114  x=212   y=85    width=3     height=7     xoffset=1     yoffset=6     xadvance=4     page=0  chnl=0 
char id=115  x=176   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=116  x=53    y=87    width=3     height=9     xoffset=0     yoffset=4     xadvance=4     page=0  chnl=0 
char id=117  x=182   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=118  x=188   y=85    width=5     height=7     xoffset=0     yoffset=6     xadvance=5     page=0  chnl=0 
char id=119  x=107   y=86    width=9     height=7     xoffset=0     yoffset=6     xadvance=9     page=0  chnl=0 
char id=120  x=194   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=121  x=244   y=63    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=122  x=200   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=123  x=82    y=28    width=3     height=13    xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=124  x=254   y=14    width=1     height=12    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=125  x=86    y=28    width=3     height=13    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=126  x=66    y=96    width=7     height=2     xoffset=0     yoffset=7     xadvance=8     page=0  chnl=0 
char id=160  x=0     y=0     width=1     height=0     xoffset=0     yoffset=16    xadvance=4     page=0  chnl=0 
char id=161  x=235   y=74    width=1     height=10    xoffset=1     yoffset=6     xadvance=3     page=0  chnl=0 
char id=162  x=240   y=14    width=6     height=13    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=163  x=56    y=64    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=164  x=246   y=84    width=5     height=5     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=165  x=157   y=52    width=7     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=166  x=25    y=42    width=1     height=12    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=167  x=249   y=28    width=6     height=12    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=168  x=100   y=94    width=3     height=1     xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=169  x=122   y=41    width=10    height=10    xoffset=0     yoffset=3     xadvance=10    page=0  chnl=0 
char id=170  x=12    y=99    width=4     height=5     xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=171  x=220   y=85    width=5     height=6     xoffset=1     yoffset=7     xadvance=7     page=0  chnl=0 
char id=172  x=35    y=98    width=7     height=4     xoffset=0     yoffset=6     xadvance=8     page=0  chnl=0 
char id=173  x=104   y=94    width=3     height=1     xoffset=0     yoffset=9     xadvance=4     page=0  chnl=0 
char id=174  x=133   y=41    width=10    height=10    xoffset=0     yoffset=3     xadvance=10    page=0  chnl=0 
char id=175  x=88    y=94    width=7     height=1     xoffset=0     yoffset=2     xadvance=7     page=0  chnl=0 
char id=176  x=49    y=97    width=4     height=4     xoffset=1     yoffset=3     xadvance=5     page=0  chnl=0 
char id=177  x=67    y=86    width=7     height=8     xoffset=0     yoffset=5     xadvance=7     page=0  chnl=0 
char id=178  x=17    y=99    width=4     height=5     xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=179  x=22    y=99    width=4     height=5     xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=180  x=77    y=94    width=2     height=2     xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=181  x=250   y=63    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=182  x=177   y=28    width=7     height=12    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=183  x=110   y=94    width=1     height=1     xoffset=1     yoffset=8     xadvance=4     page=0  chnl=0 
char id=184  x=58    y=97    width=3     height=3     xoffset=1     yoffset=13    xadvance=4     page=0  chnl=0 
char id=185  x=252   y=84    width=2     height=5     xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=186  x=0     y=99    width=5     height=5     xoffset=0     yoffset=3     xadvance=5     page=0  chnl=0 
char id=187  x=226   y=85    width=5     height=6     xoffset=1     yoffset=7     xadvance=7     page=0  chnl=0 
char id=188  x=144   y=41    width=10    height=10    xoffset=1     yoffset=3     xadvance=11    page=0  chnl=0 
char id=189  x=155   y=41    width=10    height=10    xoffset=1     yoffset=3     xadvance=11    page=0  chnl=0 
char id=190  x=87    y=42    width=11    height=10    xoffset=0     yoffset=3     xadvance=11    page=0  chnl=0 
char id=191  x=63    y=64    width=6     height=10    xoffset=1     yoffset=6     xadvance=8     page=0  chnl=0 
char id=192  x=45    y=0     width=9     height=13    xoffset=0     yoffset=0     xadvance=9     page=0  chnl=0 
char id=193  x=55    y=0     width=9     height=13    xoffset=0     yoffset=0     xadvance=9     page=0  chnl=0 
char id=194  x=65    y=0     width=9     height=13    xoffset=0     yoffset=0     xadvance=9     page=0  chnl=0 
char id=195  x=75    y=0     width=9     height=13    xoffset=0     yoffset=0     xadvance=9     page=0  chnl=0 
char id=196  x=120   y=28    width=9     height=12    xoffset=0     yoffset=1     xadvance=9     page=0  chnl=0 
char id=197  x=130   y=28    width=9     height=12    xoffset=0     yoffset=1     xadvance=9     page=0  chnl=0 
char id=198  x=61    y=42    width=13    height=10    xoffset=-1    yoffset=3     xadvance=13    page=0  chnl=0 
char id=199  x=194   y=0     width=7     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=200  x=202   y=0     width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=201  x=210   y=0     width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=202  x=218   y=0     width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=203  x=185   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=204  x=108   y=28    width=2     height=13    xoffset=0     yoffset=0     xadvance=3     page=0  chnl=0 
char id=205  x=111   y=28    width=2     height=13    xoffset=1     yoffset=0     xadvance=3     page=0  chnl=0 
char id=206  x=247   y=14    width=6     height=13    xoffset=-1    yoffset=0     xadvance=3     page=0  chnl=0 
char id=207  x=17    y=42    width=3     height=12    xoffset=0     yoffset=1     xadvance=3     page=0  chnl=0 
char id=208  x=9     y=56    width=8     height=10    xoffset=0     yoffset=3     xadvance=9     page=0  chnl=0 
char id=209  x=226   y=0     width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=210  x=95    y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=211  x=104   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=212  x=113   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=213  x=122   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=214  x=150   y=28    width=8     height=12    xoffset=1     yoffset=1     xadvance=10    page=0  chnl=0 
char id=215  x=6     y=99    width=5     height=5     xoffset=1     yoffset=6     xadvance=8     page=0  chnl=0 
char id=216  x=18    y=55    width=8     height=10    xoffset=1     yoffset=3     xadvance=10    page=0  chnl=0 
char id=217  x=234   y=0     width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=218  x=242   y=0     width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=219  x=0     y=15    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=220  x=193   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=221  x=8     y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=222  x=165   y=52    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=223  x=173   y=52    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=224  x=0     y=78    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=225  x=6     y=78    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=226  x=70    y=64    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=227  x=12    y=78    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=228  x=237   y=74    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=229  x=35    y=42    width=5     height=11    xoffset=1     yoffset=2     xadvance=7     page=0  chnl=0 
char id=230  x=75    y=86    width=10    height=7     xoffset=1     yoffset=6     xadvance=12    page=0  chnl=0 
char id=231  x=18    y=78    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=232  x=24    y=77    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=233  x=30    y=77    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=234  x=77    y=64    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=235  x=243   y=74    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=236  x=221   y=74    width=2     height=10    xoffset=0     yoffset=3     xadvance=3     page=0  chnl=0 
char id=237  x=224   y=74    width=2     height=10    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=238  x=84    y=64    width=6     height=10    xoffset=-1    yoffset=3     xadvance=3     page=0  chnl=0 
char id=239  x=57    y=87    width=3     height=9     xoffset=0     yoffset=4     xadvance=3     page=0  chnl=0 
char id=240  x=91    y=64    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=241  x=36    y=77    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=242  x=42    y=76    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=243  x=48    y=76    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=244  x=98    y=64    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=245  x=54    y=76    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=246  x=249   y=74    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=247  x=232   y=85    width=7     height=5     xoffset=0     yoffset=6     xadvance=7     page=0  chnl=0 
char id=248  x=206   y=85    width=5     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=249  x=60    y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=250  x=66    y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=251  x=105   y=64    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=252  x=0     y=89    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=253  x=250   y=0     width=5     height=13    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=254  x=42    y=28    width=5     height=13    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=255  x=0     y=43    width=5     height=12    xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=256  x=140   y=28    width=9     height=12    xoffset=0     yoffset=1     xadvance=9     page=0  chnl=0 
char id=257  x=6     y=89    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=258  x=85    y=0     width=9     height=13    xoffset=0     yoffset=0     xadvance=9     page=0  chnl=0 
char id=259  x=72    y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=260  x=33    y=0     width=11    height=13    xoffset=0     yoffset=3     xadvance=9     page=0  chnl=0 
char id=261  x=181   y=52    width=7     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=262  x=16    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=263  x=78    y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=264  x=24    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=265  x=112   y=64    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=266  x=201   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=267  x=12    y=89    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=268  x=32    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=269  x=119   y=64    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=270  x=40    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=271  x=189   y=52    width=7     height=10    xoffset=1     yoffset=3     xadvance=8     page=0  chnl=0 
char id=272  x=27    y=55    width=8     height=10    xoffset=0     yoffset=3     xadvance=9     page=0  chnl=0 
char id=273  x=126   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=274  x=209   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=275  x=18    y=89    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=276  x=48    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=277  x=84    y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=278  x=217   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=279  x=24    y=88    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=280  x=56    y=14    width=7     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=281  x=90    y=75    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=282  x=64    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=283  x=133   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=284  x=131   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=285  x=0     y=29    width=6     height=13    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=286  x=140   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=287  x=48    y=28    width=5     height=13    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=288  x=159   y=28    width=8     height=12    xoffset=1     yoffset=1     xadvance=10    page=0  chnl=0 
char id=289  x=6     y=43    width=5     height=12    xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=290  x=149   y=0     width=8     height=13    xoffset=1     yoffset=3     xadvance=10    page=0  chnl=0 
char id=291  x=0     y=0     width=5     height=14    xoffset=1     yoffset=2     xadvance=7     page=0  chnl=0 
char id=292  x=72    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=293  x=7     y=29    width=6     height=13    xoffset=1     yoffset=0     xadvance=7     page=0  chnl=0 
char id=294  x=186   y=41    width=9     height=10    xoffset=0     yoffset=3     xadvance=9     page=0  chnl=0 
char id=295  x=140   y=63    width=6     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=296  x=60    y=28    width=4     height=13    xoffset=0     yoffset=0     xadvance=3     page=0  chnl=0 
char id=297  x=184   y=74    width=4     height=10    xoffset=0     yoffset=3     xadvance=3     page=0  chnl=0 
char id=298  x=12    y=43    width=4     height=12    xoffset=0     yoffset=1     xadvance=3     page=0  chnl=0 
char id=299  x=48    y=87    width=4     height=9     xoffset=0     yoffset=4     xadvance=3     page=0  chnl=0 
char id=300  x=90    y=28    width=3     height=13    xoffset=0     yoffset=0     xadvance=3     page=0  chnl=0 
char id=301  x=193   y=74    width=3     height=10    xoffset=0     yoffset=3     xadvance=3     page=0  chnl=0 
char id=302  x=94    y=28    width=3     height=13    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=303  x=114   y=28    width=2     height=13    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
char id=304  x=27    y=42    width=1     height=12    xoffset=1     yoffset=1     xadvance=3     page=0  chnl=0 
char id=305  x=218   y=85    width=1     height=7     xoffset=1     yoffset=6     xadvance=3     page=0  chnl=0 
char id=306  x=36    y=54    width=8     height=10    xoffset=1     yoffset=3     xadvance=10    page=0  chnl=0 
char id=307  x=65    y=28    width=4     height=13    xoffset=1     yoffset=3     xadvance=6     page=0  chnl=0 
char id=308  x=158   y=0     width=8     height=13    xoffset=0     yoffset=0     xadvance=6     page=0  chnl=0 
char id=309  x=14    y=28    width=6     height=13    xoffset=-2    yoffset=3     xadvance=3     page=0  chnl=0 
char id=310  x=167   y=0     width=8     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=311  x=54    y=28    width=5     height=13    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=312  x=139   y=85    width=6     height=7     xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=313  x=21    y=28    width=6     height=13    xoffset=1     yoffset=0     xadvance=7     page=0  chnl=0 
char id=314  x=117   y=28    width=2     height=13    xoffset=1     yoffset=0     xadvance=3     page=0  chnl=0 
char id=315  x=28    y=28    width=6     height=13    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=316  x=98    y=28    width=3     height=13    xoffset=0     yoffset=3     xadvance=3     page=0  chnl=0 
char id=317  x=96    y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=318  x=197   y=74    width=3     height=10    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=319  x=147   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=320  x=201   y=74    width=3     height=10    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=321  x=197   y=52    width=7     height=10    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=322  x=205   y=74    width=3     height=10    xoffset=0     yoffset=3     xadvance=3     page=0  chnl=0 
char id=323  x=80    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=324  x=102   y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=325  x=88    y=14    width=7     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=326  x=108   y=75    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=327  x=96    y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=328  x=154   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=329  x=205   y=52    width=7     height=10    xoffset=0     yoffset=3     xadvance=8     page=0  chnl=0 
char id=330  x=213   y=52    width=7     height=10    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=331  x=114   y=75    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=332  x=168   y=28    width=8     height=12    xoffset=1     yoffset=1     xadvance=10    page=0  chnl=0 
char id=333  x=30    y=88    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=334  x=176   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=335  x=120   y=75    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=336  x=185   y=0     width=8     height=13    xoffset=1     yoffset=0     xadvance=10    page=0  chnl=0 
char id=337  x=126   y=74    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=338  x=99    y=42    width=11    height=10    xoffset=1     yoffset=3     xadvance=13    page=0  chnl=0 
char id=339  x=86    y=86    width=10    height=7     xoffset=1     yoffset=6     xadvance=12    page=0  chnl=0 
char id=340  x=104   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=341  x=209   y=74    width=3     height=10    xoffset=1     yoffset=3     xadvance=4     page=0  chnl=0 
char id=342  x=112   y=14    width=7     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=343  x=213   y=74    width=3     height=10    xoffset=1     yoffset=6     xadvance=4     page=0  chnl=0 
char id=344  x=120   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=345  x=161   y=63    width=6     height=10    xoffset=0     yoffset=3     xadvance=4     page=0  chnl=0 
char id=346  x=128   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=347  x=132   y=74    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=348  x=136   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=349  x=168   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=350  x=144   y=14    width=7     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=351  x=138   y=74    width=5     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=352  x=152   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=353  x=175   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=354  x=160   y=14    width=7     height=13    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=355  x=21    y=42    width=3     height=12    xoffset=0     yoffset=4     xadvance=3     page=0  chnl=0 
char id=356  x=168   y=14    width=7     height=13    xoffset=0     yoffset=0     xadvance=7     page=0  chnl=0 
char id=357  x=144   y=74    width=5     height=10    xoffset=0     yoffset=3     xadvance=5     page=0  chnl=0 
char id=358  x=221   y=52    width=7     height=10    xoffset=0     yoffset=3     xadvance=8     page=0  chnl=0 
char id=359  x=61    y=86    width=3     height=9     xoffset=0     yoffset=4     xadvance=4     page=0  chnl=0 
char id=360  x=176   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=361  x=150   y=74    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=362  x=225   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=363  x=36    y=88    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=364  x=184   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=365  x=156   y=74    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=366  x=192   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=367  x=41    y=42    width=5     height=11    xoffset=1     yoffset=2     xadvance=7     page=0  chnl=0 
char id=368  x=200   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=369  x=162   y=74    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=370  x=208   y=14    width=7     height=13    xoffset=1     yoffset=3     xadvance=9     page=0  chnl=0 
char id=371  x=182   y=63    width=6     height=10    xoffset=1     yoffset=6     xadvance=7     page=0  chnl=0 
char id=372  x=6     y=0     width=13    height=13    xoffset=0     yoffset=0     xadvance=13    page=0  chnl=0 
char id=373  x=196   y=41    width=9     height=10    xoffset=0     yoffset=3     xadvance=9     page=0  chnl=0 
char id=374  x=216   y=14    width=7     height=13    xoffset=1     yoffset=0     xadvance=9     page=0  chnl=0 
char id=375  x=35    y=28    width=6     height=13    xoffset=0     yoffset=3     xadvance=7     page=0  chnl=0 
char id=376  x=233   y=28    width=7     height=12    xoffset=1     yoffset=1     xadvance=9     page=0  chnl=0 
char id=377  x=224   y=14    width=7     height=13    xoffset=0     yoffset=0     xadvance=7     page=0  chnl=0 
char id=378  x=168   y=74    width=5     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=379  x=241   y=28    width=7     height=12    xoffset=0     yoffset=1     xadvance=7     page=0  chnl=0 
char id=380  x=42    y=87    width=5     height=9     xoffset=1     yoffset=4     xadvance=7     page=0  chnl=0 
char id=381  x=232   y=14    width=7     height=13    xoffset=0     yoffset=0     xadvance=7     page=0  chnl=0 
char id=382  x=189   y=63    width=6     height=10    xoffset=1     yoffset=3     xadvance=7     page=0  chnl=0 
char id=383  x=217   y=74    width=3     height=10    xoffset=1     yoffset=3     xadvance=3     page=0  chnl=0 
kernings count=70
kerning first=32  second=65  amount=-1  
kerning first=49  second=49  amount=-1  
kerning first=65  second=32  amount=-1  
kerning first=65  second=84  amount=-1  
kerning first=65  second=86  amount=-1  
kerning first=65  second=87  amount=-1  
kerning first=65  second=89  amount=-1  
kerning first=70  second=44  amount=-2  
kerning first=70  second=46  amount=-2  
kerning first=70  second=65  amount=-1  
kerning first=76  second=32  amount=-1  
kerning first=76  second=84  amount=-1  
kerning first=76  second=86  amount=-1  
kerning first=76  second=87  amount=-1  
kerning first=76  second=89  amount=-1  
kerning first=76  second=121 amount=-1  
kerning first=80  second=44  amount=-2  
kerning first=80  second=46  amount=-2  
kerning first=80  second=65  amount=-1  
kerning first=84  second=44  amount=-2  
kerning first=84  second=45  amount=-1  
kerning first=84  second=46  amount=-2  
kerning first=84  second=58  amount=-2  
kerning first=84  second=65  amount=-1  
kerning first=84  second=97  amount=-2  
kerning first=84  second=99  amount=-2  
kerning first=84  second=101 amount=-2  
kerning first=84  second=105 amount=-1  
kerning first=84  second=111 amount=-2  
kerning first=84  second=114 amount=-1  
kerning first=84  second=115 amount=-2  
kerning first=84  second=117 amount=-1  
kerning first=84  second=119 amount=-1  
kerning first=84  second=121 amount=-1  
kerning first=86  second=44  amount=-1  
kerning first=86  second=45  amount=-1  
kerning first=86  second=46  amount=-1  
kerning first=86  second=58  amount=-1  
kerning first=86  second=65  amount=-1  
kerning first=86  second=97  amount=-1  
kerning first=86  second=101 amount=-1  
kerning first=86  second=111 amount=-1  
kerning first=86  second=114 amount=-1  
kerning first=86  second=117 amount=-1  
kerning first=86  second=121 amount=-1  
kerning first=87  second=44  amount=-1  
kerning first=87  second=46  amount=-1  
kerning first=87  second=65  amount=-1  
kerning first=87  second=97  amount=-1  
kerning first=89  second=44  amount=-2  
kerning first=89  second=45  amount=-1  
kerning first=89  second=46  amount=-2  
kerning first=89  second=58  amount=-1  
kerning first=89  second=65  amount=-1  
kerning first=89  second=97  amount=-1  
kerning first=89  second=101 amount=-1  
kerning first=89  second=105 amount=-1  
kerning first=89  second=111 amount=-1  
kerning first=89  second=112 amount=-1  
kerning first=89  second=113 amount=-1  
kerning first=89  second=117 amount=-1  
kerning first=89  second=118 amount=-1  
kerning first=114 second=44  amount=-1  
kerning first=114 second=46  amount=-1  
kerning first=118 second=44  amount=-1  
kerning first=118 second=46  amount=-1  
kerning first=119 second=44  amount=-1  
kerning first=119 second=46  amount=-1  
kerning first=121 second=44  amount=-1  
kerning first=121 second=46  amount=-1";
		
			return toReturn;
		
		}
	}
}
