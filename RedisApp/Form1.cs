using ServiceStack;
using ServiceStack.Redis;

namespace RedisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static RedisClient client = new RedisClient("127.0.0.1", 6379);
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> ls = new List<int>();
            ls.Add(131);
            ls.Add(232);
            ls.Add(32323);




            client.Set<string>("name", "111");
            client.Set<string>("password", "222");

            client.Set<List<int>>("ls", ls);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var name= client.Get<string>("name");
            var password= client.Get<string>("password");
            var ls = client.Get<List<int>>("ls");

            var expire = client.Expire("name", 1000);

            var type = client.Type("name");


            var append = client.Append("name", " From wurth electronic".ToAsciiBytes());

            var length = client.StrLen("name");


            var getRange = client.GetRange("name", 0, 3);

            var getAllstring = client.GetRange("name", 0, -1);


            var replace = client.Replace("name", "xxxhenry");

            var views = client.Set<int>("views", 0);
            var n= client.Incr("views");
            var n1 = client.Incr("views");
            var n2 = client.Incr("views");

            var na = client.IncrBy("views", 10);


            var p = client.Decr("views");
            var p1 = client.Decr("views");

            var pa = client.DecrBy("views", 3);
                       

            client.FlushDb();
            
            client.
            



            // get the all keys
            var keys = client.GetAllKeys();
           
        
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}