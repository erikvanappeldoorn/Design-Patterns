namespace Design_Patterns.Abstract_Factory
{
    public interface IMobilePhoneAbstractFactory
    {
        INormalPhone GetNormalPhone();
        ISmartPhone GetSmartPhone();
    }
}
