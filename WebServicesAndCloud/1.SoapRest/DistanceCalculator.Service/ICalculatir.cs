namespace DistanceCalculator.Service
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double CalcDistance(Point startPoint, Point endPoint);
    }
}
