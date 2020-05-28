using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProcessDemo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public Dictionary<string, string> Get()
        {


            var testDir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(testDir);
            var process = new Process();
            process.StartInfo.FileName = Path.Combine(testDir, "bin/ProcessTest.exe");
            process.Start();


            int nProcessID = process.Id;
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            resultDict.Add("ProcessID", nProcessID.ToString());
            return resultDict;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public Dictionary<string, string> Post([FromBody]Dictionary<string, string> dictValue)
        {
            var testDir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(testDir);
            var process = new Process();
            process.StartInfo.FileName = Path.Combine(testDir, "bin/ProcessTest.exe");
            process.StartInfo.Arguments = dictValue["Test"];
            process.Start();


            int nProcessID = process.Id;
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            resultDict.Add("ProcessID", nProcessID.ToString());
            return resultDict;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
