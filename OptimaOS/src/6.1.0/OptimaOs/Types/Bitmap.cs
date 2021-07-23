﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleMoon.Types
{
    public class Bitmap
    {
        // properties
        public int width { get; private set; }
        public int height { get; private set; }
        public uint[] data { get; private set; }

        // constructor
        public Bitmap(int w, int h)
        {
            this.width = w;
            this.height = h;
            this.data = new uint[w * h];
        }

        public void SetSize(int w, int h) { this.width = w; this.height = h; }
        public void SetData(int w, int h, uint[] data) { this.width = w; this.height = h; this.data = data; }

        public static uint[] MENU_ICON = new uint[]
        {
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16777215, 16777215, 13516031, 13516031, 13516031, 13516031, 16777215, 16777215, 16711935, 16711935, 16711935,
            16711935, 16711935, 16777215, 13516031, 13516031, 13516031, 13516031, 13516031, 13516031, 11862256, 11862256, 16777215, 16711935, 16711935,
            16711935, 16711935, 16777215, 11862256, 13516031, 13516031, 13516031, 11862256, 11862256, 11862256, 11862256, 16777215, 16711935, 16711935,
            16711935, 16777215, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 9568449, 16777215, 16711935,
            16711935, 16777215, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 9568449, 9568449, 16777215, 16711935,
            16711935, 16777215, 9568449, 11862256, 11862256, 11862256, 11862256, 11862256, 11862256, 9568449, 9568449, 7274643, 16777215, 16711935,
            16711935, 16777215, 9568449, 9568449, 9568449, 9568449, 9568449, 9568449, 9568449, 9568449, 7274643, 7274643, 16777215, 16711935,
            16711935, 16711935, 16777215, 9568449, 9568449, 9568449, 9568449, 9568449, 9568449, 7274643, 7274643, 16777215, 16711935, 16711935,
            16711935, 16711935, 16777215, 7274643, 7274643, 7274643, 7274643, 7274643, 7274643, 7274643, 7274643, 16777215, 16711935, 16711935,
            16711935, 16711935, 16711935, 16777215, 16777215, 7274643, 7274643, 7274643, 7274643, 16777215, 16777215, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
        };

        public static uint[] LOGO_32 = new uint[]
        {
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 10178708, 10244246, 10112659, 9849743, 9521033, 9192067, 8731771, 8271475, 7745386, 7284833, 6758744, 6167117, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 10573211, 10836128, 10901921, 10836128, 10639005, 10375832, 10047122, 9652363, 9192067, 8665978, 8139888, 7613799, 7021917, 6495828, 5969739, 5443649, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 10244245, 10901921, 11165094, 11362217, 11428010, 11362217, 11165094, 10901921, 10507418, 10047122, 9521033, 8994944, 8468598, 7876716, 7285090, 6758744, 6167118, 5706565, 5246269, 4654387, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16777215, 10178452, 10901921, 11296424, 11625390, 11888306, 11954099, 11888306, 11625390, 11296424, 10901921, 10375832, 9849743, 9323397, 8731514, 8074096, 7482213, 6890331, 6364241, 5838152, 5312063, 4917560, 4457264, 16777215, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16777215, 9849743, 10639005, 11165094, 11625390, 12019893, 12282809, 12414395, 12282809, 12019893, 11625390, 11165094, 10639005, 10112659, 9520776, 8863358, 8271475, 7679336, 7021917, 6495571, 5903945, 5443393, 4983097, 4588594, 4259885, 16777215, 16711935, 16711935, 16711935,
            16711935, 16711935, 16777215, 9323653, 10244246, 10836128, 11362217, 11888306, 12282809, 12611775, 12743362, 12611775, 12282809, 11888306, 11362217, 10836128, 10244246, 9652363, 8994944, 8402805, 7745386, 7153247, 6561364, 5969738, 5443650, 4983353, 4588851, 4325677, 4259884, 16777215, 16711935, 16711935,
            16711935, 16711935, 16777215, 9718156, 10310038, 10901921, 11428010, 11954099, 12414395, 12743362, 13072071, 12743362, 12414395, 11954099, 11428010, 10901921, 10310038, 9718156, 9060480, 8403061, 7745386, 7153503, 6561621, 5969739, 5509186, 5048890, 4654387, 4325677, 4259884, 16777215, 16711935, 16711935,
            16711935, 16777215, 8863357, 9652363, 10244246, 10836128, 11362217, 11888306, 12282809, 12611775, 12743362, 12611775, 12282809, 11888306, 11362217, 10836128, 10244246, 9652363, 8994944, 8402805, 7745386, 7153247, 6561364, 5969738, 5443650, 4983353, 4588851, 4325677, 4259884, 4259884, 16777215, 16711935,
            16711935, 16777215, 8863358, 9520776, 10112659, 10639005, 11165094, 11625390, 12019893, 12282809, 12414395, 12282809, 12019893, 11625390, 11165094, 10639005, 10112659, 9520776, 8863358, 8271475, 7679336, 7021917, 6495571, 5903945, 5443393, 4983097, 4588594, 4259885, 4259884, 4259884, 16777215, 16711935,
            16777215, 7876973, 8731514, 9323397, 9849743, 10375832, 10901921, 11296424, 11625390, 11888306, 11954099, 11888306, 11625390, 11296424, 10901921, 10375832, 9849743, 9323397, 8731514, 8074096, 7482213, 6890331, 6364241, 5838152, 5312063, 4917560, 4523057, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 7876716, 8468598, 8994944, 9521033, 10047122, 10507418, 10901921, 11165094, 11362217, 11428010, 11362217, 11165094, 10901921, 10507418, 10047122, 9521033, 8994944, 8468598, 7876716, 7285090, 6758744, 6167118, 5706565, 5246269, 4785974, 4457264, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 7613799, 8139888, 8665978, 9192067, 9652363, 10047122, 10375832, 10639005, 10836128, 10901921, 10836128, 10639005, 10375832, 10047122, 9652363, 9192067, 8665978, 8139888, 7613799, 7021917, 6495828, 5969739, 5509442, 5049147, 4720180, 4391471, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 7284833, 7745386, 8271475, 8731771, 9192067, 9521033, 9849743, 10112659, 10244246, 10310038, 10244246, 10112659, 9849743, 9521033, 9192067, 8731771, 8271475, 7745386, 7284833, 6758744, 6232911, 5772359, 5312063, 4917560, 4588594, 4259885, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 6890331, 7416419, 7811179, 8271475, 8665978, 8994944, 9323397, 9520776, 9652363, 9718156, 9652363, 9520776, 9323397, 8994944, 8665978, 8271475, 7811179, 7416419, 6890331, 6430035, 5969738, 5509443, 5114940, 4785973, 4457008, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 6561364, 6956124, 7416419, 7745386, 8139888, 8468598, 8731514, 8863358, 8994944, 9060480, 8994944, 8863358, 8731514, 8468598, 8139888, 7745386, 7416419, 6956124, 6561364, 6101325, 5706565, 5312062, 4917560, 4588594, 4325677, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 6166861, 6561364, 6890331, 7284833, 7613799, 7876716, 8074096, 8271475, 8402805, 8403061, 8402805, 8271475, 8074096, 7876716, 7613799, 7284833, 6890331, 6561364, 6166861, 5772359, 5377856, 5048890, 4720180, 4391471, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 5772359, 6101325, 6430035, 6758744, 7021917, 7285090, 7482213, 7679336, 7745386, 7745386, 7745386, 7679336, 7482213, 7285090, 7021917, 6758744, 6430035, 6101325, 5772359, 5443393, 5049147, 4785973, 4522800, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 5377856, 5706565, 5969738, 6232911, 6495828, 6758744, 6890331, 7021917, 7153247, 7153503, 7153247, 7021917, 6890331, 6758744, 6495828, 6232911, 5969738, 5706565, 5377856, 5049147, 4785974, 4523057, 4325677, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 5048890, 5312062, 5509443, 5772359, 5969739, 6167118, 6364241, 6495571, 6561364, 6561621, 6561364, 6495571, 6364241, 6167118, 5969739, 5772359, 5509443, 5312062, 5048890, 4785973, 4523057, 4325677, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 4720180, 4917560, 5114940, 5312063, 5509442, 5706565, 5838152, 5903945, 5969738, 5969739, 5969738, 5903945, 5838152, 5706565, 5509442, 5312063, 5114940, 4917560, 4720180, 4522800, 4325677, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16777215, 4391471, 4588594, 4785973, 4917560, 5049147, 5246269, 5312063, 5443393, 5443650, 5509186, 5443650, 5443393, 5312063, 5246269, 5049147, 4917560, 4785973, 4588594, 4391471, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215,
            16711935, 16777215, 4325677, 4457008, 4588594, 4720180, 4785974, 4917560, 4983097, 4983353, 5048890, 4983353, 4983097, 4917560, 4785974, 4720180, 4588594, 4457008, 4325677, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935,
            16711935, 16777215, 4259884, 4259884, 4259885, 4391471, 4457264, 4523057, 4588594, 4588851, 4654387, 4588851, 4588594, 4523057, 4457264, 4391471, 4259885, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935,
            16711935, 16711935, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259885, 4325677, 4325677, 4325677, 4259885, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935, 16711935,
            16711935, 16711935, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935, 16711935,
            16711935, 16711935, 16711935, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 4259884, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
            16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16777215, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935, 16711935,
        };


    }
}