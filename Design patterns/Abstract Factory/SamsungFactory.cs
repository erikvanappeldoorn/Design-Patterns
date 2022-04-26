namespace Design_Patterns.Abstract_Factory
{
    public class SamsungFactory : IMobilePhoneAbstractFactory
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
