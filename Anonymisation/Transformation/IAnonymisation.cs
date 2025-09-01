namespace Anonymisation.Transformation
{
    public interface IAnonymisation<T>
    {
        T Anonymiser(T entitee);
    }
}