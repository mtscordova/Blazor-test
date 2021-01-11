namespace blazorserver01.Data
{
    public class BioUnit
    {


        protected string color;
        protected int posx;
        protected int posy;

        protected int living;

        protected int livingTop;

        protected int hungry;

        protected int hungryTop;

        protected Environment parent;

        public BioUnit(int x, int y, Environment e)
        {
            this.posx = x;
            this.posy = y;
            this.color = "#444444";
            this.parent = e;
        }

        public string myColor() => this.color;

        public virtual bool will_I_live() => true;
    }
}