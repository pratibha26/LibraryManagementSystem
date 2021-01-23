using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.IO;

namespace TeamRedFinalProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyService" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        void DoWork();

        [OperationContract(Name = "PostSampleMethod")]
        [WebInvoke(Method = "POST",
         UriTemplate = "PostSampleMethod/New")]
        string PostSampleMethod(Stream data);

        [OperationContract(Name = "GetSampleMethod")]
        [WebGet(UriTemplate = "GetSampleMethod/inputStr/{name}")]
        string GetSampleMethod(string name);
    }
}
