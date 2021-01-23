using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TeamRedFinalProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        public void DoWork()
        {
        }

        public string PostSampleMethod(Stream data)
        {
            // convert Stream Data to StreamReader
            StreamReader reader = new StreamReader(data);
            // Read StreamReader data as string
            string xmlString = reader.ReadToEnd();
            string returnValue = xmlString;
            // return the XMLString data
            return returnValue;
        }
        public string GetSampleMethod(string strUserName)
        {
            StringBuilder strReturnValue = new StringBuilder();
            // return username prefixed as shown below
            strReturnValue.Append(string.Format
            ("You have entered userName as {0}", strUserName));
            return strReturnValue.ToString();
        }
    }
}
