using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TimKiemHanghoa
{
    public partial class Form1 : Form
    {
        ConnectAndQuery query = new ConnectAndQuery();
        public Form1()
        {
            InitializeComponent();
        }

        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("select * from HangHoa");
        }

        private void next()
        {
            txt_mah.Text = "";
            txt_tenh.Text = "";
            txt_dgianhap.Text = "";
            txt_dongiaban.Text = "";
            txt_soluong.Text = "";
            cbb_chatlieu.Text = "";
            txt_mah.Focus();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (txt_mah.Text.Equals(dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()))
                {
                    check = true;
                    MessageBox.Show("đã có mã này", "thông báo");
                    break;
                }
            }
            if (check == false)
            {
                if (txt_mah.Text == "" && txt_tenh.Text == "" && cbb_chatlieu.SelectedIndex == -1 && txt_dgianhap.Text == "" && txt_dongiaban.Text == "" && txt_soluong.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin ", "thông báo");
                }
                else
                {
                    string sql = "insert into HangHoa values(N'" + txt_mah.Text + "'" + ",N'" + txt_tenh.Text + "',N'" + cbb_chatlieu.Text + "',N'" + txt_dgianhap.Text + "',N'" + txt_dongiaban.Text + "',N'" + txt_soluong.Text + "')";
                    query.CapNhatDuLieu(sql);
                    fill();
                    next();
                }
            }

        }

        private void Txt_dgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Txt_dongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            if (txt_mah.Text == "" && txt_tenh.Text == "" && cbb_chatlieu.SelectedIndex == -1 && txt_dgianhap.Text == "" && txt_dongiaban.Text == "" && txt_soluong.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin", "thông báo");
            }
            else
            {
                string sql = "update HangHoa set TenHang=N'" + txt_tenh.Text + "',ChatLieu=N'" + cbb_chatlieu.Text + "',GiaNhap='" + txt_dgianhap.Text + "',GiaBan='" + txt_dongiaban.Text + "',SoLuong='" + txt_soluong.Text + "' where MaHang=N'" + txt_mah.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                next();
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_mah.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tenh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbb_chatlieu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_dgianhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_dongiaban.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void Bt_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mah.Text == "")
                MessageBox.Show("Mời bạn chọn hàng cần xóa");
            else
            {
                if (MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String sql = "delete from HangHoa where MaHang=N'" + txt_mah.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();
                    next();
                }
            }
        }

        private void Bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Bt_timkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from HangHoa where Mahang is not null";
            if (txt_timkiemmah.Text == "")
            {
                MessageBox.Show("vui lòng nhập mã hàng cần tìm kiếm", "thông báo");
            }
            else
            {
                sql += " and MaHang=N'" + txt_timkiemmah.Text + "'";
            }
            DataTable a = query.DocBang(sql);
            dataGridView1.DataSource = a;

        }

        private void Bt_xuat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 14;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "Chủ Tịch Đạt";

                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 14;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Copyright-NGuyễn Tiến Đạt";

                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 14;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0386123369";


                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:G5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH ĐIỂM CÁC MẶT HÀNG";

                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:E7").Font.Bold = true;
                exSheet.get_Range("A7:E7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "Mã Hàng";
                exSheet.get_Range("B7").Value = "Tên Hàng";
                exSheet.get_Range("C7").Value = "Chất Liệu";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Giá Nhập";
                exSheet.get_Range("E7").Value = "Giá Bán";
                exSheet.get_Range("F7").Value = "Số Lượng";

                //In dữ liệu
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[0].Value;
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[1].Value;
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[2].Value;
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[3].Value;
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[4].Value;
                }
                exSheet.Name = "Hàng Hóa";
                exBook.Activate(); //Kích hoạt file Excel
                //Thiết lập các thuộc tính của SaveFileDialog
                saveFileDialog1.Filter = "Excel Document(*.xls)|*.xls  |Word Document(*.doc) |*.doc|All files(*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".xls";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(saveFileDialog1.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }
    }
}
