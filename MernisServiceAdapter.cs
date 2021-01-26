using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace GameProject
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return TaskAsync(gamer).Result;
        }

        public static async Task<bool> TaskAsync(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient
                (KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.DateOfBirth.Year);

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
