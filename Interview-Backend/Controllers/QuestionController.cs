using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Interview_Backend.Models;

namespace Interview_Backend.Controllers
{
    [Route("backend/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        
        private List<Question> newQ = new List<Question>{
            new Question {Id = 523329 , Items = new Item {Title = "Rustic Ergonomics" , Description = "Carbonite" , Footer = "Ergonomics"}, CreatedAt = Convert.ToDateTime("2022-01-01")},
            new Question {Id = 523330 , Items = new Item {Title = "Incredible Rustic Salad" , Description = "Carbonite" , Footer = "Ergonomics"}, CreatedAt = Convert.ToDateTime("2022-01-01")},
            new Question {Id = 523331 , Items = new Item {Title = "Rustic Ergonomics" , Description = "Carbonite" , Footer = "Ergonomics"}, Tags = new List<string> {"Sports"},  CreatedAt = Convert.ToDateTime("2022-01-01")}
        };

        // private List<FlattenQ> _q = new List<FlattenQ>
        // {
        //     new FlattenQ { Id = 523329 , Title = "Rustic Steel Salad" , Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523330 , Title = "Rustic Steel Ergonomics" , Description = "Ergonomics" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523331 , Title = "Rustic Steel Salad" , Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523332 , Title = "Rustic Steel Salad" , Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523333 , Title = "Ergonomics Industrial Steel Salad" , Description = "Ergonomics" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523334 , Title = "Rustic Steel Salad" , Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523335 , Title = "Incredible Ergonomics" , Description = "Ergonomics" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") },
        //     new FlattenQ { Id = 523335 , Title = "Incredible Ergonomics" , Description = "Ergonomics" , Footer="Ergonomic" , CreatedAt = Convert.ToDateTime("2021-06-28") }
        // };

        [HttpGet]
        public IActionResult one()
        {
            var i = new Item{
                Title = "Asdf",
                Description = "Asdf",
                Footer = "asdf"
            };


            var q = new Question{
                Id = 523329,
                Items = new Item{
                    Title = "asdf",
                    Description = "asdf",
                    Footer = "Asdf"
                },
                //Tags = new List<string> { "Sports"},
                CreatedAt = Convert.ToDateTime("2022-01-01")
            };

            return Ok(newQ);
        }

        [HttpGet]
        public IActionResult two()
        {
            var query = (from q in newQ
                        where q.Items.Description.Contains("Ergonomics") || q.Items.Title.Contains("Ergonomics") //&& q.Tags.ToString().Contains("Sports")
                        orderby q.Id descending
                        select q).Take(3);
            // var query = (from q in _q
            //             where q.Description.Contains("Ergonomics") || q.Title.Contains("Ergonomics")
            //             orderby q.Id descending
            //             select q).Take(3);



            return Ok(query);

        }

        [HttpGet]
        public IActionResult three()
        {
            // Question newQ = new Question();
            //      foreach(var x in Qs){
            //          newQ.Id = x.Id;
            //          newQ.
            //          newQ.Title = x.Title;
            //          newQ.Description = x.Description;
            //          newQ.Footer = x.Footer;
            //          newQ.CreatedAt = x.CreatedAt;
            //     }
            var q = new FlattenQ();
            foreach (var x in newQ){
                q = new FlattenQ {
                    Id = x.Id,
                    Title = x.Items.Title , 
                    Description = x.Items.Description , 
                    Footer = x.Items.Footer , 
                    Tags = x.Tags,
                    CreatedAt = x.CreatedAt
                };
            }

            return Ok(q);
            
        }
    }
}
