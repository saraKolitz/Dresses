using Dresses.Core.Entities;

namespace Dresses.Data
{
    public class DataContext 
    {
        public List<Users> Users { get; set; }
        public List<Dress> Dresses { get; set; }
        public DataContext()
        {
            Users = new List<Users> { new Users { user_id = 1, username="sara", email="asdf", is_lender=true, password_hash="123", phone_number="0548540476"} };
            Dresses = new List<Dress> { new Dress { dress_id = 1, lender_id = 5, name = "elegantic", description = "new dress", size = 38, rental_price = 700 } };
        }
        
    }
}
