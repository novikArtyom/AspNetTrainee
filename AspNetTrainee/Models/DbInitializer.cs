using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetTrainee.Models
{
    public class DbInitializer: DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext db)
        {
            db.Phones.Add(new Phone { Name = "iPhone 11 Pro Max", Producer = "Apple", Price = 999 });
            db.Phones.Add(new Phone { Name = "Samsung Galaxy S20 Ultra", Producer = "Samsung", Price = 1199 });
            db.Phones.Add(new Phone { Name = "Huawei P40 Pro", Producer = "Huwaei", Price = 1250 });

            base.Seed(db);
        }
    }
}