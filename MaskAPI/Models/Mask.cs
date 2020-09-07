namespace MaskAPI.Models
{
    public class Mask
    {
        public string MaskID { get; set; }
        public int Size { get; set; }
        public string Colour { get; set; }
        public bool New { get; set; }
        public bool PreInfected { get; set; }
        public string Design { get; set; }
        public bool Reusable { get; set; }
        public double Cost { get; set; }

        public Mask(string maskID, int size, string colour, bool @new, bool preInfected, string design, bool reusable, double cost)
        {
            this.MaskID = maskID;
            this.Size = size;
            this.Colour = colour;
            this.New = @new;
            this.PreInfected = preInfected;
            this.Design = design;
            this.Reusable = reusable;
            this.Cost = cost;
        }
    }
}