using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    //[TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void TestMethod1()
        {
            List<KnownColor> newList = GetColorList();

            var nnlist = newList;
        }

        public static List<KnownColor> GetColorList()
        {
            Dictionary<KnownColor, KnownColor[]> allDotNetColors = new Dictionary<KnownColor, KnownColor[]>();
            var allValues = Enum.GetValues(typeof(KnownColor)).OfType<KnownColor>();

            KnownColor[] masterColors = new KnownColor[] {
                KnownColor.Red, KnownColor.Blue, KnownColor.Yellow, KnownColor.Orange
                , KnownColor.Green, KnownColor.Gray, KnownColor.Pink, KnownColor.Cyan
                , KnownColor.Magenta, KnownColor.Purple, KnownColor.Brown, KnownColor.Orchid
                , KnownColor.Goldenrod
                //, KnownColor.White
                , KnownColor.Turquoise, KnownColor.Violet
                , KnownColor.Salmon, KnownColor.Gold, KnownColor.Silver, KnownColor.Lime
                , KnownColor.Linen, KnownColor.Aquamarine, KnownColor.Aqua, KnownColor.Khaki
            };
            foreach (KnownColor masterColor in masterColors)
            {
                var slaveColors = allValues.Where(t => t.ToString().EndsWith(masterColor.ToString())).ToArray();
                allDotNetColors.Add(masterColor, slaveColors);
            }
            var allDotNetColorsA = allDotNetColors.SelectMany(t => t.Value);
            var otherSlaveColors = allValues.Where(t => !allDotNetColors.ContainsKey(t) && !allDotNetColorsA.Contains(t)).ToArray();
            //allDotNetColors.Add(KnownColor.Black, otherSlaveColors.ToArray());

            var allDotNetColorsOrdered = allDotNetColors.OrderByDescending(t => t.Value.Length);
            var _A = new List<KnownColor>();
            _A.AddRange(allDotNetColors[KnownColor.Blue]);
            _A.AddRange(allDotNetColors[KnownColor.Aquamarine]);
            _A.AddRange(allDotNetColors[KnownColor.Gray]);
            _A.AddRange(allDotNetColors[KnownColor.Goldenrod]);
            _A.Reverse();

            var _B = new List<KnownColor>();
            _B.AddRange(allDotNetColors[KnownColor.Yellow]);
            _B.AddRange(allDotNetColors[KnownColor.Cyan]);
            _B.AddRange(allDotNetColors[KnownColor.Green]);
            _B.AddRange(allDotNetColors[KnownColor.Silver]);
            _B.AddRange(allDotNetColors[KnownColor.Orange]);
            _B.AddRange(allDotNetColors[KnownColor.Turquoise]);
            _B.AddRange(allDotNetColors[KnownColor.Aqua]);
            _B.AddRange(allDotNetColors[KnownColor.Gold]);
            _B.Reverse();

            var _C = new List<KnownColor>();
            _C.AddRange(allDotNetColors[KnownColor.Red]);
            _C.AddRange(allDotNetColors[KnownColor.Purple]);
            _C.AddRange(allDotNetColors[KnownColor.Pink]);
            _C.AddRange(allDotNetColors[KnownColor.Brown]);
            _C.AddRange(allDotNetColors[KnownColor.Magenta]);
            _C.AddRange(allDotNetColors[KnownColor.Orchid]);
            _C.AddRange(allDotNetColors[KnownColor.Khaki]);
            _C.AddRange(allDotNetColors[KnownColor.Linen]);
            _C.AddRange(allDotNetColors[KnownColor.Lime]);
            _C.AddRange(allDotNetColors[KnownColor.Salmon]);
            _C.AddRange(allDotNetColors[KnownColor.Violet]);
            _C.Reverse();

            List<KnownColor> newList = new List<KnownColor>();
            for (int i = 0; i < 31; i++)
            {
                newList.Add(_A[i]);
                newList.Add(_B[i]);
                newList.Add(_C[i]);
            }

            return newList;
        }
    }
}
