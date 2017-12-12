using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication9.Controllers
{
    public class BatchController : ApiController
    {

        MiniAttendenceSystemEntities db = new MiniAttendenceSystemEntities();


        [Route("api/GetBatches")]
        public List<Batch> GetBatches()
        {

            db.Configuration.ProxyCreationEnabled = false;

            return db.Batches.ToList();

        }

        [Route("api/GetStudents/{batch}")]
        public List<Student> GetStudents(string batch)
        {
            db.Configuration.ProxyCreationEnabled = false;

            return db.Students.Where(u => u.Batch.Name == batch).ToList();
        
        }
       



    }
}
