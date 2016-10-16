using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Linq : Form
    {
        public Linq()
        {
            InitializeComponent();
        }
        class hocsinh
        {
            public int Ma { get; set; }
            public string Ten { get; set; }
            public int Tuoi { get; set; }
        }
        List<hocsinh> hocsinhs = new List<hocsinh>
        {
            new hocsinh{Ma=1,Ten="An",Tuoi=19},
            new hocsinh{Ma=2,Ten="Bình",Tuoi=16},
            new hocsinh{Ma=3,Ten="Lãm",Tuoi=24},
            new hocsinh {Ma=4,Ten="Lan",Tuoi=22 },
         };
        class lop
        {
            public int Ma { get; set; }
            public string Tenlop { get; set; }
        }
        List<lop> lops = new List<lop>
        {
            new lop{Ma=1,Tenlop="lớp 1"},
            new lop{Ma=2,Tenlop="lớp 2"},

         };

         


    private void Select_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh = from hs in hocsinhs
                                           select hs;
            dgvHienthi.DataSource = hocsinh.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh = from hs in hocsinhs
                                           where hs.Tuoi > int.Parse(txtWhere.Text)
                                           select hs;
            dgvHienthi.DataSource = hocsinh.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hocsinh = (from hs in hocsinhs
                           select hs.Tuoi).Sum();

            MessageBox.Show("tổng số tuổi học sinh là " + hocsinh);
        }

        private void bntMax_Click(object sender, EventArgs e)
        {
            int hocsinh = (from hs in hocsinhs
                           select hs.Tuoi).Max();

            MessageBox.Show("Tuổi lớn nhất là: " + hocsinh);
        }

        private void bntMin_Click(object sender, EventArgs e)
        {
            int hocsinh = (from hs in hocsinhs
                           select hs.Tuoi).Min();
            MessageBox.Show("Tuổi nhỏ nhất là:" + hocsinh);

        }

        private void bntTb_Click(object sender, EventArgs e)
        {
            double hocsinh = (from hs in hocsinhs
                           select hs.Tuoi).Average();
            MessageBox.Show("TB Tuổi là:" + hocsinh);
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh = (from hs in hocsinhs
                                            select hs).Take(2);
            dgvHienthi.DataSource = hocsinh.ToArray();
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh= from hs in hocsinhs
                                          where hs.Ten.StartsWith("L")
                                          select hs;
            dgvHienthi.DataSource = hocsinh.ToArray();
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh = from hs in hocsinhs
                                           where hs.Ten.EndsWith("m")
                                           select hs;
            dgvHienthi.DataSource = hocsinh.ToArray();

        }

        private void bntOrderByASC_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh = from hs in hocsinhs
                                           orderby hs.Ma descending
                                           select hs;
            dgvHienthi.DataSource = hocsinh.ToArray();
        }

        private void bntOrderByDSC_Click(object sender, EventArgs e)
        {
            IEnumerable<hocsinh> hocsinh = from hs in hocsinhs
                                           orderby hs.Ma ascending
                                           select hs;
            dgvHienthi.DataSource = hocsinh.ToArray();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            var hocsinh = from hs in hocsinhs
                                           group hs by hs.Ma;
            dgvHienthi.DataSource = hocsinh.ToArray();



        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int hocsinh = (from hs in hocsinhs
                           select hs).Count();
            MessageBox.Show("so dong la:" + hocsinh);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Hs_lop = from hs in hocsinhs
                         join lop in lops on hs.Ma equals lop.Ma
                         select new
                         {
                             Tenlop = lop.Tenlop,
                             TenHS = hs.Ten,
                             TuoiHS = hs.Tuoi,
                         };
            dgvHienthi.DataSource = Hs_lop.ToArray();
    }
    }
}


