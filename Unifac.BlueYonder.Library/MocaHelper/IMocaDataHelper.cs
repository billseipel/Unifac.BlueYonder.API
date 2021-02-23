using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Library.MocaHelper
{
    public interface IMocaDataHelper
    {

        Task<string> GetDataFromAQuery(string query);


    }
}
