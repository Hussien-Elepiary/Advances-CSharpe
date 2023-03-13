namespace Session_01.Point
{
    public class Point2D:IComparable<Point2D>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(Point2D? other)
        {
            if (other == null) return 0 ;
            if (X == other.X)
                return Y.CompareTo(other.Y) ;
            else
                return X.CompareTo(other.X) ;
        }
    }
}
