using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLogix.xTend.Core;
using FactoryLogix.xTend.PartDefinition;
using FactoryLogix.xTend.DataObjects;
using FactoryLogix.xTend.Services;


namespace APITesting
{
    class Program
    {
        private static Guid sessionID = Guid.Empty;
        private static  IPartServices _partServices = new PartServices();
        static void Main()
        {            
            string server = "cwagner01"; //API Server
            string dsn = "FactoryLogix2019"; //Database Name
            string userName2 = "AegisAdmin"; 
            string password = "";
                     
            ConnectionServices cs = new ConnectionServices();
            sessionID = cs.Connect(server, userName2, password, dsn, System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName);

            //Enter part number
            Console.Write("Enter Part Number: ");
            var partnumber = Console.ReadLine();

            //retrieve part number          
            var pn = _partServices.FindParts(sessionID, PartKind.Internal, RevisionKind.CurrentRevision, AssemblyKind.BasicPartsOnly, partnumber, "*", "*", 2, 1);

            //check to see if Part Number exists
            if(pn.Results.Count == 0)
             {
                Console.WriteLine("***The Part Number does not exist***");
             }
            else
            //Cast results as an InternalPart
            if(pn.Results[0] is InternalPart)
             {                
                Console.WriteLine($"Description: " + ((InternalPart)pn.Results[0]).Description);
                Console.WriteLine($"Revision: " + ((InternalPart)pn.Results[0]).Revision);
                Console.WriteLine($"Allow Simultaneous Loading: " + ((InternalPart)pn.Results[0]).SimultaneousLoading);
                Console.WriteLine($"RoHS: " + ((InternalPart)pn.Results[0]).IsRoHS);
                Console.WriteLine($"Part Label: " + ((InternalPart)pn.Results[0]).PartLabel);
                Console.WriteLine($"Package Type: " + ((InternalPart)pn.Results[0]).PackageName);
                Console.WriteLine($"Part Type: " + ((InternalPart)pn.Results[0]).PartType);
                Console.WriteLine($"Technology: " + ((InternalPart)pn.Results[0]).MountingTechnology);                
                Console.WriteLine($"Unit of Issue: " + ((InternalPart)pn.Results[0]).UnitOfIssue);
                Console.WriteLine($"Polarized: " + ((InternalPart)pn.Results[0]).IsPolarized);
                Console.WriteLine($"Socket: " + ((InternalPart)pn.Results[0]).IsSocket);
                Console.WriteLine($"Default Stock Location: " + ((InternalPart)pn.Results[0]).DefaultStockLocation);

                Console.WriteLine("");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
