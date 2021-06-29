namespace Its2021.CardGame.Library.Base.Utilities.Primitives
{
    public struct Vector
    {
        public static Vector Zero = new Vector(0, 0);
        public Vector(double x, double y) {
            X = x;
            Y = y;
        }

        public double X { get;}
        public double Y { get;}

        public Vector Distance(Vector vector) =>
            new Vector(this.X - vector.X, this.Y - vector.Y);

        public static Vector operator +(Vector a, Vector b)
            => new Vector(a.X + b.X, a.Y + b.Y);

        public static Vector operator -(Vector a, Vector b)
            => new Vector(a.X - b.X, a.Y - b.Y);
    }
}
