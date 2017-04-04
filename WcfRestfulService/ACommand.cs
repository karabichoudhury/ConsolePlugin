namespace WcfRestfulService
{
    internal abstract class ACommand
    {
        protected IReciever reciever_;

        public ACommand(IReciever reciever)
        {
            reciever_ = reciever;
        }

        public abstract string Execute();
    }
}