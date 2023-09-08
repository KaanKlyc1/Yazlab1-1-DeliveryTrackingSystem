using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace YazLab1
{
    class Bağlantı
    {
        public IFirebaseConfig config = new FirebaseConfig() 
        {
            AuthSecret = "tLFGqfIOoOzgxbgJA7xPMl2LlfJyA11zIP0dlBqD",
            BasePath = "https://yazlab1-4852e-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public IFirebaseClient client;
        public FirebaseResponse response;

    }
}
