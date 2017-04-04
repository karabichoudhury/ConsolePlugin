namespace WcfRestfulService
{
    internal class CreateCommand : ACommand
    {
        public CreateCommand(IReciever reciever)
            : base(reciever)
        {
        }

        public override string Execute()
        {
            reciever_.SetAction(ACTIO_LIST.CREATE);
            return reciever_.GetResult();
        }
    }

    internal class ReadCommand : ACommand
    {
        public ReadCommand(IReciever reciever)
            : base(reciever)
        {
        }

        public override string Execute()
        {
            reciever_.SetAction(ACTIO_LIST.READ);
            return reciever_.GetResult();
        }
    }

    internal class UpdateCommand : ACommand
    {
        public UpdateCommand(IReciever reciever)
            : base(reciever)
        {
        }

        public override string Execute()
        {
            reciever_.SetAction(ACTIO_LIST.UPDATE);
            return reciever_.GetResult();
        }
    }

    internal class DeleteCommand : ACommand
    {
        public DeleteCommand(IReciever reciever)
            : base(reciever)
        {
        }

        public override string Execute()
        {
            reciever_.SetAction(ACTIO_LIST.DELETE);
            return reciever_.GetResult();
        }
    }
}