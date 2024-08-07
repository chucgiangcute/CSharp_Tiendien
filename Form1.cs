using System.Diagnostics.Eventing.Reader;

namespace CSharp_Tiendien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxKH.Items.Add("Giá điện bán lẻ");
            cbxKH.Items.Add("Dùng công tơ điện trả trước");
             string var = cbxKH.Text;
            if (var == "Giá điện bán lẻ")
            {
                banle();
            }
            else if (var == "Dùng công tơ điện trả trước") ;
            {
                tratruoc();
            }
        
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxKH.Items.Add("Giá bán lẻ điện sinh hoạt");
           // cbxKH.Items.Add("Dùng công tơ trả thẻ trước");
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int socu, somoi, sodien, thanhtien, giathanh;
        private void btnTinh_Click(object sender, EventArgs e)
        {
            socu = Convert.ToInt32(txtSocu.Text);
            somoi = Convert.ToInt32(txtSomoi.Text);
            sodien = somoi - socu;

            if (sodien == 0)
            {
                txtDien.Text = Convert.ToString(sodien);
                txtGia.Text = Convert.ToString(sodien);
                txtTien.Text = "0";
            }


            else if (sodien > 0 && sodien <= 50)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                txtDien.Text = sodien.ToString();
                thanhtien = sodien * 1806;
                txtDien.Text = sodien.ToString();
                txtTien.Text = Convert.ToString(thanhtien);
                txtGia.Text = "1806";
            }


            else if (sodien == 51 && sodien <= 100)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 1866;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "1866";
                txtTien.Text = Convert.ToString(thanhtien);
            }


            else if (sodien == 101 && sodien <= 200)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 2167;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "2167";
                txtTien.Text = Convert.ToString(thanhtien);
            }


            else if (sodien == 201 && sodien <= 300)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 2729;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "2729";
                txtTien.Text = Convert.ToString(thanhtien);
            }

            else if (sodien == 301 && sodien <= 400)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 3050;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "3050";
                txtTien.Text = Convert.ToString(thanhtien);
            }

            else if (sodien >= 400)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 3151;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "3151";
                txtTien.Text = Convert.ToString(thanhtien);
            }
            else { tratruoc(); }



        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tratruoc()
        {
            sodien = somoi - socu;
            sodien = Convert.ToInt32(sodien);
            thanhtien = sodien * 2649;
            txtDien.Text = sodien.ToString();
            txtGia.Text = "2649";
            txtTien.Text = Convert.ToString(thanhtien);
        }
        private void banle()
        {
            socu = Convert.ToInt32(txtSocu.Text);
            somoi = Convert.ToInt32(txtSomoi.Text);
            sodien = somoi - socu;

            if (sodien == 0)
            {
                txtDien.Text = Convert.ToString(sodien);
                txtGia.Text = Convert.ToString(sodien);
                txtTien.Text = "0";
            }


            else if (sodien > 0 && sodien <= 50)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                txtDien.Text = sodien.ToString();
                thanhtien = sodien * 1806;
                txtDien.Text = sodien.ToString();
                txtTien.Text = Convert.ToString(thanhtien);
                txtGia.Text = "1806";
            }


            else if (sodien == 51 && sodien <= 100)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 1866;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "1866";
                txtTien.Text = Convert.ToString(thanhtien);
            }


            else if (sodien == 101 && sodien <= 200)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 2167;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "2167";
                txtTien.Text = Convert.ToString(thanhtien);
            }


            else if (sodien == 201 && sodien <= 300)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 2729;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "2729";
                txtTien.Text = Convert.ToString(thanhtien);
            }

            else if (sodien == 301 && sodien <= 400)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 3050;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "3050";
                txtTien.Text = Convert.ToString(thanhtien);
            }

            else if (sodien >= 400)
            {
                sodien = somoi - socu;
                sodien = Convert.ToInt32(sodien);
                thanhtien = sodien * 3151;
                txtDien.Text = sodien.ToString();
                txtGia.Text = "3151";
                txtTien.Text = Convert.ToString(thanhtien);
            }

        }
       /* private void tratruoc ()
        {
            sodien = somoi - socu;
            sodien = Convert.ToInt32(sodien);
            thanhtien = sodien * 2649;
            txtDien.Text = sodien.ToString();
            txtGia.Text = "2649";
            txtTien.Text = Convert.ToString(thanhtien);
        }*/
    }
      
}
