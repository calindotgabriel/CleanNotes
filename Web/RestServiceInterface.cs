using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Web
{
    [ServiceContract]
    public interface RESTServiceInterface
    {
        [WebInvoke(Method="GET", UriTemplate="notes/", ResponseFormat=WebMessageFormat.Json)]
        [OperationContract]
        string GetAll();

    }

    [DataContract]
    public class Model
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
