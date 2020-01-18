using MyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffee.DAO {
    public class ItemDAO {
        private static ItemDAO instance;
        public static ItemDAO Instance {
            get { if (instance == null) instance = new ItemDAO(); return ItemDAO.instance; }
            private set { ItemDAO.instance = value; }
        }

        public static int btnWidth = 90;
        public static int btnHeight = 90;

        private ItemDAO() { }

        //Hàm: lấy danh sách Item từ Database
        public List<Item> LoadItemList() {
            List<Item> ListItem = new List<Item>();
            string query = "SELECT * FROM dbo.Item";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) {
                Item itemData = new Item(item);
                ListItem.Add(itemData);
            }
            return ListItem;
        }
    }
}
