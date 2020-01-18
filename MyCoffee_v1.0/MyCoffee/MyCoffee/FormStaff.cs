using MyCoffee.DAO;
using MyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffee {
    public partial class FormStaff : Form {
        public FormStaff() {
            InitializeComponent();
            LoadItemListToButtons();
        }

        //Hàm: chuyển mỗi Item thành từng button
        void LoadItemListToButtons() {
            //________Lấy danh sách tất cả Item
            List<Item> ItemList = ItemDAO.Instance.LoadItemList();
            //________Tab1 = danh sách item theo phân loại thứ I
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C1") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;                   
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy thông tin Item từ button.tag dùng sau này (btn_Click)
                    flpItemC1.Controls.Add(btn);
                }
            }
            //________Tab2 = danh sách item theo phân loại thứ II
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C2") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC2.Controls.Add(btn);
                }
            }
            //________Tab3 = danh sách item theo phân loại thứ III
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C3") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC3.Controls.Add(btn);
                }
            }
            //________Tab4 = danh sách item theo phân loại thứ IV
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C4") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC4.Controls.Add(btn);
                }
            }
            //________Tab5 = danh sách item theo phân loại thứ V
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C5") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC5.Controls.Add(btn);
                }
            }
            //________Tab6 = danh sách item theo phân loại thứ VI
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C6") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC6.Controls.Add(btn);
                }
            }
            //________Tab7 = danh sách item theo phân loại thứ VII
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C7") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC7.Controls.Add(btn);
                }
            }
            //________Tab8 = danh sách item theo phân loại thứ VIII
            foreach (Item item in ItemList) {
                if (item.CATEGORY == "C8") {
                    Button btn = new Button() { Width = ItemDAO.btnWidth, Height = ItemDAO.btnHeight };
                    btn.Text = item.NAME + Environment.NewLine + item.PRICE;
                    btn.Click += btn_Click;         //Hàm btn_Click (thêm item vào bill)
                    btn.Tag = item;                 //lưu lại để lấy itemID từ button dùng sau này (btn_Click)
                    flpItemC8.Controls.Add(btn);
                }
            }

        }

        void LoadItemToListView(ListView lsView, string itemID, string itemName, string itemPrice) {
            //I_LsView rỗng: thêm món 
            if (lsView.Items.Count == 0) {
                ListViewItem lsvItem = new ListViewItem(itemID);
                lsvItem.SubItems.Add(itemName);
                lsvItem.SubItems.Add("1"); //số lượng mặc định ban đầu là 1
                lsvItem.SubItems.Add(itemPrice);
                lsvItem.SubItems.Add(itemPrice);
                lsView.Items.Add(lsvItem);
            }
            //II_LsView không rỗng (xét tiếp)
            else {
                bool check = true;
                //II.1_trùng món thì tăng số lượng
                for (int nItem = 0; nItem < lsView.Items.Count; nItem++) {
                    if (lsView.Items[nItem].SubItems[0].Text == itemID) {
                        int quantity = Convert.ToInt32(lsView.Items[nItem].SubItems[2].Text.ToString());
                        int price = Convert.ToInt32(lsView.Items[nItem].SubItems[3].Text.ToString());
                        quantity++;
                        lsView.Items[nItem].SubItems[2].Text = quantity.ToString();
                        lsView.Items[nItem].SubItems[4].Text = (price * quantity).ToString(); //thành tiền mới sau khi tăng số lượng
                        check = false; //bỏ qua bước II.2
                        break;
                    }
                }
                //II.2_không trùng thì thêm món (giống bước I)
                if (check == true) {
                    ListViewItem lsvItem = new ListViewItem(itemID);
                    lsvItem.SubItems.Add(itemName);
                    lsvItem.SubItems.Add("1"); //số lượng mặc định ban đầu là 1
                    lsvItem.SubItems.Add(itemPrice);
                    lsvItem.SubItems.Add(itemPrice);
                    lsView.Items.Add(lsvItem);
                }
            }
        }

        //Hàm: thêm Item vào Bill
        void btn_Click(object sender, EventArgs e) {
            try
            {
                //I_lấy thông tin item từ button.tag đã lưu
                string itemID = ((sender as Button).Tag as Item).ID;
                string itemName = ((sender as Button).Tag as Item).NAME;
                string itemPrice = ((sender as Button).Tag as Item).PRICE;
                //II_thêm món vào hóa đơn 
                LoadItemToListView(lsvBill, itemID, itemName, itemPrice);
                //III_tổng tiền của hóa đơn
                int totalBill = 0;
                for (int nItem = 0; nItem < lsvBill.Items.Count; nItem++)
                {
                    int totalPrice = Convert.ToInt32(lsvBill.Items[nItem].SubItems[4].Text.ToString());
                    totalBill = totalBill + totalPrice;
                }
                txtTotalBill.Text = totalBill.ToString();
            }
            catch
            {
                return;
            }
        }

        //Hàm: Thanh toán, lưu hóa đơn vào database (btnPay_click)
        private void btnPay_Click(object sender, EventArgs e) {
            //I_Bill rỗng, không xuất bill
            if (lsvBill.Items.Count == 0) {
                MessageBox.Show("You haven't order!!!");
            }
            //II_Xuất bill
            else {
                if (MessageBox.Show("Do you want to pay your bill?", "Send payment confirmation", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                    //lấy idBill mới từ database 
                    int billID = BillDAO.Instance.GetMaxIDBill() + 1;
                    //lấy dữ liệu từu listView lsvBill
                    string totalBill = txtTotalBill.Text.ToString();
                    //Thêm bill 
                    BillDAO.Instance.InsertBill(billID, FormLogin.staticAccountID, totalBill);
                    //Thêm billDetail 
                    for (int nItem = 0; nItem < lsvBill.Items.Count; nItem++) {
                        int idBillDetail = BillDetailDAO.Instance.GetMaxIDBillDetail() + 1;
                        string itemID = lsvBill.Items[nItem].SubItems[0].Text.ToString();
                        string itemName = lsvBill.Items[nItem].SubItems[1].Text.ToString();
                        int quantity = Convert.ToInt32(lsvBill.Items[nItem].SubItems[2].Text.ToString());
                        string totalPrice = lsvBill.Items[nItem].SubItems[4].Text.ToString();
                        BillDetailDAO.Instance.InsertBillDetail(idBillDetail, billID, itemID, itemName, quantity, totalPrice);
                    }
                    MessageBox.Show("Payment Success!");
                    //làm mới hóa đơn
                    lsvBill.Items.Clear();
                    txtTotalBill.Clear();
                }

            }

        }


        private void AccountInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            FormAccountInfo f = new FormAccountInfo();
            f.ShowDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void HistoryBillToolStripMenuItem_Click(object sender, EventArgs e) {
            FormHistoryBill f = new FormHistoryBill();
            f.ShowDialog();
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            lsvBill.Items.Clear();
            txtTotalBill.Clear();
        }

        private void FormStaff_Load(object sender, EventArgs e) {

        }

    }
}
