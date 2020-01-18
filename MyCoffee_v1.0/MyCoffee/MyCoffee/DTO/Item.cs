using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyCoffee.DTO {
    public class Item {
        public Item(string id, string name, string price, string category) {
            this.ID = id;
            this.NAME = name;
            this.PRICE = price;
            this.CATEGORY = category;
        }

        public Item(DataRow row) {
            this.ID = row["ItemID"].ToString();
            this.NAME = row["ItemName"].ToString();
            this.PRICE = row["ItemPrice"].ToString();
            this.CATEGORY = row["ItemCategory"].ToString();
        }

        private string id;
        public string ID {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string NAME {
            get { return name; }
            set { name = value; }
        }

        private string price;
        public string PRICE {
            get { return price; }
            set { price = value; }
        }

        private string category;
        public string CATEGORY {
            get { return category; }
            set { category = value; }
        }

    }
}
