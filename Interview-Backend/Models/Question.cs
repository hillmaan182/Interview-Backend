namespace Interview_Backend.Models
{

    public class FlattenQ {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set;}
        public string Footer { get; set; }
        public IList<string> Tags {get;set;}
        public DateTime CreatedAt { get; set; }
    }

    public class Question
    {
        
            public int Id { get; set; }
            // public string Title { get; set; }
            // public string Description { get; set;}
            // public string Footer { get; set; }
            //public ICollection<Item> Items { get; set; }
            //public IList<Item>? Items { get; set; }
            public Item? Items {get;set;}

            public IList<string> Tags {get;set;}
            //public IList<Item> Items {get;set;}
            //public List<string> Tags {get;set;}
            public DateTime CreatedAt { get; set; }

            // public Question(){
            //     this.Tags = new List<string>();
            // }
    }
     public class Item{
        public string Title {get;set;}
        public string Description {get;set;}
        public string Footer {get;set;}
    }

    
}
