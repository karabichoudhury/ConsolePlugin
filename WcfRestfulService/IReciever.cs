namespace WcfRestfulService
{
    internal enum ACTIO_LIST
    {
        CREATE,
        READ,
        UPDATE,
        DELETE
    }

    internal interface IReciever
    {
        void SetAction(ACTIO_LIST action);
        string GetResult();
    }
}