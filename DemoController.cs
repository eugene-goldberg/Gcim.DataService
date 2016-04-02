//using DataExplorer.Module.BusinessObjects;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using SelfHostedWebApiDataService.Models;
using System;
using System.Web.Http.Cors;

namespace SelfHostedWebApiDataService
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DemoController : ApiController
    {
        // GET api/demo 
        public IEnumerable<SubjectAreaDto> Get()
        {
            var db = new DataExplorerContext();

            var subjectAreas = db.SubjectAreas
                .Include("SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities")
                .Include("SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions");

            List<SubjectAreaDto> subjectAreaItems = new List<SubjectAreaDto>();

            int counter = 1;

            foreach (var subjectArea in subjectAreas)
            {
                SubjectAreaDto sa = new SubjectAreaDto();
                sa.items = new List<EntityContainer>();
                sa.text = subjectArea.Name;
                sa.Description = subjectArea.Description;
                sa.id = counter++;

                EntityContainer entityContainerEntity = new EntityContainer();
                entityContainerEntity.text = "Associated Entities"; 
                entityContainerEntity.id = counter++;

                List<object> entities = new List<object>();

                foreach (var entity in subjectArea.SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities)
                {                                      
                    EntityDto ent = new EntityDto();
                    ent.text = entity.Entity.EntityName;
                    ent.Description = entity.Entity.Description;
                    ent.id = counter++;

                    entities.Add(ent);                         
                }

                entityContainerEntity.items = entities;

                sa.items.Add(entityContainerEntity);

                EntityContainer entityContainerBusinessFunction = new EntityContainer();
                entityContainerBusinessFunction.text = "Associated Business Functions";
                entityContainerBusinessFunction.id = counter++;
                List<object> businessFunctions = new List<object>();

                foreach (var businessFunction in subjectArea.SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions)
                {
                    BusinessFunctionDto bf = new BusinessFunctionDto();
                    bf.text = businessFunction.BusinessFunction.Name;
                    bf.Description = businessFunction.BusinessFunction.Description;
                    bf.id = counter++;

                    businessFunctions.Add(bf);
                }
      
                entityContainerBusinessFunction.items = businessFunctions;
                sa.items.Add(entityContainerBusinessFunction);

                subjectAreaItems.Add(sa);
            }

            return subjectAreaItems;
        }

        // GET api/demo/5 
        public string Get(int id)
        {
            return "Hello, World!";
        }

        // POST api/demo 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/demo/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/demo/5 
        public void Delete(int id)
        {
        }

    }

    public class EntityDto
    {
        public int id { get; set; }
        public string text { get; set; }
        public string Description { get; set; }
    }

    public class BusinessFunctionDto
    {
        public int id { get; set; }
        public string text { get; set; }
        public string Description { get; set; }
    }

    public class EntityContainer
    {
        public int id { get; set; }
        public string text { get; set; }
        public List<object> items;
    }

    public class BusinessFunctionContainer
    {
        public int id { get; set; }
        public string text { get; set; }
        public List<BusinessFunctionDto> items;
    }

    public class SubjectAreaDto
    {
        public int id { get; set; }
        public string text { get; set; }
        public string Description { get; set; }
        public List<EntityContainer> items;
    }
}
