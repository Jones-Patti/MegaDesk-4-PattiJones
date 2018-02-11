using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk_3_PattiJones
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public Material DeskMaterial { get; set; }

        public enum Material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        //Default Constructor
        public Desk()
        {
            Width = 0;
            Depth = 0;
            Drawers = 0;
            DeskMaterial = Desk.Material.Laminate;
        }

        //Non-Default Constructo
        public Desk(int width, int depth, int Drawers, Material DeskMaterial)
        {
            this.Width = Width;
            this.Depth = Depth;
            this.Drawers = Drawers;
            this.DeskMaterial = DeskMaterial;
        }
    }
}
