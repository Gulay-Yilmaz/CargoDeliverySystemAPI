using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Operations.UserOperations.Commands
{
    public class CreateUserCommandViewModel //eklerken içinde ne olacaksa buraya yazılır. Burada kullanıcı eklerken ben ad ve sifre aldıgım icin
                                            //burada sadece username ve password alanlarını oluşturdum
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
