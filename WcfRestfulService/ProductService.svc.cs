using System;
using System.Collections.Generic;
using WcfRestfulService.Domain;

namespace WcfRestfulService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProjectService.svc or ProjectService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        private ACommand acommand;
        private IReciever calculator = null;
        private CreateCommand createCmd;
        private DeleteCommand delCmd;
        private ReadCommand readCmd;
        private UpdateCommand updateCmd;

        List<Product> IProductService.GetProductList()
        {
            return ProductsServer.Instance.Products;
        }

        List<Entity> IProductService.GetEntitiesList()
        {
            return EntityServer.Instance.Entities;
        }

        List<Entity> IProductService.GetEntitiesById(string id)
        {
            var Id = Convert.ToInt32(id);
            return EntityServer.Instance.FilteredEntities(Id);
        }

        Status IProductService.WriteEntity(Entity obj)
        {
            var stat = new Status();
            stat.code = "200";
            stat.description = "Record inserted";
            //var jsonObj = new JavaScriptSerializer().Serialize(stat);
            return stat;
        }

        List<Status> IProductService.GetCommand(string command)
        {
            var operation = new Operation();

            createCmd = new CreateCommand(operation);
            delCmd = new DeleteCommand(operation);
            updateCmd = new UpdateCommand(operation);
            readCmd = new ReadCommand(operation);

            var statusList = new List<Status>();
            var stat = new Status();

            var commandArray = command.Split(' ');
            if (commandArray[0].ToUpper().Trim() == "DELETE")
            {
                acommand = delCmd;
            }
            else if (commandArray[0].ToUpper().Trim() == "CREATE")
            {
                acommand = createCmd;
            }
            else if (commandArray[0].ToUpper().Trim() == "UPDATE")
            {
                acommand = updateCmd;
            }
            else if (commandArray[0].ToUpper().Trim() == "READ")
            {
                acommand = readCmd;
            }
            else
            {
                stat.code = "500";
                stat.description = "Invalid command";
                //var jsonObj = new JavaScriptSerializer().Serialize(stat);
                statusList.Add(stat);
                return statusList;
            }

            stat.code = "200";
            stat.description = acommand.Execute();
            //var jsonObj = new JavaScriptSerializer().Serialize(stat);
            statusList.Add(stat);
            return statusList;
        }
    }
}