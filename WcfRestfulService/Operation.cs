namespace WcfRestfulService
{
    internal class Operation : IReciever
    {
        private ACTIO_LIST currentAction;

        public string GetResult()
        {
            string result;
            if (currentAction == ACTIO_LIST.CREATE)
                result = "Record Created";
            else if (currentAction == ACTIO_LIST.DELETE)
                result = "Record Deleted";
            else if (currentAction == ACTIO_LIST.READ)
                result = "Record Read";
            else
                result = "Record Updated";
            return result;
        }

        public void SetAction(ACTIO_LIST action)
        {
            currentAction = action;
        }
    }
}