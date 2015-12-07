using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace Web
{
    public class RestService : RESTServiceInterface
    {
        public string GetAll()
        {
            //JsonFileRepo repo; 
            return string.Format("Notes come here");
        }

    }
}
