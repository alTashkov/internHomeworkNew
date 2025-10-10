namespace CohesionCoupling
{
    public static class GeometryUtils
    {
        public static double CalculateVolume(
            double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalculateDiagonalXYZ(
            double width, double height, double depth)
        {
            double distance = DistanceUtils.CalculateDistance3D(
                0, 0, 0, width, height, depth);
            return distance;
        }

        public static double CalculateDiagonalXY(
            double width, double height)
        {
            double distance = DistanceUtils.CalculateDistance2D(
                0, 0, width, height);
            return distance;
        }

        public static double CalculateDiagonalXZ(
            double width, double depth)
        {
            double distance = DistanceUtils.CalculateDistance2D(
                0, 0, width, depth);
            return distance;
        }

        public static double CalculateDiagonalYZ(
            double height, double depth)
        {
            double distance = DistanceUtils.CalculateDistance2D(
                0, 0, height, depth);
            return distance;
        }
    }
}
