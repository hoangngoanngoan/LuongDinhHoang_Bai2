namespace LuongDinhHoang_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<NhanVien> dsnv = new List<NhanVien>();
        List<QuanLy> dsql = new List<QuanLy>();
        private void btnthemnv_Click(object sender, EventArgs e)
        {
            var ten = txttennv.Text;
            var luong = long.Parse(txtlcbnv.Text);
            var newnv = new NhanVien(ten, null, luong);
            newnv.LuongThucLanh = newnv.TinhLuong();

            dsnv.Add(newnv);
            dt1.DataSource = null;
            dt1.DataSource = dsnv;
        }

        private void btnthemql_Click(object sender, EventArgs e)
        {
            var ten = txttenql.Text;
            var luong = long.Parse(txtlcbql.Text);
            var chucvu = txtchucvu.Text;
            var hoahong = float.Parse(txthoahong.Text);
            var newnv = new QuanLy(ten, null, luong, chucvu, hoahong);
            newnv.LuongThucLanh = newnv.TinhLuong();

            dsql.Add(newnv);
            dt2.DataSource = null;
            dt2.DataSource = dsql;
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            var maid = txtmanv.Text;
            foreach (var item in dsnv)
            {
                if (maid == item.MaID)
                {
                    dsnv.Remove(item);
                    break;
                }
            }
            dt1.DataSource = null;
            dt1.DataSource = dsnv;
        }

        private void btnxoaql_Click(object sender, EventArgs e)
        {
            var maid = txtmaql.Text;
            foreach (var item in dsql)
            {
                if (maid == item.MaID)
                {
                    dsql.Remove(item);
                    break;
                }
            }
            dt2.DataSource = null;
            dt2.DataSource = dsql;
        }
    }
}
