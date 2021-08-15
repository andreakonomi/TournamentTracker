using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";


        //TODO: Wire up the CreatePrize to text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max ID
            int currentId = 1;      //if file empty

            if (prizes.Count > 1)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
                //currentId = prizes.Max(p => p.Id) + 1; can use this as well it's better
            }

            model.Id = currentId;

            //Ade new record with the new maxId + 1
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model; 

            // Load the text file to list<string>>
            //Convert to List<PrizeModel>
            //Find the max ID
            //Add the new record with the new ID
            //Convert the prizes to a list<string>
            //Save the list<string> to the text file
        }
    }
}
