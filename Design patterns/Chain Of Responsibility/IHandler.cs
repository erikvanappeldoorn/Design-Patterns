namespace Design_Patterns.Chain_Of_Responsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        
        object Handle(object request);
    }
}