namespace AdapterPattern
{
    /// <summary>
    /// 3头转2头 电源适配器
    /// </summary>
    public class PowerAdapter : ThreeHolePlug
    {
        public IPlug Plug = new TwoHolePlug();

        public override void Charging()
        {
            Plug.Charging();
        }
    }
}
