using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PlayersManagerLib
{
    public interface IPlayerMapper

    {

        bool IsPlayerNameExistsInDb(string name);

        void AddNewPlayerIntoDb(string name);

    }
    public class PlayerManager
    {
    }
}
