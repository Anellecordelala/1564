using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR1
{
    internal class ChristmasDecorations
    {
        public string type { get; set; }
        public string color { get; set; }
        public uint quantity { get; set; }
        public uint CalculateOnTree()
        {
            uint areaPerDecoration = 10; // см^2
            uint treeArea = 1000; // см^2
            uint decorationsOnTree = treeArea / areaPerDecoration;
            return Math.Min(quantity, decorationsOnTree);
        }
    }
}
